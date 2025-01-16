using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using TaleWorlds.Localization;
using TOR_Core.CampaignSupport.TownBehaviours;
using TOR_Core.CharacterDevelopment.CareerSystem.CareerButton;

namespace TheOldRealms_CNs.Patches
{
    [HarmonyPatch]
    internal class MasterEngineerTownBehaviourPatch
    {
        [HarmonyTranspiler]
        [HarmonyPatch(typeof(MasterEngineerTownBehaviour), "AddEngineerDialogLines")]
        public static IEnumerable<CodeInstruction> AddEngineerDialogLinesTranspiler(IEnumerable<CodeInstruction> instructions /*, ILGenerator generator*/)
        {
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "Your selection leaves something to be desired. Where is your good stuff?":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=mEs5PkPu}Your selection leaves something to be desired. Where is your good stuff?");
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
                throw new ArgumentException("Cannot find ldstr in MasterEngineerTownBehaviour.AddEngineerDialogLines");
        }

        [HarmonyTranspiler]
        [HarmonyPatch(typeof(MasterEngineerTownBehaviour), "UpgradeGunShopDialog")]
        public static IEnumerable<CodeInstruction> UpgradeGunShopDialogTranspiler(IEnumerable<CodeInstruction> instructions /*, ILGenerator generator*/)
        {
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case " Not only did Goswin steal valuable parts, but also blueprints. Some of our finest creations were destroyed in his rampage":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=KpD3cNo7} Not only did Goswin steal valuable parts, but also blueprints. Some of our finest creations were destroyed in his rampage");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "There are copies of the plans, and those parts can be recreated, from other engineer schools through out the empire. But for this I have neither the authority nor the contacts to get them over quickly.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=y5mV1fH5}There are copies of the plans, and those parts can be recreated, from other engineer schools through out the empire. But for this I have neither the authority nor the contacts to get them over quickly.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "For 500{PRESTIGE_ICON} I can finally stock up our buckshot supplies and continue creating blunderbusses and can get some of those Hochland' Long rifles.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=Wo87f4cM}For 500{PRESTIGE_ICON} I can finally stock up our buckshot supplies and continue creating blunderbusses and can get some of those Hochland' Long rifles.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "For another 500{PRESTIGE_ICON} I can buy parts of which I can create more advanced and pistols rifles. Meinkopt would be proud of me.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=wmdAiiRI}For another 500{PRESTIGE_ICON} I can buy parts of which I can create more advanced and pistols rifles. Meinkopt would be proud of me.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "For a final 500{PRESTIGE_ICON} I can finally stock up our gunpowder laboratory, which gives me the oppurtunity to craft grenades and cannons.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=eFRx48wZ}For a final 500{PRESTIGE_ICON} I can finally stock up our gunpowder laboratory, which gives me the oppurtunity to craft grenades and cannons.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "I hope it is worth it. I will support you on this(Spend 500{PRESTIGE_ICON})":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=WvLdsUP8}I hope it is worth it. I will support you on this(Spend 500{PRESTIGE_ICON})");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "I can't effort me such venture.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=31KJW5U2}I can't effort me such venture.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "May these guns help you to succeed in combat. Just don't shoot yourself in the foot with them.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=gbarOO7a}May these guns help you to succeed in combat. Just don't shoot yourself in the foot with them.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "It is said, Meinkopt checked the clicking sound of every Repeater gun he made.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=yc9qGkji}It is said, Meinkopt checked the clicking sound of every Repeater gun he made.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "I love the smell of burned black Powder in the morning.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=8DR5Z6ZF}I love the smell of burned black Powder in the morning.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "What a shame, is there anything else what I can do?":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=O7D1dMQP}What a shame, is there anything else what I can do?");
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
                throw new ArgumentException("Cannot find ldstr in MasterEngineerTownBehaviour.UpgradeGunShopDialog");
        }
    }
}
