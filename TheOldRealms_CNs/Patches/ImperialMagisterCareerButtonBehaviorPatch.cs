using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using TaleWorlds.Localization;
using TOR_Core.CharacterDevelopment.CareerSystem.CareerButton;

namespace TheOldRealms_CNs.Patches
{
    [HarmonyPatch]
    internal class ImperialMagisterCareerButtonBehaviorPatch
    {
        [HarmonyTranspiler]
        [HarmonyPatch(typeof(ImperialMagisterCareerButtonBehavior), "GetLesserPowerstones")]
        public static IEnumerable<CodeInstruction> GetLesserPowerstonesTranspiler(IEnumerable<CodeInstruction> instructions /*, ILGenerator generator*/)
        {
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "Lesser Sparkling Fire Ruby":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=Pho9k5TZ}Lesser Sparkling Fire Ruby");
                            found = true;
                            break;
                        case "+15% Fire damage":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=cJtR6Sll}+15% Fire damage");
                            found = true;
                            break;
                        case "Lesser Nourishing Fire Ruby":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=aC7nkyTn}Lesser Nourishing Fire Ruby");
                            found = true;
                            break;
                        case "+50% Fire amplification ":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=cuO2ETEd}+50% Fire amplification ");
                            found = true;
                            break;
                        case "Lesser Heating Fire Ruby":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=ijXHHSOf}Lesser Heating Fire Ruby");
                            found = true;
                            break;
                        case "+20% Frost and Fire resistance":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=E8tQJuLM}+20% Frost and Fire resistance");
                            found = true;
                            break;
                        case "Lesser Protecting Lumen Stone":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=UErvnqRH}Lesser Protecting Lumen Stone");
                            found = true;
                            break;
                        case "+20% physical resistance":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=kCzXhGDL}+20% physical resistance");
                            found = true;
                            break;
                        case "Lesser Timewarp Lumen Stone":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=bxz6libF}Lesser Timewarp Lumen Stone");
                            found = true;
                            break;
                        case "+25% movementSpeed":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=eRF0MJLC}+25% movementSpeed");
                            found = true;
                            break;
                        case "Lesser Gleaming Lumen Stone":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=BTTqfWED}Lesser Gleaming Lumen Stone");
                            found = true;
                            break;
                        case "+15% physical damage amplification":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=bF0Rdqpv}+15% physical damage amplification");
                            found = true;
                            break;
                        case "Lesser Obfuscating Ghost Amber":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=dFRBU1UJ}Lesser Obfuscating Ghost Amber");
                            found = true;
                            break;
                        case "+25% ranged resistance":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=1NQZVgpK}+25% ranged resistance");
                            found = true;
                            break;
                        case "Lesser Protecting Ghost Amber":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=uqHzRoew}Lesser Protecting Ghost Amber");
                            found = true;
                            break;
                        case "+15% physical resistance":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=bT0AvQJa}+15% physical resistance");
                            found = true;
                            break;
                        case "Lesser Seeking Ghost Amber":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=bVEG5vYX}Lesser Seeking Ghost Amber");
                            found = true;
                            break;
                        case "Add 20% ranged damage":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=IwYjp8Fa}Add 20% ranged damage");
                            found = true;
                            break;
                        case "Lesser Dampening Vitaellum":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=bDxZsN8m}Lesser Dampening Vitaellum");
                            found = true;
                            break;
                        case "Add 25% magical and fire resistance":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=yXOxBYv4}Add 25% magical and fire resistance");
                            found = true;
                            break;
                        case "Lesser Protecting Vitaellum":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=uBK0lugc}Lesser Protecting Vitaellum");
                            found = true;
                            break;
                        case "Add 20% physical resistance":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=Duqs50d8}Add 20% physical resistance");
                            found = true;
                            break;
                        case "Lesser Heavy Vitaellum":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=O0WPp1B6}Lesser Heavy Vitaellum");
                            found = true;
                            break;
                        case "Add 35% physical resistance -35% reduced speed":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=HYweuhoM}Add 35% physical resistance -35% reduced speed");
                            found = true;
                            break;
                        case "Lesser Wind Saphire":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=QhSEX0H8}Lesser Wind Saphire");
                            found = true;
                            break;
                        case "+20% physical ranged damage amplification":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=NyDratvJ}+20% physical ranged damage amplification");
                            found = true;
                            break;
                        case "Lesser Conductive Saphire":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=Iz8gD8RG}Lesser Conductive Saphire");
                            found = true;
                            break;
                        case "+20% lightning melee damage":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=T0yiafDa}+20% lightning melee damage");
                            found = true;
                            break;
                        case "Lesser Dissipation  Saphire":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=6xmBVkHZ}Lesser Dissipation  Saphire");
                            found = true;
                            break;
                        case "+25% lightning resistance, + 25% magical resistance":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=Hgeanaf9}+25% lightning resistance, + 25% magical resistance");
                            found = true;
                            break;
                        case "Lesser Hardening Goldstone":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=V77UKXO2}Lesser Hardening Goldstone");
                            found = true;
                            break;
                        case "+15% physical damage":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=l5hr5OJv}+15% physical damage");
                            found = true;
                            break;
                        case "Lesser Sparkling Goldstone":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=h3dcGFNw}Lesser Sparkling Goldstone");
                            found = true;
                            break;
                        case "+20% physical ranged damage":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=NyDratvJ}+20% physical ranged damage");
                            found = true;
                            break;
                        case "Lesser Burdening Goldstone":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=NwR8L5Oj}Lesser Burdening Goldstone");
                            found = true;
                            break;
                        case "+30% physical resistance, 35% reduced speed":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=UErvnqRH}+30% physical resistance, 35% reduced speed");
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
                throw new ArgumentException("Cannot find ldstr in ImperialMagisterCareerButtonBehavior.GetLesserPowerstones");
        }

        [HarmonyTranspiler]
        [HarmonyPatch(typeof(ImperialMagisterCareerButtonBehavior), "GetGreaterPowerstones")]
        public static IEnumerable<CodeInstruction> GetGreaterPowerstonesTranspiler(IEnumerable<CodeInstruction> instructions /*, ILGenerator generator*/)
        {
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "Greater Enlightening Fire Ruby":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=f5GjfKTO}Greater Enlightening Fire Ruby");
                            found = true;
                            break;
                        case "+50% Fire amplification, 15% Fire damage+30% ":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=Z5pjKit6}+50% Fire amplification, 15% Fire damage+30% ");
                            found = true;
                            break;
                        case "Lesser Sparkling Fire Ruby":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=Pho9k5TZ}Lesser Sparkling Fire Ruby");
                            found = true;
                            break;
                        case "Greater Nourishing Fire Ruby":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=YmMV1FaT}Greater Nourishing Fire Ruby");
                            found = true;
                            break;
                        case "Fire amplification, +20% speed":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=04LX4D4g}Fire amplification, +20% speed");
                            found = true;
                            break;
                        case "Greater Protecting Lumenstone":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=5rJagi1s}Greater Protecting Lumenstone");
                            found = true;
                            break;
                        case "+40% physical, 40% magical resistance":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=HGyLxlkC}+40% physical, 40% magical resistance");
                            found = true;
                            break;
                        case "Greater Timewarp Lumenstone":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=G0JdYzCc}Greater Timewarp Lumenstone");
                            found = true;
                            break;
                        case "Add 25% movement Speed and 25% magical melee damage":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=TbhqdHTe}Add 25% movement Speed and 25% magical melee damage");
                            found = true;
                            break;
                        case "Greater Ghost Amber of the Wild":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=zkIczesw}Greater Ghost Amber of the Wild");
                            found = true;
                            break;
                        case "Unit is unstopable, will not show any sign of pain":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=7LPj6Mle}Unit is unstopable, will not show any sign of pain");
                            found = true;
                            break;
                        case "Greater Ghost Amber of the Hunter":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=5FaZoN7L}Greater Ghost Amber of the Hunter");
                            found = true;
                            break;
                        case "+35% ranged resistance,+25% ranged damage":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=hrPyUJCq}+35% ranged resistance,+25% ranged damage");
                            found = true;
                            break;
                        case "Greater Spiky Vitalleum":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=QVYNidJb}Greater Spiky Vitalleum");
                            found = true;
                            break;
                        case "Received damage is reapplied by 25%  as thorne damage":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=34v1RlTL}Received damage is reapplied by 25%  as thorne damage");
                            found = true;
                            break;
                        case "Greater Protecting Vitalleum":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=yTfNU2wj}Greater Protecting Vitalleum");
                            found = true;
                            break;
                        case "+35% Wardsave":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=V15RlBe4}+35% Wardsave");
                            found = true;
                            break;
                        case "Greater Amplifying True Sapphires":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=GyTBsHYZ}Greater Amplifying True Sapphires");
                            found = true;
                            break;
                        case "+40% lightning damage":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=0Wse8HhZ}+40% lightning damage");
                            found = true;
                            break;
                        case "Greater True Dissipation Sapphires":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=lYQEeagj}Greater True Dissipation Sapphires");
                            found = true;
                            break;
                        case "+40% physical, magic & lightning resistance":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=Us35Lxvi}+40% physical, magic & lightning resistance");
                            found = true;
                            break;
                        case "Greater Goldstone of Disintegration":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=6t6PgaeG}Greater Goldstone of Disintegration");
                            found = true;
                            break;
                        case "+20% magical damage, 20% fire damage":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=OT2L6a20}+20% magical damage, 20% fire damage");
                            found = true;
                            break;
                        case "Greater Goldstone of Sharpening":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=xRJWCTTM}Greater Goldstone of Sharpening");
                            found = true;
                            break;
                        case "+50% Armor penetration":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=xOmOPG3t}+50% Armor penetration");
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
                throw new ArgumentException("Cannot find ldstr in ImperialMagisterCareerButtonBehavior.GetGreaterPowerstones");
        }

        [HarmonyTranspiler]
        [HarmonyPatch(typeof(ImperialMagisterCareerButtonBehavior), "GetMightyPowerStones")]
        public static IEnumerable<CodeInstruction> GetMightyPowerStonesTranspiler(IEnumerable<CodeInstruction> instructions /*, ILGenerator generator*/)
        {
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "Mighty Fire Ruby":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=pcT0rC1F}Mighty Fire Ruby");
                            found = true;
                            break;
                        case "+150% Fire amp., 15% Fire dmg.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=WrxXRTUL}+150% Fire amp., 15% Fire dmg.");
                            found = true;
                            break;
                        case "Mighty Lumen Stone":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=8ksiM1pP}Mighty Lumen Stone");
                            found = true;
                            break;
                        case "40% magical dmg., slows enemies on hit":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=f5GjfKTO}40% magical dmg., slows enemies on hit");
                            found = true;
                            break;
                        case "Mighty Ghost Amber":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=NJRagXEd}Mighty Ghost Amber");
                            found = true;
                            break;
                        case "Greater Enlightening Fire Ruby":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=f5GjfKTO}Greater Enlightening Fire Ruby");
                            found = true;
                            break;
                        case "+50% speed, +50% physical resistance":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=PyvaHBTn}+50% speed, +50% physical resistance");
                            found = true;
                            break;
                        case "Mighty Vitalleum":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=Tjeup2Lj}Mighty Vitalleum");
                            found = true;
                            break;
                        case "Regenerate 1 HP every second":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=Pa0yYBVo}Regenerate 1 HP every second");
                            found = true;
                            break;
                        case "Mighty True Saphires":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=WWWfqmAh}Mighty True Saphires");
                            found = true;
                            break;
                        case "+20% electric, +20%frost dmg, 20% slowdown":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=O50eGiTq}+20% electric, +20%frost dmg, 20% slowdown");
                            found = true;
                            break;
                        case "Mighty Goldstone":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=igrRzazu}Mighty Goldstone");
                            found = true;
                            break;
                        case "40% Armor penetration, 20% magical, 20% fire":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=aBtdmcVu}40% Armor penetration, 20% magical, 20% fire");
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
                throw new ArgumentException("Cannot find ldstr in ImperialMagisterCareerButtonBehavior.GetMightyPowerStones");
        }

        [HarmonyTranspiler]
        [HarmonyPatch(typeof(ImperialMagisterCareerButtonBehavior), "PromptSelectPowerstone")]
        public static IEnumerable<CodeInstruction> PromptSelectPowerstoneTranspiler(IEnumerable<CodeInstruction> instructions /*, ILGenerator generator*/)
        {
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "You don't have enough Winds":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=U97IR6CM}You don't have enough Winds");
                            found = true;
                            break;
                        case "{{{0}}}{1}{2}{3}{{PRESTIGE_ICON}} Reserved Winds: {4}{{WINDS_ICON}}":
                            var codeInstruction = new CodeInstruction(OpCodes.Ldstr, "{{{0}}}{1}{2}{3}{{PRESTIGE_ICON}} 魔法之风上限减少: {4}{{WINDS_ICON}}");
                            codeInstruction.labels.AddRange(instruction.labels);
                            yield return codeInstruction;
                            found = true;
                            break;
                        case "Remove {0}":
                            yield return new CodeInstruction(OpCodes.Ldstr, "移除 {0}");
                            found = true;
                            break;
                        case "Choose Power stone":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=bqEqZ6Pv}Choose Power stone");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Empower your troop with a permanent magical effect of a Power stone. The effect will reduce your total amount of Winds while the stone is active.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=ZBwVFK6H}Empower your troop with a permanent magical effect of a Power stone. The effect will reduce your total amount of Winds while the stone is active.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Accept":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=APcnKMgv}Accept");
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
                    found = true;
                }
                else
                {
                    yield return instruction;
                }
            }
            if (found is false)
                throw new ArgumentException("Cannot find ldstr in ImperialMagisterCareerButtonBehavior.PromptSelectPowerstone");
        }

        [HarmonyTranspiler]
        [HarmonyPatch(typeof(ImperialMagisterCareerButtonBehavior), "ShouldButtonBeActive")]
        public static IEnumerable<CodeInstruction> ShouldButtonBeActiveTranspiler(IEnumerable<CodeInstruction> instructions /*, ILGenerator generator*/)
        {
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "troop is not expierenced enough (tier 4 and above)":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=yxyPX3NZ}troop is not expierenced enough (tier 4 and above)");
                            found = true;
                            break;
                        case "You do not have enough prestige to create power stones":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=QomHhRYo}You do not have enough prestige to create power stones");
                            found = true;
                            break;
                        case "Remove Powerstone":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=qTUNvyz2}Remove Powerstone");
                            found = true;
                            break;
                        case "Create Powerstone empowering your troop or character":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=e0xygSto}Create Powerstone empowering your troop or character");
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
                throw new ArgumentException("Cannot find ldstr in ImperialMagisterCareerButtonBehavior.ShouldButtonBeActive");
        }
    }
}
