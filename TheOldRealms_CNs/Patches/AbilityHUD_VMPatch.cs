using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Text;
using TheOldRealms_CNs.Extensions;
using TOR_Core.AbilitySystem;

namespace TheOldRealms_CNs.Patches
{
    [HarmonyPatch]
    internal class AbilityHUD_VMPatch
    {
        /// <summary>
        /// 这个函数每一帧都会调用，所以暂时不汉化战斗中的技能类型描述了
        /// </summary>
        /// <param name="__instance"></param>
        /// <param name="____ability"></param>
        [HarmonyPostfix]
        [HarmonyPatch(typeof(AbilityHUD_VM), "RefreshValues")]
        public static void Postfix(AbilityHUD_VM __instance, Ability ____ability)
        {
            if (__instance.IsVisible)
            {
                __instance.AbilityType = ____ability.Template.AbilityType.ToTextObject().ToString();
            }
        }
    }
}
