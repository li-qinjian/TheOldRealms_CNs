using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using TaleWorlds.Localization;
using TOR_Core.CharacterDevelopment;

namespace TheOldRealms_CNs.Patches
{
    [HarmonyPatch]
    internal class TORCareerChoiceGroupsPatch
    {
        [HarmonyTranspiler]
        [HarmonyPatch(typeof(TORCareerChoiceGroups), "InitializeAll")]
        public static IEnumerable<CodeInstruction> Transpiler2(IEnumerable<CodeInstruction> instructions /*, ILGenerator generator*/)
        {
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "{=arch_lector_choice_group_str}Twin Tailed Comet":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=fhcgIAwh}Twin Tailed Comet");
                            break;
                        case "{=book_of_sigmar_choice_group_str}Tools of Judgement":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=sUatXxGA}Tools of Judgement");
                            break;
                        case "{=sigmar_proclaimer_choice_group_str}Hunt the Wicked":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=PfH20FyX}Hunt the Wicked");
                            break;
                        case "{=relentless_fanatic_choice_group_str}The Silver Hammer":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=NpqXdInx}The Silver Hammer");
                            break;
                        case "{=arch_lector_choice_group_str}No Rest Against Evil":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=HuTHSJWN}No Rest Against Evil");
                            break;
                        case "{=protector_of_the_weak_choice_group_str}Ends Justifies Means":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=Xt6rZKHB}Ends Justifies Means");
                            break;
                        case "{=holy_purge_choice_group_str}Swift Procedure":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=p3NHcgLU}Swift Procedure");
                            break;
                        case "{=arch_lector_choice_group_str}Guilty by Association":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=Af99k5JN}Guilty by Association");
                            break;
                        case "{=arch_lector_choice_group_str}Liber Necris":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=xIZDzANG}Liber Necris");
                            break;
                        case "{=arch_lector_choice_group_str}De Arcanis Kardon":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=3MPCDBng}De Arcanis Kardon");
                            break;
                        case "{=arch_lector_choice_group_str}Codex Mortifica":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=pOkLhNXI}Codex Mortifica");
                            break;
                        case "{=arch_lector_choice_group_str}Liber Mortis":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=FY95NG1M}Liber Mortis");
                            break;
                        case "{=arch_lector_choice_group_str}Book of W'soran":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=Y0rPsPKn}Book of W'soran");
                            break;
                        case "{=arch_lector_choice_group_str}Grimore Necris":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=smAVGbQI}Grimore Necris");
                            break;
                        case "{=arch_lector_choice_group_str}Books of Nagash":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=ykSQjSDV}Books of Nagash");
                            break;
                        case "{=new_blood_choice_group_str}The Feral":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=tg2OIm2x}The Feral");
                            break;
                        case "{=knightly_choice_group_str}The Paymaster":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=40T3amv6}The Paymaster");
                            break;
                        case "Disciple of the Accursed":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=HZUgJviq}Disciple of the Accursed");
                            break;
                        case "Witch Sight":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=yXxggLEd}Witch Sight");
                            break;
                        case "{=relentless_fanatic_choice_group_str}Dark Visions":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=J09Zf2jc}Dark Visions");
                            break;
                        case "{=protector_of_the_weak_choice_group_str}Unhallowed Soul":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=W0HGgW5N}Unhallowed Soul");
                            break;
                        case "{=holy_purge_choice_group_str}Hunger for Knowledge":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=TOsS20gh}Hunger for Knowledge");
                            break;
                        case "{=arch_lector_choice_group_str}Wellspring of Dhar":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=DaIGgQ3N}Wellspring of Dhar");
                            break;
                        case "{=arch_lector_choice_group_str}The Everlings Secret":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=7BRUglR5}The Everlings Secret");
                            break;
                        case "Crusher of the Weak":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=cHlDk18L}Crusher of the Weak");
                            break;
                        case "Wild Pack":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=9uJDWNAE}Wild Pack");
                            break;
                        case "Teachings of the Winterfather":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=a1uqIXgv}Teachings of the Winterfather");
                            break;
                        case "Frost’s Bite":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=L3FZXvAx}Frost’s Bite");
                            break;
                        case "Runes of the White Wolf":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=FcB2iAS4}Runes of the White Wolf");
                            break;
                        case "Fury of War":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=DBqr6HX1}Fury of War");
                            break;
                        case "Flame of Ulric":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=cpx4ArGY}Flame of Ulric");
                            break;
                        case "Study and Practise":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=3rsNDlV6}Study and Practise");
                            break;
                        case "Teclis' Teachings":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=1rX19sK4}Teclis' Teachings");
                            break;
                        case "Imperial Enchantment":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=TjPrEoHH}Imperial Enchantment");
                            break;
                        case "College Orders":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=7IVXBA7l}College Orders");
                            break;
                        case "Magic Combat Training":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=jjXQOhCI}Magic Combat Training");
                            break;
                        case "Ancient Scrolls":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=MVebklla}Ancient Scrolls");
                            break;
                        case "Arcane Knowledge":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=cstTzWgv}Arcane Knowledge");
                            break;
                        case "Protector of the Woods":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=4u7SHppR}Protector of the Woods");
                            break;
                        case "Pathfinder":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=4mrG0X0J}Pathfinder");
                            break;
                        case "Forest Stalker":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=y1GEu6cY}Forest Stalker");
                            break;
                        case "Hail of Arrows":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=B8IeCuxF}Hail of Arrows");
                            break;
                        case "Hawkeyed":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=O020X8Bz}Hawkeyed");
                            break;
                        case "Starfire Essence":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=RzqJRY5z}Starfire Essence");
                            break;
                        case "Eye of the Hunter":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=84fDtdeO}Eye of the Hunter");
                            break;
                        case "Path Shaping":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=aq8wlRVg}Path Shaping");
                            break;
                        case "Tree singing":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=I40SsXVy}Tree singing");
                            break;
                        case "Vital Surge":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=RkEcyM3q}Vital Surge");
                            break;
                        case "Heart of the Tree":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=jEgdNttI}Heart of the Tree");
                            break;
                        case "Ariel's Blessing":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=2FOE3Bm9}Ariel's Blessing");
                            break;
                        case "Fey Magic":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=d0ho2E9m}Fey Magic");
                            break;
                        case "Fury of the Forest":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=5vGWj3oO}Fury of the Forest");
                            break;
                        case "Caelith's Wisdom":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=pqhWCwVO}Caelith's Wisdom");
                            break;
                        case "Soul Binding":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=cqfqXikN}Soul Binding");
                            break;
                        case "Legends of Malok":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=6zULnlbm}Legends of Malok");
                            break;
                        case "Unrestricted Magic":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=KsQZLrNp}Unrestricted Magic");
                            break;
                        case "Forbidden Scrolls of Saphery":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=e8skG94h}Forbidden Scrolls of Saphery");
                            break;
                        case "By All Means":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=L6F2ozqe}By All Means");
                            break;
                        case "Secret of the Fellfang":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=9QxC3yzL}Secret of the Fellfang");
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
            //if (found is false)
            //    throw new ArgumentException("Cannot find ldstr {=arch_lector_choice_group_str}Twin Tailed Comet in TORCareerChoiceGroups.InitializeAll");
        }
    }
}
