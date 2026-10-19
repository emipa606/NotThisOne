using HarmonyLib;
using Verse;

namespace NotThisOne;

[HarmonyPatch(typeof(AutoSlaughterManager), nameof(AutoSlaughterManager.CanAutoSlaughterNow))]
internal static class AutoSlaughterManager_CanAutoSlaughterNow
{
    public static bool Postfix(bool __result, Pawn animal)
    {
        if (!__result)
        {
            return false;
        }

        return Current.Game.GetComponent<NotThisOneGameComponent>()?.list.Contains(animal) == false;
    }
}