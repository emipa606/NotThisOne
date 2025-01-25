using System.Collections.Generic;
using HarmonyLib;
using RimWorld;
using Verse;

namespace NotThisOne;

[HarmonyPatch(typeof(Pawn), nameof(Pawn.GetGizmos))]
public class Pawn_GetGizmos
{
    private static IEnumerable<Gizmo> Postfix(IEnumerable<Gizmo> __result, Pawn __instance)
    {
        foreach (var item in __result)
        {
            yield return item;
        }

        if (!__instance.RaceProps.Animal || __instance.Faction != Faction.OfPlayer)
        {
            yield break;
        }

        yield return new Command_Toggle
        {
            defaultLabel = "NotThisOneLabel".Translate(),
            defaultDesc = "NotThisOneDesc".Translate(),
            icon = TexCommand.ForbidOn,
            isActive = () => Current.Game.GetComponent<NotThisOneGameComponent>().list.Contains(__instance),
            toggleAction = delegate
            {
                if (__instance.Map == null)
                {
                    return;
                }

                if (!Current.Game.GetComponent<NotThisOneGameComponent>().list.Add(__instance))
                {
                    Current.Game.GetComponent<NotThisOneGameComponent>().list.Remove(__instance);
                    __instance.Map.autoSlaughterManager.Notify_PawnChangedFaction();
                }
                else
                {
                    __instance.Map.designationManager.TryRemoveDesignationOn(__instance,
                        DesignationDefOf.Slaughter);
                    __instance.Map.autoSlaughterManager.Notify_PawnChangedFaction();
                }
            }
        };
    }
}