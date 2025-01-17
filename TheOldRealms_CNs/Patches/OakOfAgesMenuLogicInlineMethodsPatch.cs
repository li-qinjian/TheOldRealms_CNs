using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Reflection;
using System.Text;
using TOR_Core.CampaignMechanics.TORCustomSettlement.CustomSettlementMenus;

namespace TheOldRealms_CNs.Patches
{
    [HarmonyPatch]
    internal class OakOfAgesMenuLogicInlineMethodsPatch
    {
        [HarmonyTargetMethods]
        static IEnumerable<MethodBase> TargetMethods()
        {
            var methods = AccessTools.GetDeclaredMethods(typeof(OakOfAgesMenuLogic));
            foreach (var method in methods)
            {
                if ((method.Name.Contains("<AddBranchesOfTheOakMenu>") || method.Name.Contains("<AddWorldRootMenu>")) 
                        && method.ReturnType == typeof(bool))
                {
                    yield return method;
                }
            }
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
                        case "Reduce the travel cost.{newline}{UPGRADEFAILEDREASON}":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=2W2pFs3w}Reduce the travel cost.{newline}{UPGRADEFAILEDREASON}");
                            break;
                        case "Return to the Oak from the root exit.{UPGRADEFAILEDREASON}":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=x7vhDhJ4}Return to the Oak from the root exit.{UPGRADEFAILEDREASON}");
                            break;
                        case "All troops and heroes are healed upon using the world roots{newline}{UPGRADEFAILEDREASON}":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=b7huo6v0}All troops and heroes are healed upon using the world roots{newline}{UPGRADEFAILEDREASON}");
                            break;
                        case "Increase party Size by 10%.{newline}{UPGRADEFAILEDREASON}":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=vCejqve6}Increase party Size by 10%.{newline}{UPGRADEFAILEDREASON}");
                            break;
                        case "Increase maximum health by 10%.{UPGRADEFAILEDREASON}":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=CWYEUFDS}Increase maximum health by 10%.{UPGRADEFAILEDREASON}");
                            break;
                        case "Increase the daily harmony gain from settlements by 20%.{UPGRADEFAILEDREASON}":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=WI7t58Hc}Increase the daily harmony gain from settlements by 20%.{UPGRADEFAILEDREASON}");
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
            //if (found is false)
            //    throw new ArgumentException("Cannot find ldstr in OakOfAgesMenuLogic.AddBranchesOfTheOakMenu InlineMethods");
        }
    }
}
