using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using TaleWorlds.Localization;
using TOR_Core.CampaignMechanics.Careers;
using TOR_Core.CharacterDevelopment.CareerSystem;

namespace TheOldRealms_CNs.Patches
{
    [HarmonyPatch]
    internal class CareerButtonDialogsPatch
    {
        [HarmonyTranspiler]
        [HarmonyPatch(typeof(CareerButtonDialogs), "MercenaryButtonDialog")]
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
                        case "Aye what can I do for you?":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=i8NcmG8O}Aye what can I do for you?");
                            found = true;
                            break;
                        case "Your employment has gone quite well and I want to bring you on as a partner.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=2dOrUfFU}Your employment has gone quite well and I want to bring you on as a partner.");
                            found = true;
                            break;
                        case "As a partner?":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=6nq6qAsi}As a partner?");
                            found = true;
                            break;
                        case "You get part of the share and need to accomplish a few advanced organisational matters. I will however not pay your wage anymore.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=D8DHn34a}You get part of the share and need to accomplish a few advanced organisational matters. I will however not pay your wage anymore.");
                            found = true;
                            break;
                        case "First I want to see some hard coin. I am not playing Babysitter or 'Partner' without seeing some money first. You pay me {MERCCOMPANIONPRICE}{GOLD_ICON}":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=6iM76Usd}First I want to see some hard coin. I am not playing Babysitter or 'Partner' without seeing some money first. You pay me {MERCCOMPANIONPRICE}{GOLD_ICON}");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Of course, consider this a forward on your upcoming shares.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=bixktRyz}Of course, consider this a forward on your upcoming shares.");
                            found = true;
                            break;
                        case "I don’t have that in hand right now.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=6xopCBIr}I don’t have that in hand right now.");
                            found = true;
                            break;
                        case "Thats a good deal, I am looking foward to this partnership.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=RAmQtRcu}Thats a good deal, I am looking foward to this partnership.");
                            found = true;
                            break;
                        case "Well then I stay with my current wage.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=ZdUwBo10}Well then I stay with my current wage.");
                            found = true;
                            break;
                        case "What a wise decision!":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=Dd1rlhfO}What a wise decision!");
                            found = true;
                            break;
                        case "Fine.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=SdvSJXHd}Fine.");
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
                throw new ArgumentException("Cannot find ldstr 'Aye what can I do for you?' in CareerButtonDialogs.MercenaryButtonDialog");
        }

        [HarmonyTranspiler]
        [HarmonyPatch(typeof(GrailDamselEnvoyOfTheLadyPerkDialog), "EnvoyOfTheLadyDialogOptions")]
        public static IEnumerable<CodeInstruction> TranspilerEnvoyOfTheLadyDialogOptions(IEnumerable<CodeInstruction> instructions /*, ILGenerator generator*/)
        {
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "The Lady demands that you stop slaughtering your fellow Bretonnians! ({0}{1})":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=CG7iYYuN}The Lady demands that you stop slaughtering your fellow Bretonnians! ({0}{1})");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Mylady, how dare you demand me... oh she does?":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=HOTaCoxw}Mylady, how dare you demand me... oh she does?");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "I guess, I can't deny your biding. If the lady demands, I will obey.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=wgRolOcu}I guess, I can't deny your biding. If the lady demands, I will obey.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Our fair and noble land has been invaded! The lady demands that you strike her enemies!({0}{1})":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=XBijn9PB}Our fair and noble land has been invaded! The lady demands that you strike her enemies!({0}{1})");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Ah yeah so you know better, which thread bothers us most ?":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=QsmsOHcs}Ah yeah so you know better, which thread bothers us most ?");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "I guess, I can't deny you your biding. If the lady demands, I will obey.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=xhKvvBtH}I guess, I can't deny you your biding. If the lady demands, I will obey.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Stop war with {FACTION_NAME_1}.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=6iM76Usd}Stop war with {FACTION_NAME_1}.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Stop war with {FACTION_NAME_2}.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=jbCgRKiB}Stop war with {FACTION_NAME_2}.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Stop war with {FACTION_NAME_3}.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=7vmyH5iz}Stop war with {FACTION_NAME_3}.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Actually never mind":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=HYdfRRbz}Actually never mind");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "We need to unite against {FACTION_NAME_1}.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=rqtxmAMN}We need to unite against {FACTION_NAME_1}.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "We need to unite against {FACTION_NAME_2}.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=kTwdv1mK}We need to unite against {FACTION_NAME_2}.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "We need to unite against {FACTION_NAME_3}.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=kNd9FF0B}We need to unite against {FACTION_NAME_3}.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "As you wish Mylady.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=TRe1rxKg}As you wish Mylady.");
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
                throw new ArgumentException("Cannot find ldstr 'The Lady demands that you stop slaughtering your fellow Bretonnians! ({0}{1})' in GrailDamselEnvoyOfTheLadyPerkDialog.EnvoyOfTheLadyDialogOptions");
        }
    }
}
