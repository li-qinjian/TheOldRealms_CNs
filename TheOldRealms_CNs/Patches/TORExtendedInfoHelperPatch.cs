using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using TaleWorlds.Localization;
using TheOldRealms_CNs.Extensions;
using TOR_Core.AbilitySystem.Spells;
using TOR_Core.Extensions.ExtendedInfoSystem;
using TOR_Core.Utilities;

namespace TheOldRealms_CNs.Patches
{
    [HarmonyPatch]
    internal class TORExtendedInfoHelperPatch
    {
        [HarmonyTranspiler]
        [HarmonyPatch(typeof(TORExtendedInfoHelper), "GenererateExtendedTroopInfoToolTip")]
        public static IEnumerable<CodeInstruction> GenererateExtendedTroopInfoToolTipTranspiler(IEnumerable<CodeInstruction> instructions /*, ILGenerator generator*/)
        {
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "Unit Attributes":
                            var codeInstruction = new CodeInstruction(OpCodes.Ldstr, "{=zT8vGnja}Unit Attributes");
                            codeInstruction.labels.AddRange(instruction.labels);
                            yield return codeInstruction;
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Health":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=W3YA4UXU}Health");
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
                throw new ArgumentException("Cannot find ldstr in TORDamageDisplay.GenererateExtendedTroopInfoToolTip");
        }

        [HarmonyTranspiler]
        [HarmonyPatch(typeof(TORExtendedInfoHelper), "GenerateResistanceDisplay")]
        public static IEnumerable<CodeInstruction> GenerateResistanceDisplayTipTranspiler(IEnumerable<CodeInstruction> instructions /*, ILGenerator generator*/)
        {
            var ResistedDamageTypeField = AccessTools.Field(typeof(ResistanceTuple), nameof(ResistanceTuple.ResistedDamageType));
            var DamageType = AccessTools.TypeByName("DamageType");
            var toTextObjct = AccessTools.Method(typeof(EnumExtensions), nameof(EnumExtensions.ToTextObject));

            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "Wardsave":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=HkbAtuGQ}Wardsave");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Damage Resistances":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=hA0jJ5I3}Damage Resistances");
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
                else if (instruction.opcode == OpCodes.Ldflda && instruction.operand == (object)ResistedDamageTypeField)
                {
                    yield return new CodeInstruction(OpCodes.Ldfld, instruction.operand);
                    found = true;
                }
                else if (instruction.opcode == OpCodes.Constrained && instruction.operand == (object)DamageType)
                {
                    yield return new CodeInstruction(OpCodes.Box, DamageType);
                    yield return new CodeInstruction(OpCodes.Ldnull);
                    yield return new CodeInstruction(OpCodes.Call, toTextObjct);
                    found = true;
                }
                else
                {
                    yield return instruction;
                }
            }
            if (found is false)
                throw new ArgumentException("Cannot find ldstr in TORDamageDisplay.GenerateResistanceDisplay");
        }

        [HarmonyTranspiler]
        [HarmonyPatch(typeof(TORExtendedInfoHelper), "GenerateAmplifierDisplay")]
        public static IEnumerable<CodeInstruction> GenerateAmplifierDisplayTranspiler(IEnumerable<CodeInstruction> instructions /*, ILGenerator generator*/)
        {
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "Damage Amplification":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=qyPFvVEk}Damage Amplification");
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
                throw new ArgumentException("Cannot find ldstr in TORDamageDisplay.GenerateAmplifierDisplay");
        }

        [HarmonyTranspiler]
        [HarmonyPatch(typeof(TORExtendedInfoHelper), "GenerateDamageDisplay")]
        public static IEnumerable<CodeInstruction> GenerateDamageDisplayTranspiler(IEnumerable<CodeInstruction> instructions /*, ILGenerator generator*/)
        {
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "Ranged":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=1V4Awr07}Ranged");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Melee":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=MrAbpel2}Melee");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Lance/Spear":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=PHOr23UP}Lance/Spear");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case " Damage ":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=ufWv3i3F} Damage ");
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
                throw new ArgumentException("Cannot find ldstr in TORDamageDisplay.GenerateDamageDisplay");
        }
    }
}
