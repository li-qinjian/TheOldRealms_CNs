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
    internal class WitchHunterCareerButtonBehaviorPatch
    {
        [HarmonyTranspiler]
        [HarmonyPatch(typeof(WitchHunterCareerButtonBehavior), "SetUpRetinueExchange")]
        public static IEnumerable<CodeInstruction> SetUpRetinueExchangeTranspiler(IEnumerable<CodeInstruction> instructions /*, ILGenerator generator*/)
        {
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "Witch Hunter Retinues":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=sBEe7CNG}Witch Hunter Retinues");
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
                throw new ArgumentException("Cannot find ldstr in WitchHunterCareerButtonBehavior.SetUpRetinueExchange");
        }

        [HarmonyTranspiler]
        [HarmonyPatch(typeof(WitchHunterCareerButtonBehavior), "ShouldButtonBeActive")]
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
                        case "Upgrades troop to a Witch Hunter Retinue":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=j6E4MU1Z}Upgrades troop to a Witch Hunter Retinue");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Knights Cant be upgraded to Retinues":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=TmfnLHsV}Knights Cant be upgraded to Retinues");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Not enough healthy troops available":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=1Z4ADKAt}Not enough healthy troops available");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Needs to be part of the empire or southern realms":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=rnOUKMf7}Needs to be part of the empire or southern realms");
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
                throw new ArgumentException("Cannot find ldstr in WitchHunterCareerButtonBehavior.ShouldButtonBeActive");
        }
    }
}
