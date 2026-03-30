using HarmonyLib;using Godot;

using MegaCrit.Sts2.Core.Modding;
using MegaCrit.Sts2.Core.Logging;

namespace FirstMod_Alpecor;

[ModInitializer("ModLoaded")]
public static class FirstMod_Alpecor
{
    public static void ModLoaded()
    {
        var harmony = new Harmony("firstmod.patch");
        harmony.PatchAll();
        Log.Warn("MOD FINISHED LOADING");

        // Future: register your custom cards
        // CardLibrary.Register(new MyCustomCard());

        // Future: register your custom relics
        // RelicLibrary.Register(new MyCustomRelic());
    }
}