using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using TaleWorlds.Localization;
using TheOldRealms_CNs.Extensions;
using TOR_Core.Utilities;

namespace TheOldRealms_CNs.Patches
{
    [HarmonyPatch]
    internal class TORSkillBookCampaignBehaviorPatch
    {
        [HarmonyTranspiler]
        [HarmonyPatch("TORSkillBookCampaignBehavior", "CalculateSkillTupleProgression")]
        public static IEnumerable<CodeInstruction> CalculateSkillTupleProgressionTranspiler(IEnumerable<CodeInstruction> instructions /*, ILGenerator generator*/)
        {
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "{0} has gained the {1} ability!":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{0} 掌握了 {1}");
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
                throw new ArgumentException("Cannot find ldstr in TORSkillBookCampaignBehavior.CalculateSkillTupleProgression");
        }
    }
}
