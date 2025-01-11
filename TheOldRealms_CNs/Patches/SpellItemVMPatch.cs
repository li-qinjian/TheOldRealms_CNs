using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using TaleWorlds.Localization;
using TOR_Core.AbilitySystem.SpellBook;

namespace TheOldRealms_CNs.Patches
{
    [HarmonyPatch]
    internal class SpellItemVMPatch
    {
        [HarmonyTranspiler]
        [HarmonyPatch(typeof(SpellItemVM), "ExecuteLearnSpell")]
        public static IEnumerable<CodeInstruction> Transpiler1(IEnumerable<CodeInstruction> instructions /*, ILGenerator generator*/)
        {
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "Successfully learned spell: ":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=i99UqhEh}Successfully learned spell: ");
                            found = true;
                            break;
                        case "Not enough gold":
                            var codeInstruction = new CodeInstruction(OpCodes.Ldstr, "{=RzFw93wz}Not enough gold");
                            codeInstruction.labels.AddRange(instruction.labels);
                            yield return codeInstruction;
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
                throw new ArgumentException("Cannot find ldstr 'Successfully learned spell: ' in SpellItemVM.ExecuteLearnSpell");
        }

        [HarmonyTranspiler]
        [HarmonyPatch(typeof(SpellItemVM), "RefreshValues")]
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
                        case "Unfamiliar lore":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=BNvFkEzF}Unfamiliar lore");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Insufficient caster level":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=0nWD1vCr}Insufficient caster level");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Can learn":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=zsO0terz}Can learn");
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
                throw new ArgumentException("Cannot find ldstr 'Unfamiliar lore' in SpellItemVM.RefreshValues");
        }
    }
}
