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
    internal class ShrineMenuLogicPatch
    {
        [HarmonyTranspiler]
        [HarmonyPatch(typeof(ShrineMenuLogic), "AddShrineMenus")]
        public static IEnumerable<CodeInstruction> AddOakOfAgeMenusTranspiler(IEnumerable<CodeInstruction> instructions /*, ILGenerator generator*/)
        {
            var found = false;
            var i = 0;
            var listInstructions = new List<CodeInstruction>(instructions);
            foreach (var instruction in listInstructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "Defile the Shrine for Dark Energy. Followers of {GOD_NAME} will remember this":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=xprJh6ZA}Defile the Shrine for Dark Energy. Followers of {GOD_NAME} will remember this");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Praying...":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=6RW5TjRs}Praying...");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Continue":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=oUukZLPN}Continue");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Defiling the shrine...":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=34WsXeDC}Defiling the shrine...");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "You sucessfully gathered ":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=tRVH9gaP}You sucessfully gathered ");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case " Dark Energy {DARKENERGYICON}. Followers of {GOD_NAME} will perceive this as a crime.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=rcxBjJpC} Dark Energy {DARKENERGYICON}. Followers of {GOD_NAME} will perceive this as a crime.");
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
                i++;
            }
            if (found is false)
                throw new ArgumentException("Cannot find ldstr in ShrineMenuLogic.AddShrineMenus");
        }

        [HarmonyTranspiler]
        [HarmonyPatch(typeof(ShrineMenuLogic), "PrayCondition")]
        public static IEnumerable<CodeInstruction> PrayConditionTranspiler(IEnumerable<CodeInstruction> instructions /*, ILGenerator generator*/)
        {
            var found = false;
            var i = 0;
            var listInstructions = new List<CodeInstruction>(instructions);
            foreach (var instruction in listInstructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "{=tor_custom_settlement_shrine_blessing_already_active_str}You devoted your live to {CAREERGOD_NAME}. You can't pray here.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=IAa7xHTk}You devoted your live to {CAREERGOD_NAME}. You can't pray here.");
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
                i++;
            }
            if (found is false)
                throw new ArgumentException("Cannot find ldstr in ShrineMenuLogic.PrayCondition");
        }
    }
}
