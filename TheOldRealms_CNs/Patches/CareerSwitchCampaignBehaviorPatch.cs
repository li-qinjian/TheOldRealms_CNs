using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using TaleWorlds.Localization;
using TOR_Core.AbilitySystem.Spells.Prayers;
using TOR_Core.CampaignMechanics.CustomDialogs;

namespace TheOldRealms_CNs.Patches
{
    [HarmonyPatch]
    internal class CareerSwitchCampaignBehaviorPatch
    {
        [HarmonyTranspiler]
        [HarmonyPatch(typeof(CareerSwitchCampaignBehavior), "DisplayPrompt")]
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
                        case "Accept":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=tor_menu_shader_cache_popup_confirm}Accept");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Decline":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=tor_menu_shader_cache_popup_reject}Decline");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
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
                throw new ArgumentException("Cannot find ldstr 'Accept' in CareerSwitchCampaignBehavior.DisplayPrompt");
        }
    }
}
