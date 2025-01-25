using System.Linq;
using HarmonyLib;
using RimWorld;
using Verse;

namespace NotThisOne;

[HarmonyPatch(typeof(Designator_Slaughter), nameof(Designator_Slaughter.CanDesignateThing))]
internal class Designator_Slaughter_CanDesignateThing
{
    private static void Postfix(ref AcceptanceReport __result, Thing t)
    {
        if (__result.Accepted && Current.Game.GetComponent<NotThisOneGameComponent>().list.Contains(t))
        {
            __result = false;
        }
    }
}