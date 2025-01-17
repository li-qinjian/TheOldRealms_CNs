using HarmonyLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection.Emit;
using System.Text;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.GameMenus;
using TaleWorlds.CampaignSystem.Overlay;
using TaleWorlds.Localization;
using TOR_Core.AbilitySystem.Spells;
using TOR_Core.CampaignMechanics.TORCustomSettlement.CustomSettlementMenus;
using TOR_Core.Extensions;

namespace TheOldRealms_CNs.Patches
{
    [HarmonyPatch]
    internal class OakOfAgesMenuLogicPatch
    {
        [HarmonyTranspiler]
        [HarmonyPatch(typeof(OakOfAgesMenuLogic), "AddOakOfAgeMenus")]
        public static IEnumerable<CodeInstruction> AddOakOfAgeMenusTranspiler(IEnumerable<CodeInstruction> instructions /*, ILGenerator generator*/)
        {
            var found = false;
            var listInstructions = new List<CodeInstruction>(instructions);
            foreach (var instruction in listInstructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "Tree Spirits":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=cPstkNrN}Tree Spirits");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Branches of the Oak":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=ckBNGOjq}Branches of the Oak");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "World roots of the Oak":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=GQJB31LK}World roots of the Oak");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Tree Symbols":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=lA34QIEz}Tree Symbols");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "{tor_custom_settlement_menu_leave_str}Leave...":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=13Vft5qv}Leave...");
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
                throw new ArgumentException("Cannot find ldstr 'Tree Spirits' in OakOfAgesMenuLogic.AddOakOfAgeMenus");
        }

        [HarmonyTranspiler]
        [HarmonyPatch(typeof(OakOfAgesMenuLogic), "AddTreeSpiritMenu")]
        public static IEnumerable<CodeInstruction> AddTreeSpiritMenuTranspiler(IEnumerable<CodeInstruction> instructions /*, ILGenerator generator*/)
        {
            var found = false;
            var listInstructions = new List<CodeInstruction>(instructions);
            foreach (var instruction in listInstructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "Communicate with the Tree spirits around the oak.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=7AGZ7Dev}Communicate with the Tree spirits around the oak.");
                            found = true;
                            break;
                        case "{tor_custom_settlement_menu_cursed_site_ghost_str}Commune with the forest. 100 {FORESTHARMONY}":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=OUs6CtXt}Commune with the forest. 100 {FORESTHARMONY}");
                            found = true;
                            break;
                        case "Rouse Treemen. 800 {FORESTHARMONY}":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=X21so5LJ}Rouse Treemen. 800 {FORESTHARMONY}");
                            found = true;
                            break;
                        case "Relief Treespirits":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=X345baXa}Relief Treespirits");
                            found = true;
                            break;
                        case "Donated Spirits":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=nAO6h0nv}Donated Spirits");
                            found = true;
                            break;
                        case "Leave...":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=13Vft5qv}Leave...");
                            found = true;
                            break;
                        case "You were able to bind {NUMBEROFTROOPS} dryads to your party":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=7Ajo9kvu}You were able to bind {NUMBEROFTROOPS} dryads to your party");
                            found = true;
                            break;
                        case "back...":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=2Pn37PsW}back...");
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
                throw new ArgumentException("Cannot find ldstr 'Tree Spirits' in OakOfAgesMenuLogic.AddTreeSpiritMenu");
        }

        /// <summary>
        /// 不知道为什么这个注入会报错，奇怪
        /// </summary>
        /// <param name = "instructions" ></ param >
        /// < returns ></ returns >
        /// < exception cref="ArgumentException"></exception>
        //[HarmonyTranspiler]
        //[HarmonyPatch(typeof(OakOfAgesMenuLogic), "AddTreeSymbolMenu")]
        //public static IEnumerable<CodeInstruction> AddTreeSymbolMenuTranspiler(IEnumerable<CodeInstruction> instructions /*, ILGenerator generator*/)
        //{
        //    var found = false;
        //    foreach (var instruction in instructions)
        //    {
        //        if (instruction.opcode == OpCodes.Ldstr)
        //        {
        //            var stringOperand = instruction.operand.ToString();
        //            switch (stringOperand)
        //            {
        //                case "Tree Symbols: Choose one Symbol activated for your party. The Symbols provide strong enhancements, yet they will also provide strong disadvantages. Choose wisely, only one Symbol can be active at once.":
        //                    var codeInstruction1 = new CodeInstruction(OpCodes.Ldstr, "{=KinyMyGK}Tree Symbols: Choose one Symbol activated for your party. The Symbols provide strong enhancements, yet they will also provide strong disadvantages. Choose wisely, only one Symbol can be active at once.");
        //                    codeInstruction1.labels.AddRange(instruction.labels);
        //                    codeInstruction1.blocks.AddRange(instruction.blocks);
        //                    yield return codeInstruction1;
        //                    //yield return new CodeInstruction(OpCodes.Ldnull);
        //                    //yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
        //                    //yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
        //                    found = true;
        //                    break;
        //                //case "Remove symbol":
        //                //    var codeInstruction2 = new CodeInstruction(OpCodes.Ldstr, "{=DERcfqv4}Remove symbol");
        //                //    codeInstruction2.labels.AddRange(instruction.labels);
        //                //    codeInstruction2.blocks.AddRange(instruction.blocks);
        //                //    yield return codeInstruction2;
        //                //    yield return new CodeInstruction(OpCodes.Ldnull);
        //                //    yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
        //                //    yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
        //                //    found = true;
        //                //    break;
        //                //case "Magical chalk. {TREESYMBOLFREEUPGRADE}{FORESTHARMONY}":
        //                //    var codeInstruction3 = new CodeInstruction(OpCodes.Ldstr, "{=Hvg8XhRh}Magical chalk. {TREESYMBOLFREEUPGRADE}{FORESTHARMONY}");
        //                //    codeInstruction3.labels.AddRange(instruction.labels);
        //                //    codeInstruction3.blocks.AddRange(instruction.blocks);
        //                //    yield return codeInstruction3;
        //                //    yield return new CodeInstruction(OpCodes.Ldnull);
        //                //    yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
        //                //    yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
        //                //    found = true;
        //                //    break;
        //                //case "Leave...":
        //                //    var codeInstruction4 = new CodeInstruction(OpCodes.Ldstr, "{=13Vft5qv}Leave...");
        //                //    codeInstruction4.labels.AddRange(instruction.labels);
        //                //    codeInstruction4.blocks.AddRange(instruction.blocks);
        //                //    yield return codeInstruction4;
        //                //    yield return new CodeInstruction(OpCodes.Ldnull);
        //                //    yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
        //                //    yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
        //                //    found = true;
        //                //    break;
        //                default:
        //                    yield return instruction;
        //                    break;
        //            }
        //        }
        //        else
        //        {
        //            yield return instruction;
        //        }
        //    }
        //    if (found is false)
        //        throw new ArgumentException("Cannot find ldstr in OakOfAgesMenuLogic.AddTreeSymbolMenu");
        //}


        [HarmonyPrefix]
        [HarmonyPatch(typeof(OakOfAgesMenuLogic), "DefaultUnlockOakUpgradeCondition")]
        public static bool PrefixAddTreeSymbolMenu(MenuCallbackArgs args, string upgrade, int cost, TextObject toolTipDescription = null, int minimumLevel = 0)
        {
            if (toolTipDescription.Value == "Remove Symbol change costs.{newline}{UPGRADEFAILEDREASON}")
            {
                toolTipDescription.Value = "{=28wGfKjr}Remove Symbol change costs.{newline}{UPGRADEFAILEDREASON}";
            }

            return true;
        }

        [HarmonyTranspiler]
        [HarmonyPatch(typeof(OakOfAgesMenuLogic), "DefaultUnlockOakUpgradeCondition")]
        public static IEnumerable<CodeInstruction> DefaultUnlockOakUpgradeConditionTranspiler(IEnumerable<CodeInstruction> instructions /*, ILGenerator generator*/)
        {
            var found = false;
            var listInstructions = new List<CodeInstruction>(instructions);
            foreach (var instruction in listInstructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "Requires level ":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=WrMi9r0z}Requires level ");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "{newline}Requires level":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=xubAsrWo{newline}Requires level");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "{newline}Not enough harmony":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=uCadPfat}{newline}Not enough harmony");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "{newline}Upgrade has been already unlocked":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=jtwNMbmj}{newline}Upgrade has been already unlocked");
                            found = true;
                            break;
                        case "{newline}No further upgrades available":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=PJnIwefY}{newline}No further upgrades available");
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
                throw new ArgumentException("Cannot find ldstr in OakOfAgesMenuLogic.DefaultUnlockOakUpgradeConditionTranspiler");
        }

        [HarmonyTranspiler]
        [HarmonyPatch(typeof(OakOfAgesMenuLogic), "UnlockTreeSymbolCondition")]
        public static IEnumerable<CodeInstruction> UnlockTreeSymbolConditionTranspiler(IEnumerable<CodeInstruction> instructions /*, ILGenerator generator*/)
        {
            var found = false;
            var listInstructions = new List<CodeInstruction>(instructions);
            foreach (var instruction in listInstructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "{newline}Not enough Harmony.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=uCadPfat}{newline}Not enough Harmony.");
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
                throw new ArgumentException("Cannot find ldstr in OakOfAgesMenuLogic.UnlockTreeSymbolCondition");
        }

        [HarmonyTranspiler]
        [HarmonyPatch(typeof(OakOfAgesMenuLogic), "SelectTreeSymbolCondition")]
        public static IEnumerable<CodeInstruction> SelectTreeSymbolConditionTranspiler(IEnumerable<CodeInstruction> instructions /*, ILGenerator generator*/)
        {
            var found = false;
            var listInstructions = new List<CodeInstruction>(instructions);
            foreach (var instruction in listInstructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "{newline}Not enough Harmony.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=uCadPfat}{newline}Not enough Harmony.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "{newline}Treesymbol is currently activ":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=u7B4HWqV}{newline}Treesymbol is currently activ");
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
                throw new ArgumentException("Cannot find ldstr in OakOfAgesMenuLogic.SelectTreeSymbolCondition");
        }

        [HarmonyTranspiler]
        [HarmonyPatch(typeof(OakOfAgesMenuLogic), "AddWorldRootMenu")]
        public static IEnumerable<CodeInstruction> AddWorldRootMenuTranspiler(IEnumerable<CodeInstruction> instructions /*, ILGenerator generator*/)
        {
            var found = false;
            var listInstructions = new List<CodeInstruction>(instructions);
            foreach (var instruction in listInstructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "World Roots : The world roots create a braid of pathways with the oaks Roots. With them the Asrai are allowed to travel world. Help to restablish the roots and travel to roots ends in the old World":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=5wDfyHZL}World Roots : The world roots create a braid of pathways with the oaks Roots. With them the Asrai are allowed to travel world. Help to restablish the roots and travel to roots ends in the old World");
                            found = true;
                            break;
                        case "Unlock Pathway to the Forest of Arden. {ROOTUNLOCKCOST}{FORESTHARMONY}":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=YVAyDFto}Unlock Pathway to the Forest of Arden. {ROOTUNLOCKCOST}{FORESTHARMONY}");
                            found = true;
                            break;
                        case "Travel to the forest of Arden. {WORLDROOTTRAVELCOST}{FORESTHARMONY}":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=0YaQIMX8}Travel to the forest of Arden. {WORLDROOTTRAVELCOST}{FORESTHARMONY}");
                            found = true;
                            break;
                        case "Unlock the pathway to Laurelorn. {ROOTUNLOCKCOST}{FORESTHARMONY}":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=TBzCGmtx}Unlock the pathway to Laurelorn. {ROOTUNLOCKCOST}{FORESTHARMONY}");
                            found = true;
                            break;
                        case "Travel to Laurelorn. {WORLDROOTTRAVELCOST}{FORESTHARMONY}":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=ALVOQpPa}Travel to Laurelorn. {WORLDROOTTRAVELCOST}{FORESTHARMONY}");
                            found = true;
                            break;
                        case "Unlock the pathway to the Gryphenwood. {ROOTUNLOCKCOST}{FORESTHARMONY}":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=psIX4EaF}Unlock the pathway to the Gryphenwood. {ROOTUNLOCKCOST}{FORESTHARMONY}");
                            found = true;
                            break;
                        case "Travel to the Gryphenwood. {WORLDROOTTRAVELCOST}{FORESTHARMONY}":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=2RJWbPLl}Travel to the Gryphenwood. {WORLDROOTTRAVELCOST}{FORESTHARMONY}");
                            found = true;
                            break;
                        case "Internalize the root pathways. {ROOTTRAVELUPGRADE}{FORESTHARMONY}":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=CScWjVsn}Internalize the root pathways. {ROOTTRAVELUPGRADE}{FORESTHARMONY}");
                            found = true;
                            break;
                        case "Establish pathways back to the Oak of Ages. {ROOTRETURNUPGRADE}{FORESTHARMONY}":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=qdG2Z0ui}Establish pathways back to the Oak of Ages. {ROOTRETURNUPGRADE}{FORESTHARMONY}");
                            found = true;
                            break;
                        case "Healing Aura of roots. {ROOTHEALUPGRADE}{FORESTHARMONY}":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=PhqPSaSF}Healing Aura of roots. {ROOTHEALUPGRADE}{FORESTHARMONY}");
                            found = true;
                            break;
                        case "Leave...":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=13Vft5qv}Leave...");
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
                throw new ArgumentException("Cannot find ldstr in OakOfAgesMenuLogic.AddWorldRootMenu");
        }

        [HarmonyTranspiler]
        [HarmonyPatch(typeof(OakOfAgesMenuLogic), "AddWorldRootsMenus")]
        public static IEnumerable<CodeInstruction> AddWorldRootsMenusTranspiler(IEnumerable<CodeInstruction> instructions /*, ILGenerator generator*/)
        {
            var found = false;
            var listInstructions = new List<CodeInstruction>(instructions);
            foreach (var instruction in listInstructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "{tor_custom_settlement_menu_leave_str}Travel to Maisontaal":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=YNbIGaAL}Travel to Maisontaal");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "{tor_custom_settlement_menu_leave_str}Travel to Laurelorn":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=natOhOp2}Travel to Laurelorn");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "{tor_custom_settlement_menu_leave_str}Travel back to Athel Loren...":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=4Ud9yoOm}Travel back to Athel Loren...");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Establish pathways back to the Oak of Ages. {ROOTRETURNUPGRADE}{FORESTHARMONY}":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=zObjtTxB}Establish pathways back to the Oak of Ages. {ROOTRETURNUPGRADE}{FORESTHARMONY}");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "{tor_custom_settlement_menu_leave_str}Leave...":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=13Vft5qv}Leave...");
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
                throw new ArgumentException("Cannot find ldstr in OakOfAgesMenuLogic.AddWorldRootsMenus");
        }

        [HarmonyTranspiler]
        [HarmonyPatch(typeof(OakOfAgesMenuLogic), "AddBranchesOfTheOakMenu")]
        public static IEnumerable<CodeInstruction> AddBranchesOfTheOakMenuranspiler(IEnumerable<CodeInstruction> instructions /*, ILGenerator generator*/)
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
                        case "Branches of The Oak":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=yf7MFFAp}Branches of The Oak");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Build Outposts. {PARTYSIZEUPGRADECOST}":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=GRLjfdqm}Build Outposts. {PARTYSIZEUPGRADECOST}");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Strong branches. {HEALTHUPGRADECOST}":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=EaB9NNhq}Strong branches. {HEALTHUPGRADECOST}");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Thriving Leaves. {GAINUPGRADECOST}":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=DFVQqXfB}Thriving Leaves. {GAINUPGRADECOST}");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Leave...":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=13Vft5qv}Leave...");
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
                throw new ArgumentException("Cannot find ldstr in OakOfAgesMenuLogic.AddBranchesOfTheOakMenu");
        }
    }
}
