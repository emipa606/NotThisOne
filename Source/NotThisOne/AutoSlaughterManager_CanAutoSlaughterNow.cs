using HarmonyLib;
using Verse;

namespace NotThisOne;

[HarmonyPatch(typeof(AutoSlaughterManager), nameof(AutoSlaughterManager.CanAutoSlaughterNow))]
internal class AutoSlaughterManager_CanAutoSlaughterNow
{
    private static bool Postfix(bool __result, Pawn animal)
    {
        if (!__result)
        {
            return false;
        }

        return Current.Game.GetComponent<NotThisOneGameComponent>()?.list.Contains(animal) == false;
    }
}