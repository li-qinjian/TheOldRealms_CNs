using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using TaleWorlds.Localization;
using TOR_Core.CampaignMechanics.ServeAsAHireling;

namespace TheOldRealms_CNs.Patches
{
    [HarmonyPatch]
    internal class ServeAsAHirelingHelpersPatch
    {
        [HarmonyTranspiler]
        [HarmonyPatch(typeof(ServeAsAHirelingHelpers), "AddHirelingCustomResourceBenefits")]
        public static IEnumerable<CodeInstruction> SetupBattleMenuTranspiler(IEnumerable<CodeInstruction> instructions, ILGenerator generator)
        {
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "Knightly Service":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=1CJq27il}Knightly Service");
                            found = true;
                            break;
                        case "Leeched Dark Energy":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=grwRJzwT}Leeched Dark Energy");
                            found = true;
                            break;
                        case "Gained Power":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=rkF8YUEE}Gained Power");
                            found = true;
                            break;
                        case "Gained Respect":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=BX15hV8Y}Gained Respect");
                            found = true;
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
            if (found is false)
                throw new ArgumentException("Cannot find ldstr 'Knightly Service' in ServeAsAHirelingHelper.AddHirelingCustomResourceBenefits");
        }

        [HarmonyTranspiler]
        [HarmonyPatch(typeof(ServeAsAHirelingHelpers), "AddHirelingWage")]
        public static IEnumerable<CodeInstruction> AddHirelingWageTranspiler(IEnumerable<CodeInstruction> instructions, ILGenerator generator)
        {
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "Hireling Wage":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=FxSJn4KD}Hireling Wage");
                            found = true;
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
            if (found is false)
                throw new ArgumentException("Cannot find ldstr 'Hireling Wage' in ServeAsAHirelingHelper.AddHirelingCustomResourceBenefits");
        }
    }
}
