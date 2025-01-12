using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using TaleWorlds.Localization;
using TheOldRealms_CNs.Extensions;
using TOR_Core.AbilitySystem;
using TOR_Core.CampaignMechanics.CustomResources;

namespace TheOldRealms_CNs.Patches
{
    [HarmonyPatch]
    internal class ChivalryHelperPatch
    {
        [HarmonyTranspiler]
        [HarmonyPatch(typeof(ChivalryHelper), "GetChivalryInfo")]
        public static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions, ILGenerator generator)
        {
            var chivalryLevelType = typeof(ChivalryLevel);
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "Chivalry Rank":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=Su4TkpI9}Chivalry Rank");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Knightly wages: ":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=41DPFjm4}Knightly wages: ");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Morale: ":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=zisSJbik}Morale: ");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Gain extra  Chivalry everyday":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=YUU11DKq}Gain extra  Chivalry everyday");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Next Rank: ":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=xID1KHTe}Next Rank: ");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Required Chivalry: ":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=UhkPoKgL}Required Chivalry: ");
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
                //else if (instruction.opcode == OpCodes.Box && instruction.operand == (object)chivalryLevelType)  如果下面的else if不能写正确，那这段也不要注入了
                //{
                //    yield return instruction;
                //    yield return new CodeInstruction(OpCodes.Ldnull);
                //    yield return new CodeInstruction(OpCodes.Call, AccessTools.Method(typeof(EnumExtensions), nameof(EnumExtensions.ToTextObject)));
                //}
                //else if (instruction.opcode == OpCodes.Constrained && instruction.operand == (object)chivalryLevelType)
                //{
                //    yield return instruction;
                //    yield return new CodeInstruction(OpCodes.Box, instruction.operand);
                //    yield return new CodeInstruction(OpCodes.Ldnull);
                //    yield return new CodeInstruction(OpCodes.Call, AccessTools.Method(typeof(EnumExtensions), nameof(EnumExtensions.ToTextObject)));
                //}
                else
                {
                    yield return instruction;
                }
            }
            if (found is false)
                throw new ArgumentException("Cannot find ldstr 'Chivalry Rank' in ChivalryHelper.GetChivalryInfo");
        }
    }
}
