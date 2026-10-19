using System.Linq;
using HarmonyLib;
using RimWorld;
using Verse;

namespace NotThisOne;

[HarmonyPatch(typeof(Designator_Slaughter), nameof(Designator_Slaughter.CanDesignateThing))]
internal static class Designator_Slaughter_CanDesignateThing
{
    public static void Postfix(ref AcceptanceReport __result, Thing t)
    {
        if (__result.Accepted && Current.Game.GetComponent<NotThisOneGameComponent>().list.Contains(t))
        {
            __result = false;
        }
    }
}