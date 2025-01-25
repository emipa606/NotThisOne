using System.Reflection;
using HarmonyLib;
using Verse;

namespace NotThisOne;

[StaticConstructorOnStartup]
public static class StartUp
{
    static StartUp()
    {
        new Harmony("NotThisOne.patch").PatchAll(Assembly.GetExecutingAssembly());
    }
}