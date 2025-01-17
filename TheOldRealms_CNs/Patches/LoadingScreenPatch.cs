using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
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

        //[HarmonyTranspiler]
        //[HarmonyPatch(typeof(LoadingWindowViewModel), "Update")]
        //public static IEnumerable<CodeInstruction> UpdateTranspiler(IEnumerable<CodeInstruction> instructions /*, ILGenerator generator*/)
        //{
        //    var found = false;
        //    foreach (var instruction in instructions)
        //    {
        //        if (instruction.opcode == OpCodes.Ldstr)
        //        {
        //            var stringOperand = instruction.operand.ToString();
        //            switch (stringOperand)
        //            {
        //                case "Shader compilation in progress. Remaining shaders to compile: ":
        //                    yield return new CodeInstruction(OpCodes.Ldstr, "{=GJfeZNQc}Shader compilation in progress. Remaining shaders to compile: ");
        //                    yield return new CodeInstruction(OpCodes.Ldnull);
        //                    yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
        //                    yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
        //                    found = true;
        //                    break;
        //                default:
        //                    yield return instruction;
        //                    break;
        //            }
        //            found = true;
        //        }
        //        else
        //        {
        //            yield return instruction;
        //        }
        //    }
        //    if (found is false)
        //        throw new ArgumentException("Cannot find ldstr in LoadingWindowViewModel.Update");
        //}
    }
}
