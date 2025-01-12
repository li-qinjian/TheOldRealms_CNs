using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using TaleWorlds.Localization;
using TOR_Core.AbilitySystem;
using TOR_Core.CampaignMechanics;
using TOR_Core.CampaignMechanics.CustomResources;

namespace TheOldRealms_CNs.Patches
{
    [HarmonyPatch]
    internal class TORMapInfoVMExtensionPatch
    {
        [HarmonyTranspiler]
        [HarmonyPatch(typeof(TORMapInfoVMExtension), "GetArtilleryHintText")]
        public static IEnumerable<CodeInstruction> TranspilerGetArtilleryHintText(IEnumerable<CodeInstruction> instructions, ILGenerator generator)
        {
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "{=tor_ui_winds_of_magic_recharge_rate_str}Maximum Deployable Artillery Pieces:":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=tor_ui_artillery_amount_maximum_str}Maximum Deployable Artillery Pieces:");
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
                throw new ArgumentException("Cannot find ldstr '{=tor_ui_winds_of_magic_recharge_rate_str}Maximum Deployable Artillery Pieces:' in TORMapInfoVMExtension.GetArtilleryHintText");
        }

        [HarmonyTranspiler]
        [HarmonyPatch(typeof(TORMapInfoVMExtension), "GetBlessingHintText")]
        public static IEnumerable<CodeInstruction> TranspilerGetBlessingHintText(IEnumerable<CodeInstruction> instructions, ILGenerator generator)
        {
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "{=tor_ui_winds_of_magic_title_str}Blessing: ":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=RD57Za8O}Blessing: ");
                            found = true;
                            break;
                        case "{=tor_ui_winds_of_magic_maximum_str}Duration:":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=jSwQ0Z3P}Duration:");
                            found = true;
                            break;
                        case "{=tor_ui_winds_of_magic_recharge_rate_str}Effect:":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=LdPaERPC}Effect:");
                            found = true;
                            break;
                        case "currently no active blessing":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=Oua2AdnA}currently no active blessing");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "You are a vampire, you are your own god":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=4GpjZtoC}You are a vampire, you are your own god");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case " days":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=hFuM8Gc1} days");
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
                throw new ArgumentException("Cannot find ldstr '{=tor_ui_winds_of_magic_recharge_rate_str}Effect:' in TORMapInfoVMExtension.GetBlessingHintText");
        }

        [HarmonyTranspiler]
        [HarmonyPatch(typeof(TORMapInfoVMExtension), "GetCultureResourceHintText")]
        public static IEnumerable<CodeInstruction> TranspilerGetCultureResourceHintText(IEnumerable<CodeInstruction> instructions, ILGenerator generator)
        {
            var descriptionGetter = AccessTools.PropertyGetter(typeof(CustomResource), nameof(CustomResource.Description));
            var localizedDescriptionGetter = AccessTools.PropertyGetter(typeof(CustomResource), nameof(CustomResource.LocalizedDescription));
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Callvirt && instruction.operand == (object)descriptionGetter)
                {
                    yield return new CodeInstruction(OpCodes.Callvirt, localizedDescriptionGetter);
                    yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                    found = true;
                }
                else if (instruction.opcode == OpCodes.Ldstr && instruction.operand.ToString() == "Daily Change")
                {
                    yield return new CodeInstruction(OpCodes.Ldstr, "{=M1g7cwq0}Daily Change");
                    yield return new CodeInstruction(OpCodes.Ldnull);
                    yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                    yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                    found = true;
                }
                else
                {
                    yield return instruction;
                }
            }
            if (found is false)
                throw new ArgumentException("Cannot find instance string TOR_Core.CampaignMechanics.CustomResources.CustomResource::get_Description() in TORMapInfoVMExtension.GetCultureResourceHintText");
        }
    }
}
