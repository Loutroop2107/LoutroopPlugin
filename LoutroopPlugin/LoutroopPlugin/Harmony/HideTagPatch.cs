using Harmony;

namespace LoutroopPlugin.Harmony
{
    [HarmonyPatch(typeof(CharacterClassManager), nameof(CharacterClassManager.CallCmdRequestHideTag))]
    class HideTagPatch
    {
        private static bool Prefix(CharacterClassManager __instance)
        {
            bool a = LoutroopPlugin.GetPlayer(__instance.gameObject).queryProcessor.PlayerId == EventHandlers.SCP181?.queryProcessor.PlayerId;
            if (a) __instance.TargetConsolePrint(__instance.connectionToClient, "你在干什么？停下来！", "green");
            return !a;
        }

    }
}
