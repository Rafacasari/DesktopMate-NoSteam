using DesktopMate_NoSteam;
using HarmonyLib;
using Il2Cpp;
using Il2CppSteamworks;
using MelonLoader;
using System.Reflection;

[assembly: MelonInfo(typeof(NoSteamMod), "DesktopMate-NoSteam", "1.0.0", "Rafa")]
[assembly: MelonGame("infiniteloop", "DesktopMate")]

namespace DesktopMate_NoSteam
{
    public class NoSteamMod : MelonMod
    {
        private static bool NoSteam_Prefix()
        {
            return false;
        }

        public override void OnInitializeMelon()
        {

            LoggerInstance.Msg("Initialized.");

            if (!SteamAPI.Init())
            {
                LoggerInstance.Msg("Steam Client not available, enabling offline patch...");
                var method = typeof(SteamManager).GetMethod(nameof(SteamManager.Awake), BindingFlags.Instance | BindingFlags.Public);
                var prefix = typeof(NoSteamMod).GetMethod(nameof(NoSteam_Prefix), BindingFlags.Static | BindingFlags.NonPublic);
                HarmonyInstance.Patch(method, prefix: new HarmonyMethod(prefix));
            }
        }
    }
}