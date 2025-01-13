using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using TaleWorlds.Localization;
using TOR_Core.CampaignMechanics.SpellTrainers;
using TOR_Core.CharacterDevelopment.CareerSystem.Choices;

namespace TheOldRealms_CNs.Patches
{
    [HarmonyPatch]
    internal class SpellTrainerInTownBehaviorPatch
    {
        [HarmonyTranspiler]
        [HarmonyPatch(typeof(SpellTrainerInTownBehavior), "SpellsingerDialogs")]
        public static IEnumerable<CodeInstruction> SpellsingerDialogsTranspiler(IEnumerable<CodeInstruction> instructions, ILGenerator generator)
        {
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "{=tor_spelltrainer_prophetesse_start_str}I welcome you child of Athel Loren.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=mgYNghwE}I welcome you child of Athel Loren.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "{=tor_spelltrainer_prophetesse_choices_str}Is there more you seek? Speak your desires.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=xwYXq1IT}Is there more you seek? Speak your desires.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "{=tor_spelltrainer_prophetesse_open_book_str}I seek further knowledge of Athel Loren's Magic.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=WDHctJKc}I seek further knowledge of Athel Loren's Magic.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "{=tor_spelltrainer_prophetesse_open_book_str}I want to become a spellweaver.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=3xtv3Q1g}I want to become a spellweaver.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "{=tor_spelltrainer_prophetesse_open_book_str}Teach me one of Ariels many pathways.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=XFekXOjF}Teach me one of Ariels many pathways.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "{=tor_spelltrainer_prophetesse_goodbye_str}A spellsinger, can pick either the pathway of the Darkweaver or the one of the Highweaver. Choose wisely":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=WUFOXnb5}A spellsinger, can pick either the pathway of the Darkweaver or the one of the Highweaver. Choose wisely");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "{=tor_spelltrainer_prophetesse_open_book_str}Let me choose.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=s90pKC0r}Let me choose.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "{=tor_spelltrainer_prophetesse_goodbye_str}You can learn additional aspects of the magic of the forest. Choose wisely (not more than 2 additional lores, 6 in total)":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=7RKg4vLq}You can learn additional aspects of the magic of the forest. Choose wisely (not more than 2 additional lores, 6 in total)");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "{=tor_spelltrainer_prophetesse_goodbye_str}May Ariel guide you on all your paths through her garden.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=awk9gy9J}May Ariel guide you on all your paths through her garden.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "{=tor_spelltrainer_prophetesse_damselsecond_lore_str} I feel that {SPELLSINGERNAME} has reached  a new level of magical potential, it is time for a new Spellweaver":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=0ShfMDuI} I feel that {SPELLSINGERNAME} has reached  a new level of magical potential, it is time for a new Spellweaver");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "{=tor_spelltrainer_prophetesse_player_goodbye_str}Ariel with you. ":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=6wuFOPb2}Ariel with you. ");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "{=tor_spelltrainer_prophetesse_close_book_str}A new Facette of Ariels infinte knowledge.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=vbBxjFB4}A new Facette of Ariels infinte knowledge.");
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
                throw new ArgumentException("Cannot find ldstr '{=tor_spelltrainer_prophetesse_start_str}I welcome you child of Athel Loren.' in SpellTrainerInTownBehavior.SpellsingerDialogs");
        }

        [HarmonyTranspiler]
        [HarmonyPatch(typeof(SpellTrainerInTownBehavior), "AddDialogs")]
        public static IEnumerable<CodeInstruction> AddDialogsTranspiler(IEnumerable<CodeInstruction> instructions, ILGenerator generator)
        {
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "Take my gift. Now give me what I demand! (Pay 2000{DARKENERGYICON})":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=OVW6hZq9}Take my gift. Now give me what I demand! (Pay 2000{DARKENERGYICON})");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "I can't provide you this gift":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=vU7Ad7SB}I can't provide you this gift");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "A shame. What else can I help you with?":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=vhasfDRX}A shame. What else can I help you with?");
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
                throw new ArgumentException("Cannot find ldstr '{=tor_spelltrainer_prophetesse_start_str}I welcome you child of Athel Loren.' in SpellTrainerInTownBehavior.AddDialogs");
        }

        [HarmonyTranspiler]
        [HarmonyPatch(typeof(SpellTrainerInTownBehavior), "magictestcondition")]
        public static IEnumerable<CodeInstruction> magictestconditionTranspiler(IEnumerable<CodeInstruction> instructions, ILGenerator generator)
        {
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "You shouldn't see this.":
                            var codeInstruction = new CodeInstruction(OpCodes.Ldstr, "{=oojYjSUH}You shouldn't see this.");
                            codeInstruction.labels.AddRange(instruction.labels);
                            yield return codeInstruction;
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
                throw new ArgumentException("Cannot find ldstr '{=tor_spelltrainer_prophetesse_start_str}I welcome you child of Athel Loren.' in SpellTrainerInTownBehavior.magictestcondition");
        }

        [HarmonyTranspiler]
        [HarmonyPatch(typeof(SpellTrainerInTownBehavior), "filltextfortestprompt")]
        public static IEnumerable<CodeInstruction> filltextfortestpromptTranspiler(IEnumerable<CodeInstruction> instructions, ILGenerator generator)
        {
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "You shouldn't see this.":
                            var codeInstruction = new CodeInstruction(OpCodes.Ldstr, "{=oojYjSUH}You shouldn't see this.");
                            codeInstruction.labels.AddRange(instruction.labels);
                            yield return codeInstruction;
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
                throw new ArgumentException("Cannot find ldstr '{=tor_spelltrainer_prophetesse_start_str}I welcome you child of Athel Loren.' in SpellTrainerInTownBehavior.filltextfortestprompt");
        }

        [HarmonyTranspiler]
        [HarmonyPatch(typeof(SpellTrainerInTownBehavior), "chooseloreconsequence")]
        public static IEnumerable<CodeInstruction> chooseloreconsequenceTranspiler(IEnumerable<CodeInstruction> instructions, ILGenerator generator)
        {
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
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
                throw new ArgumentException("Cannot find ldstr 'Confirm' in SpellTrainerInTownBehavior.chooseloreconsequence");
        }
    }
}
