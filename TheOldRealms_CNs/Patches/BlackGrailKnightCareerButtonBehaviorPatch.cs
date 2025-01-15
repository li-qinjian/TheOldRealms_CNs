using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using TaleWorlds.Localization;
using TheOldRealms_CNs.Extensions;
using TOR_Core.AbilitySystem.SpellBook;
using TOR_Core.CharacterDevelopment.CareerSystem.CareerButton;
using TOR_Core.Extensions.ExtendedInfoSystem;

namespace TheOldRealms_CNs.Patches
{
    [HarmonyPatch]
    internal class BlackGrailKnightCareerButtonBehaviorPatch
    {
        [HarmonyTranspiler]
        [HarmonyPatch(typeof(BlackGrailKnightCareerButtonBehavior), "SetupKnightExchange")]
        public static IEnumerable<CodeInstruction> SetupKnightExchangeTranspiler(IEnumerable<CodeInstruction> instructions /*, ILGenerator generator*/)
        {
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "Ill fated Knights: Exchange ":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=M14TEX9S}Ill fated Knights: Exchange ");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "for mousillon Knights":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=EqRUi5mH}for mousillon Knights");
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
                throw new ArgumentException("Cannot find ldstr in BlackGrailKnightCareerButtonBehavior.SetupKnightExchange");
        }

        [HarmonyTranspiler]
        [HarmonyPatch(typeof(BlackGrailKnightCareerButtonBehavior), "ShouldButtonBeActive")]
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
                        case "Not enough healthy prisoners available":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=caGWSsQW}Not enough healthy prisoners available");
                            found = true;
                            break;
                        case "Not enough healthy troops available":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=wtFidRsY}Not enough healthy troops available");
                            found = true;
                            break;
                        case "Requires atleast ":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=blPD1ZlQ}Requires atleast ");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Grail knights can't be convinced":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=pOgYAWrm}Grail knights can't be convinced");
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
                throw new ArgumentException("Cannot find ldstr in BlackGrailKnightCareerButtonBehavior.ShouldButtonBeActive");
        }
    }
}
