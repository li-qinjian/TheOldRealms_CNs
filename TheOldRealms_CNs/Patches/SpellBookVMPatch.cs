using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using TaleWorlds.Localization;
using TheOldRealms_CNs.Extensions;
using TOR_Core.AbilitySystem.SpellBook;
using TOR_Core.AbilitySystem.Spells;
using TOR_Core.Extensions.ExtendedInfoSystem;

namespace TheOldRealms_CNs.Patches
{
    [HarmonyPatch]
    internal class SpellBookVMPatch
    {
        [HarmonyTranspiler]
        [HarmonyPatch(typeof(SpellBookVM), "Initialize")]
        public static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions /*, ILGenerator generator*/)
        {
            var SpellCastingLevelField = AccessTools.Field(typeof(HeroExtendedInfo), nameof(HeroExtendedInfo.SpellCastingLevel));
            var SpellCastingLevel = AccessTools.TypeByName("SpellCastingLevel");
            var toTextObjct = AccessTools.Method(typeof(EnumExtensions), nameof(EnumExtensions.ToTextObject));

            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "Hero name: ":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=JtQvmrcR}Hero name: ");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Spell casting level: ":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=RzFw93wz}Spell casting level: ");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Maximum Winds of Magic: ":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=yQRUQHyd}Maximum Winds of Magic: ");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Current Winds of Magic: ":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=OkjrMxCX}Current Winds of Magic: ");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Winds of Magic recharge rate: ":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=pBRJVbRM}Winds of Magic recharge rate: ");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "/ hour":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=sqRSVYq0}/ hour");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Known Magic Schools: ":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=Cxkbaha7}Known Magic Schools: ");
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
                else if (instruction.opcode == OpCodes.Ldflda && instruction.operand == (object)SpellCastingLevelField)
                {
                    yield return new CodeInstruction(OpCodes.Ldfld, instruction.operand);
                }
                else if (instruction.opcode == OpCodes.Constrained && instruction.operand == (object)SpellCastingLevel)
                {
                    yield return new CodeInstruction(OpCodes.Box, SpellCastingLevel);
                    yield return new CodeInstruction(OpCodes.Ldnull);
                    yield return new CodeInstruction(OpCodes.Call, toTextObjct);
                }
                else
                {
                    yield return instruction;
                }
            }
            if (found is false)
                throw new ArgumentException("Cannot find ldstr 'Hero name: ' in SpellBookVM.Initialize");
        }
    }
}
