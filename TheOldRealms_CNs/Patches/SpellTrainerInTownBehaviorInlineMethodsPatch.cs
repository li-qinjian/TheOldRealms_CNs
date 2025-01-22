using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Reflection;
using System.Text;
using TOR_Core.CampaignMechanics.Menagery;
using TOR_Core.CampaignMechanics.SpellTrainers;
using TaleWorlds.Localization;

namespace TheOldRealms_CNs.Patches
{
    [HarmonyPatch]
    internal class SpellTrainerInTownBehaviorInlineMethodsPatch
    {
        [HarmonyTargetMethods]
        static IEnumerable<MethodBase> TargetMethods()
        {
            yield return AccessTools.FirstMethod(typeof(SpellTrainerInTownBehavior), methodInfo => methodInfo.Name.Contains("additionalLoresPrompt"));
            yield return AccessTools.FirstMethod(typeof(SpellTrainerInTownBehavior), methodInfo => methodInfo.Name.Contains("spellweaverPrompt"));
        }

        [HarmonyTranspiler]
        public static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions, ILGenerator generator, MethodBase method)
        {
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "Confirm":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=v8KWNkEo}Confirm");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            break;
                        case "Cancel":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=i2o7tfXd}Cancel");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            break;
                        default:
                            yield return instruction;
                            break;
                    }
                }
                else
                {
                    yield return instruction;
                }
            }
        }
    }
}
