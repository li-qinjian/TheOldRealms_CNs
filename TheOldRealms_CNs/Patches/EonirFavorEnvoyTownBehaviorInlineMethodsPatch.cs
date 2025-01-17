using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Localization;
using TOR_Core.CampaignMechanics.Menagery;

namespace TheOldRealms_CNs.Patches
{
    [HarmonyPatch]
    internal class EonirFavorEnvoyTownBehaviorInlineMethodsPatch
    {
        [HarmonyTargetMethods]
        static IEnumerable<MethodBase> TargetMethods()
        {
            yield return AccessTools.FirstMethod(typeof(EonirFavorEnvoyTownBehavior), methodInfo => methodInfo.Name.Contains("LearnNewLoresPrompt"));
            yield return AccessTools.FirstMethod(typeof(EonirFavorEnvoyTownBehavior), methodInfo => methodInfo.Name.Contains("ForcePeacePrompt"));
            yield return AccessTools.FirstMethod(typeof(EonirFavorEnvoyTownBehavior), methodInfo => methodInfo.Name.Contains("ForceWarPrompt"));
            yield return AccessTools.FirstMethod(typeof(EonirFavorEnvoyTownBehavior), methodInfo => methodInfo.Name.Contains("SlaverTidePrompt"));
            yield return AccessTools.FirstMethod(typeof(EonirFavorEnvoyTownBehavior), methodInfo => methodInfo.Name.Contains("ShowTroopSelectionScreen"));
            yield return AccessTools.FirstMethod(typeof(EonirFavorEnvoyTownBehavior), methodInfo => methodInfo.Name.Contains("AsurDiplomacyPrompt"));
        }

        [HarmonyTranspiler]
        public static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions, ILGenerator generator, MethodBase method)
        {
            if (method.Name.Contains("LearnNewLoresPrompt"))
            {
                return LearnNewLoresPromptTranspiler(instructions, generator, method);
            }
            else if (method.Name.Contains("ForcePeacePrompt"))
            {
                return ForcePeacePromptTranspiler(instructions, generator, method);
            }
            else if (method.Name.Contains("ForceWarPrompt"))
            {
                return ForceWarPromptTranspiler(instructions, generator, method);
            }
            else if (method.Name.Contains("SlaverTidePrompt"))
            {
                return SlaverTidePromptTranspiler(instructions, generator, method);
            }
            else if (method.Name.Contains("ShowTroopSelectionScreen"))
            {
                return ShowTroopSelectionScreenTranspiler(instructions, generator, method);
            }
            else if (method.Name.Contains("AsurDiplomacyPrompt"))
            {
                return AsurDiplomacyPromptTranspiler(instructions, generator, method);
            }

            return instructions;
        }

        private static IEnumerable<CodeInstruction> LearnNewLoresPromptTranspiler(IEnumerable<CodeInstruction> instructions, ILGenerator generator, MethodBase method)
        {
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "Learn new lore":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=fVABwOgl}Learn new lore");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Force Peace":
                            var codeInstruction = new CodeInstruction(OpCodes.Ldstr, "{=WDLtnx3B}Force Peace");
                            codeInstruction.labels.AddRange(instruction.labels);
                            yield return codeInstruction;
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Select a new lore to learn ( maximum 3)":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=M7rmSbLs}Select a new lore to learn ( maximum 3)");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Confirm":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=tor_menu_shader_cache_popup_confirm}Confirm");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Cancel":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=tor_menu_shader_cache_popup_reject}Cancel");
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
                throw new ArgumentException("Cannot find ldstr 'Learn new lore' in EonirFavorEnvoyTownBehavior.LearnNewLoresPrompt methods");
        }

        private static IEnumerable<CodeInstruction> ForcePeacePromptTranspiler(IEnumerable<CodeInstruction> instructions, ILGenerator generator, MethodBase method)
        {
            var EncyclopediaTitleProperty = AccessTools.PropertyGetter(typeof(Kingdom), "EncyclopediaTitle");
            var NameProperty = AccessTools.PropertyGetter(typeof(Kingdom), "Name");
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "Force Peace with":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=WDLtnx3B}Force Peace with");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Force Peace":
                            var codeInstruction = new CodeInstruction(OpCodes.Ldstr, "{=WDLtnx3B}Force Peace");
                            codeInstruction.labels.AddRange(instruction.labels);
                            yield return codeInstruction;
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Force an empire state to be in peace with the eonir":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=q99lDm1L}Force an empire state to be in peace with the eonir");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Confirm":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=tor_menu_shader_cache_popup_confirm}Confirm");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Cancel":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=tor_menu_shader_cache_popup_reject}Cancel");
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
                else if (instruction.opcode == OpCodes.Callvirt && instruction.operand == (object)EncyclopediaTitleProperty)
                {
                    yield return new CodeInstruction(OpCodes.Callvirt, NameProperty);
                }
                else
                {
                    yield return instruction;
                }
            }
            if (found is false)
                throw new ArgumentException("Cannot find ldstr 'Force Peace with' in EonirFavorEnvoyTownBehavior.ForcePeacePrompt methods");
        }

        private static IEnumerable<CodeInstruction> ForceWarPromptTranspiler(IEnumerable<CodeInstruction> instructions, ILGenerator generator, MethodBase method)
        {
            var EncyclopediaTitleProperty = AccessTools.PropertyGetter(typeof(Kingdom), "EncyclopediaTitle");
            var NameProperty = AccessTools.PropertyGetter(typeof(Kingdom), "Name");
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "Force war between two kingdoms":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=B7wUIrpo}Force war between two kingdoms");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Improve Relationship with one faction":
                            var codeInstruction = new CodeInstruction(OpCodes.Ldstr, "{=TkjsDGiy}Improve Relationship with one faction");
                            codeInstruction.labels.AddRange(instruction.labels);
                            yield return codeInstruction;
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Select 2 Factions war will emerge between.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=wz15kkuj}Select 2 Factions war will emerge between.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Confirm":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=tor_menu_shader_cache_popup_confirm}Confirm");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Cancel":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=tor_menu_shader_cache_popup_reject}Cancel");
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
                else if (instruction.opcode == OpCodes.Callvirt && instruction.operand == (object)EncyclopediaTitleProperty)
                {
                    yield return new CodeInstruction(OpCodes.Callvirt, NameProperty);
                }
                else
                {
                    yield return instruction;
                }
            }
            if (found is false)
                throw new ArgumentException("Cannot find ldstr 'Force war between two kingdoms' in EonirFavorEnvoyTownBehavior.ForceWarPrompt methods");
        }

        private static IEnumerable<CodeInstruction> SlaverTidePromptTranspiler(IEnumerable<CodeInstruction> instructions, ILGenerator generator, MethodBase method)
        {
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "Choose a kingdom to be swarmed":
                            var codeInstruction = new CodeInstruction(OpCodes.Ldstr, "{=P0A7V8TQ}Choose a kingdom to be swarmed");
                            codeInstruction.labels.AddRange(instruction.labels);
                            yield return codeInstruction;
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Select a kingdom being swarmed by druchii slaver troops.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=WlIpxiKK}Select a kingdom being swarmed by druchii slaver troops.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Confirm":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=tor_menu_shader_cache_popup_confirm}Confirm");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Cancel":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=tor_menu_shader_cache_popup_reject}Cancel");
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
                throw new ArgumentException("Cannot find ldstr 'Choose a kingdom to be swarmed' in EonirFavorEnvoyTownBehavior.SlaverTidePrompt methods");
        }

        private static IEnumerable<CodeInstruction> ShowTroopSelectionScreenTranspiler(IEnumerable<CodeInstruction> instructions, ILGenerator generator, MethodBase method)
        {
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        //case "Asur support":
                        //    var codeInstruction = new CodeInstruction(OpCodes.Ldstr, "{=hRWmIRtU}Asur support");
                        //    codeInstruction.labels.AddRange(instruction.labels);
                        //    yield return codeInstruction;
                        //    yield return new CodeInstruction(OpCodes.Ldnull);
                        //    yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                        //    yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                        //    found = true;
                        //    break;
                        case "Asur support":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=hRWmIRtU}Asur support");
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
                throw new ArgumentException("Cannot find ldstr 'Asur support' in EonirFavorEnvoyTownBehavior.ShowTroopSelectionScreen methods");
        }

        private static IEnumerable<CodeInstruction> AsurDiplomacyPromptTranspiler(IEnumerable<CodeInstruction> instructions, ILGenerator generator, MethodBase method)
        {
            var EncyclopediaTitleProperty = AccessTools.PropertyGetter(typeof(Kingdom), "EncyclopediaTitle");
            var NameProperty = AccessTools.PropertyGetter(typeof(Kingdom), "Name");
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "Improve relationship":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=B0QFjTwp}Improve relationship");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Improve Relationship with one faction":
                            var codeInstruction = new CodeInstruction(OpCodes.Ldstr, "{=TkjsDGiy}Improve Relationship with one faction");
                            codeInstruction.labels.AddRange(instruction.labels);
                            yield return codeInstruction;
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Choose a faction, the relation of you will improve by 15, and the eonir faction aswell.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=t58yk3Lb}Choose a faction, the relation of you will improve by 15, and the eonir faction aswell.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Confirm":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=tor_menu_shader_cache_popup_confirm}Confirm");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Cancel":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=tor_menu_shader_cache_popup_reject}Cancel");
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
                else if (instruction.opcode == OpCodes.Callvirt && instruction.operand == (object)EncyclopediaTitleProperty)
                {
                    yield return new CodeInstruction(OpCodes.Callvirt, NameProperty);
                }
                else
                {
                    yield return instruction;
                }
            }
            if (found is false)
                throw new ArgumentException("Cannot find ldstr 'Force war between two kingdoms' in EonirFavorEnvoyTownBehavior.AsurDiplomacyPrompt methods");
        }
    }
}
