using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using TaleWorlds.Localization;
using TOR_Core.CampaignMechanics.CustomDialogs;
using TOR_Core.CampaignMechanics.CustomEncounterDialogs;

namespace TheOldRealms_CNs.Patches
{
    [HarmonyPatch]
    internal class CustomDialogCampaignBehaviorPatch
    {
        [HarmonyTranspiler]
        [HarmonyPatch(typeof(CustomDialogCampaignBehavior), "Start")]
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
                        case "I will return!":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=FtLhGJuH}I will return!");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "The dark gods have abandoned us!":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=99HbzqtI}The dark gods have abandoned us!");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "The schemes of Tzeentch are endless, you have accomplished nothing!":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=CTyb6l9M}The schemes of Tzeentch are endless, you have accomplished nothing!");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "You may have won the battle, but my life has been more successful than yours will ever be!":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=9OZKNj67}You may have won the battle, but my life has been more successful than yours will ever be!");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Today, death. Tomorrow, rebirth. The cycle cannot be stopped!":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=NN88q4oH}Today, death. Tomorrow, rebirth. The cycle cannot be stopped!");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "{=!}Our defeat is a mockery to Khaine.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=byjd11Ie}Our defeat is a mockery to Khaine.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "{=!}Sell your prisoners as slaves ({RANSOM_AMOUNT}{GOLD_ICON})":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=A7SseJu8}Sell your prisoners as slaves ({RANSOM_AMOUNT}{GOLD_ICON})");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "You have no prisoners to sell.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=vXjUux1L}You have no prisoners to sell.");
                            break;
                        case "You are at war with this faction.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=U92gQ6Ic}You are at war with this faction.");
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
                throw new ArgumentException("Cannot find ldstr 'I will return!' in CustomDialogCampaignBehavior.Start");
        }
    }
}
