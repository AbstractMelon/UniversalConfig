using BepInEx;
using BepInEx.Configuration;
using BoplFixedMath;
using HarmonyLib;
using System.IO;
using System.Reflection;

namespace ModNamespace
{
    [BepInPlugin("com.rbdev.NewMod", "NewMod", "1.0.0")]
    [BepInProcess("BoplBattle.exe")]

    public class Plugin : BaseUnityPlugin
    {
        private void Awake()
        {
            // Plugin startup logic
            Logger.LogInfo("Plugin New Mod is loaded!");
            Harmony harmony = new Harmony("com.rbdev.NewMod");

            MethodInfo original = AccessTools.Method(typeof(?), "?");
            MethodInfo patch = AccessTools.Method(typeof(Patch), "?");

            harmony.Patch(original,new HarmonyMethod(patch));
        }
    }
    public class Patches {
        public static void Patch() {
            // code goes here
        }
    }
}