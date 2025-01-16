using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using TaleWorlds.Localization;
using TOR_Core.CampaignMechanics.TORCustomSettlement.CustomSettlementMenus;

namespace TheOldRealms_CNs.Patches
{
    [HarmonyPatch]
    internal class RaidingSiteMenuLogicPatch
    {
        [HarmonyTranspiler]
        [HarmonyPatch(typeof(RaidingSiteMenuLogic), "AddRaidingSiteMenus")]
        public static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions, ILGenerator generator)
        {
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "{tor_custom_settlement_menu_leave_str}Leave...":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=13Vft5qv}Leave...");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
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
                throw new ArgumentException("Cannot find ldstr in RaidingSiteMenuLogic.AddRaidingSiteMenus");
        }

        [HarmonyTranspiler]
        [HarmonyPatch(typeof(RaidingSiteMenuLogic), "RaidingSiteBattleConsequence")]
        public static IEnumerable<CodeInstruction> RaidingSiteBattleConsequenceTranspiler(IEnumerable<CodeInstruction> instructions, ILGenerator generator)
        {
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "Defenders":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=5G50yWZJ}Defenders");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
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
                throw new ArgumentException("Cannot find ldstr in RaidingSiteMenuLogic.RaidingSiteBattleConsequence");
        }
    }
}
