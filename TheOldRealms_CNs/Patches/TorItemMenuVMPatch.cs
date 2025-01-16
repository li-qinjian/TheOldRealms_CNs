using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using TaleWorlds.Localization;
using TOR_Core.CampaignMechanics.CustomDialogs;
using TOR_Core.Items;

namespace TheOldRealms_CNs.Patches
{
    [HarmonyPatch]
    internal class TorItemMenuVMPatch
    {
        [HarmonyTranspiler]
        [HarmonyPatch(typeof(TorItemMenuVM), "ExecuteReadItem")]
        public static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions /*, ILGenerator generator*/)
        {
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "{tor_item_hint_read_scroll_finished_str} It seems that there is nothing more to gain from studying {TOR_LAST_READ_BOOK}.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=ciPRQUKu} It seems that there is nothing more to gain from studying {TOR_LAST_READ_BOOK}.");
                            found = true;
                            break;
                        case "{tor_item_hint_read_scroll_finished_str} You are already reading {TOR_LAST_READ_BOOK}.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=ivEFrGKl} You are already reading {TOR_LAST_READ_BOOK}.");
                            found = true;
                            break;
                        case "{tor_item_hint_read_scroll_selected_str} Selected {TOR_LAST_READ_BOOK} for reading!":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=fvB7E0O2} Selected {TOR_LAST_READ_BOOK} for reading!");
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
                throw new ArgumentException("Cannot find ldstr in TorItemMenuVM.ExecuteReadItem");
        }
    }
}
