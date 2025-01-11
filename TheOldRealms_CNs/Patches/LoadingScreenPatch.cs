using HarmonyLib;
using System;
using TaleWorlds.Engine;
using TaleWorlds.Localization;
using TaleWorlds.MountAndBlade.GauntletUI;

namespace TheOldRealms_CNs.Patches
{
    [HarmonyPatch]
    public static class LoadingScreenPatch
    {
        [HarmonyPostfix]
        [HarmonyPatch(typeof(LoadingWindowViewModel), "Update")]
        public static void PostFix(LoadingWindowViewModel __instance)
        {
            int num = Utilities.GetNumberOfShaderCompilationsInProgress();
            if (num > 0)
            {
                //__instance.DescriptionText = string.Format("{0}{1}", new TextObject("{=GJfeZNQc}Shader compilation in progress. Remaining shaders to compile:"), num);
                __instance.DescriptionText = string.Format("{0}{1}", SubModule.ShadersCompilingString, num);
            }
        }
    }
}
