using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using TaleWorlds.Localization;
using TOR_Core.CharacterDevelopment.CareerSystem.CareerButton;

namespace TheOldRealms_CNs.Patches
{
    [HarmonyPatch]
    internal class GrailKnightCareerButtonBehaviorPatch
    {
        [HarmonyTranspiler]
        [HarmonyPatch(typeof(GrailKnightCareerButtonBehavior), "ShouldButtonBeActive")]
        public static IEnumerable<CodeInstruction> ShouldButtonBeActiveTranspiler(IEnumerable<CodeInstruction> instructions /*, ILGenerator generator*/)
        {
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "Promotes your Grail Knight to a companion (Cost 100":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=FdpUljsd}Promotes your Grail Knight to a companion (Cost 100");
                            found = true;
                            break;
                        default:
                            yield return instruction;
                            break;
                    }
                    found = true;
                }
                else
                {
                    yield return instruction;
                }
            }
            if (found is false)
                throw new ArgumentException("Cannot find ldstr in GrailKnightCareerButtonBehavior.ShouldButtonBeActive");
        }
    }
}
