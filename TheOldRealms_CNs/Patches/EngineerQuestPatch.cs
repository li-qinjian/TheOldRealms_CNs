using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using TaleWorlds.Localization;
using TOR_Core.CharacterDevelopment.CareerSystem.CareerButton;
using TOR_Core.Quests;

namespace TheOldRealms_CNs.Patches
{
    [HarmonyPatch]
    internal class EngineerQuestPatch
    {
        [HarmonyTranspiler]
        [HarmonyPatch(typeof(EngineerQuest), "InitializeQuest")]
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
                        case "{tor_quest_engineer_cultist_party_str} Runaway Thieves":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=cFZAJ6jS} Runaway Thieves");
                            found = true;
                            break;
                        case "{tor_quest_engineer_cultist_party_leader_str} Runaway Thieves Leader":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{k5lyQIjw} Runaway Thieves Leader");
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
                throw new ArgumentException("Cannot find ldstr in EngineerQuest.InitializeQuest");
        }

        [HarmonyTranspiler]
        [HarmonyPatch(typeof(EngineerQuest), "Title", MethodType.Getter)]
        public static IEnumerable<CodeInstruction> TitlePropertyGetterTranspiler(IEnumerable<CodeInstruction> instructions /*, ILGenerator generator*/)
        {
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "Runaway Parts":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=l28hyeyC}Runaway Parts");
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
                throw new ArgumentException("Cannot find ldstr in EngineerQuest.TitlePropertyGetter");
        }
    }
}
