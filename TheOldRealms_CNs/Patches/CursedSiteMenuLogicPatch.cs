using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using TaleWorlds.Localization;
using TOR_Core.CampaignMechanics.CustomResources;
using TOR_Core.CampaignMechanics.TORCustomSettlement.CustomSettlementMenus;

namespace TheOldRealms_CNs.Patches
{
    [HarmonyPatch]
    internal class CursedSiteMenuLogicPatch
    {
        [HarmonyTranspiler]
        [HarmonyPatch(typeof(CursedSiteMenuLogic), "AddCursedSiteMenus")]
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
                        case "{tor_custom_settlement_menu_cursed_site_ghost_str}Tap into the congealed essence of Dark Magic and bind some wraiths to your will.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{lg9LtwR9}Tap into the congealed essence of Dark Magic and bind some wraiths to your will.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "{=tor_custom_settlement_cursed_site_ghosts_progress_str}Empowering your minions...":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=7TVVVUIT}Empowering your minions...");
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
                throw new ArgumentException("Cannot find ldstr '{tor_custom_settlement_menu_cursed_site_ghost_str}Tap into the congealed essence of Dark Magic and bind some wraiths to your will.' in CursedSiteMenuLogic.AddCursedSiteMenus");
        }

        [HarmonyTranspiler]
        [HarmonyPatch(typeof(CursedSiteMenuLogic), "EmpoweringUndeadCondition")]
        public static IEnumerable<CodeInstruction> EmpoweringUndeadConditionTranspiler(IEnumerable<CodeInstruction> instructions, ILGenerator generator)
        {
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "There are no undead in your party.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{mCQvdzbd}There are no undead in your party.");
                            found = true;
                            break;
                        case "You have not enough Dark Energy({DARKENERGYICON}).":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=AaIMiUaa}You have not enough Dark Energy({DARKENERGYICON}).");
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
                throw new ArgumentException("Cannot find ldstr 'There are no undead in your party.' in CursedSiteMenuLogic.EmpoweringUndeadCondition");
        }

        [HarmonyTranspiler]
        [HarmonyPatch(typeof(CursedSiteMenuLogic), "EmporingResultInit")]
        public static IEnumerable<CodeInstruction> EmporingResultInitTranspiler(IEnumerable<CodeInstruction> instructions, ILGenerator generator)
        {
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "{UNDEAD_UPGRADES} of your minions grew stronger.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{mCQvdzbd}{UNDEAD_UPGRADES} of your minions grew stronger.");
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
                throw new ArgumentException("Cannot find ldstr '{UNDEAD_UPGRADES} of your minions grew stronger.' in CursedSiteMenuLogic.EmporingResultInit");
        }
    }
}
