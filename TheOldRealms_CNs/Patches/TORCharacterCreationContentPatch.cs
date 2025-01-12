using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;
using TaleWorlds.Library;
using TaleWorlds.Localization;
using TaleWorlds.ModuleManager;
using TOR_Core.AbilitySystem.Spells;
using TOR_Core.CampaignMechanics.CharacterCreation;
using TOR_Core.Extensions;
using TOR_Core.Extensions.ExtendedInfoSystem;
using TOR_Core.Items;
using TOR_Core.Utilities;
using static HarmonyLib.Code;

namespace TheOldRealms_CNs.Patches
{
    [HarmonyPatch]
    internal class TORCharacterCreationContentPatch
    {
        [HarmonyTranspiler]
        [HarmonyPatch(typeof(TORCharacterCreationContent), MethodType.Constructor)]
        public static IEnumerable<CodeInstruction> Transpiler1(IEnumerable<CodeInstruction> instructions /*, ILGenerator generator*/)
        {
            var get_TORCoreModuleExtendedDataPath = AccessTools.Method(typeof(TORPaths), "get_TORCoreModuleExtendedDataPath");

            var found = false;
            foreach (var instruction in instructions)
            {
                yield return instruction;
                if (instruction.opcode == OpCodes.Call && instruction.operand == (object)get_TORCoreModuleExtendedDataPath)
                {
                    yield return new CodeInstruction(OpCodes.Ldsfld, AccessTools.Field(typeof(SubModule),nameof(SubModule.ModuleName)));
                    yield return new CodeInstruction(OpCodes.Call, AccessTools.Method(typeof(ModuleHelper), nameof(ModuleHelper.GetModuleFullPath)));
                    yield return new CodeInstruction(OpCodes.Ldstr, "ModuleData/tor_custom_xmls/");
                    yield return new CodeInstruction(OpCodes.Call, AccessTools.Method(typeof(String), nameof(String.Concat), new Type[] { typeof(string), typeof(string) }));

                    found = true;
                }
            }
            if (found is false)
                throw new ArgumentException("Cannot find TOR_Core.Utilities.TORPaths::get_TORCoreModuleExtendedDataPath() in TORCharacterCreationContent.ctor");
        }

        [HarmonyTranspiler]
        [HarmonyPatch(typeof(TORCharacterCreationContent), "SetMenuLabelTexts")]
        public static IEnumerable<CodeInstruction> Transpiler2(IEnumerable<CodeInstruction> instructions /*, ILGenerator generator*/)
        {
            var found = false;
            foreach (var instruction in instructions)
            {

                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "Choose your family's background...":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=4uKx1zWN}Choose your family's background...");
                            found = true;
                            break;
                        case "Teenage years...":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=mMVMwNgp}Teenage years...");
                            found = true;
                            break;
                        case "Your starting profession...":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=544R7nA7}Your starting profession...");
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
                throw new ArgumentException("Cannot find ldstr Choose your family's background... in TORCharacterCreationContent.SetMenuLabelTexts");
        }

        [HarmonyTranspiler]
        [HarmonyPatch(typeof(TORCharacterCreationContent), "PromptChooseLore")]
        public static IEnumerable<CodeInstruction> TranspilerPromptChooseLore(IEnumerable<CodeInstruction> instructions /*, ILGenerator generator*/)
        {
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "Choose Lore":
                            var codeInstruction = new CodeInstruction(OpCodes.Ldstr, "{=dNakXeqI}Choose Lore");
                            codeInstruction.labels.AddRange(instruction.labels);
                            yield return codeInstruction;
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Choose a lore to specialize in.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=3Ol7cDT7}Choose a lore to specialize in.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Confirm":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=v8KWNkEo}Confirm");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Cancel":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=i2o7tfXd}Cancel");
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
                throw new ArgumentException("Cannot find ldstr Choose Lore in TORCharacterCreationContent.PromptChooseLore");
        }

        [HarmonyTranspiler]
        [HarmonyPatch(typeof(TORCharacterCreationContent), "OnChooseLore")]
        public static IEnumerable<CodeInstruction> TranspilerOnChooseLore(IEnumerable<CodeInstruction> instructions /*, ILGenerator generator*/)
        {
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "Successfully learned lore: ":
                            var codeInstruction = new CodeInstruction(OpCodes.Ldstr, "{=EyVZ8Quk}Successfully learned lore: ");
                            codeInstruction.labels.AddRange(instruction.labels);
                            yield return codeInstruction;
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
                throw new ArgumentException("Cannot find ldstr 'Successfully learned lore: ' in TORCharacterCreationContent.OnChooseLore");
        }

        [HarmonyTranspiler]
        [HarmonyPatch(typeof(TORCharacterCreationContent), "PromptChooseBloodline")]
        public static IEnumerable<CodeInstruction> TranspilerPromptChooseBloodline(IEnumerable<CodeInstruction> instructions /*, ILGenerator generator*/)
        {
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "Von Carstein Vampire":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=yOG7EvBM}Von Carstein Vampire");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Blood Knight":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=OgVhLRE7}Blood Knight");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Necrarch":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=ehuB1miD}Necrarch");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Choose Bloodline":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=Z7DQS7uV}Choose Bloodline");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Choose your vampiric bloodline.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=hTg0dIbs}Choose your vampiric bloodline.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Confirm":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=v8KWNkEo}Confirm");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Cancel":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=i2o7tfXd}Cancel");
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
                throw new ArgumentException("Cannot find ldstr 'Choose Bloodline' in TORCharacterCreationContent.PromptChooseBloodline");
        }

        [HarmonyTranspiler]
        [HarmonyPatch(typeof(TORCharacterCreationContent), "OnChooseBloodline")]
        public static IEnumerable<CodeInstruction> TranspilerOnChooseBloodline(IEnumerable<CodeInstruction> instructions /*, ILGenerator generator*/)
        {
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr && instruction.operand.ToString() == "Successfully learned Necromancy")
                {
                    yield return new CodeInstruction(OpCodes.Ldstr, "{=ycim1VPY}Successfully learned Necromancy");
                    found = true;
                }
                else
                {
                    yield return instruction;
                }
            }
            if (found is false)
                throw new ArgumentException("Cannot find ldstr 'Successfully learned Necromancy' in TORCharacterCreationContent.OnChooseBloodline");
        }

        [HarmonyTranspiler]
        [HarmonyPatch(typeof(TORCharacterCreationContent), "PromptChoosePriesthood")]
        public static IEnumerable<CodeInstruction> TranspilerPromptChoosePriesthood(IEnumerable<CodeInstruction> instructions /*, ILGenerator generator*/)
        {
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "Sigmar":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=tor_religion_name_of_god_cult_of_sigmar_str}Sigmar");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Ulric":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=tor_religion_name_of_god_cult_of_ulric_str}Ulric");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Choose God":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=WS6HYv7K}Choose God");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "You are a priest of the Empire. Choose the God you are devoted to.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=YFWWrQKQ}You are a priest of the Empire. Choose the God you are devoted to.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Confirm":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=v8KWNkEo}Confirm");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Cancel":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=i2o7tfXd}Cancel");
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
                throw new ArgumentException("Cannot find ldstr 'Choose God' in TORCharacterCreationContent.PromptChoosePriesthood");
        }

        [HarmonyTranspiler]
        [HarmonyPatch(typeof(TORCharacterCreationContent), "OnCancel")]
        public static IEnumerable<CodeInstruction> Transpiler4(IEnumerable<CodeInstruction> instructions /*, ILGenerator generator*/)
        {
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr && instruction.operand.ToString() == "You MUST choose.")
                {
                    yield return new CodeInstruction(OpCodes.Ldstr, "{=ZsYsnFJy}You MUST choose.");
                    found = true;
                }
                else
                {
                    yield return instruction;
                }
            }
            if (found is false)
                throw new ArgumentException("Cannot find ldstr 'You MUST choose.' in TORCharacterCreationContent.OnCancel");
        }
    }
}