using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using TaleWorlds.Core;
using TaleWorlds.Library;
using TaleWorlds.Localization;
using TheOldRealms_CNs.Extensions;
using TOR_Core.BattleMechanics.DamageSystem;
using TOR_Core.CharacterDevelopment;
using TOR_Core.Utilities;

namespace TheOldRealms_CNs.Patches
{
    [HarmonyPatch]
    internal class TORDamageDisplayPatch
    {
        [HarmonyTranspiler]
        [HarmonyPatch(typeof(TORDamageDisplay), "DisplaySpellDamageResult")]
        public static IEnumerable<CodeInstruction> DisplaySpellDamageResultTranspiler(IEnumerable<CodeInstruction> instructions /*, ILGenerator generator*/)
        {
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "Physical":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=tor_enum_DamageType_to_textObject_Physical}Physical");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Magical":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=tor_enum_DamageType_to_textObject_Magical}Magical");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "fire":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=tor_enum_DamageType_to_textObject_Fire}fire");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "holy":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=tor_enum_DamageType_to_textObject_Holy}holy");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Lightning":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=tor_enum_DamageType_to_textObject_Lightning}Lightning");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Frost":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=tor_enum_DamageType_to_textObject_Frost}Frost");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case " cast damage consisting of   (":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=PjlOCgKb} cast damage consisting of   (");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case ") was applied which was modified by ":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=nP3uh2XY}) was applied which was modified by ");
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
                throw new ArgumentException("Cannot find ldstr in TORDamageDisplay.DisplaySpellDamageResult");
        }

        [HarmonyTranspiler]
        [HarmonyPatch(typeof(TORDamageDisplay), "DisplayDamageResult")]
        public static IEnumerable<CodeInstruction> DisplayDamageResultTranspiler(IEnumerable<CodeInstruction> instructions /*, ILGenerator generator*/)
        {
            var DamageType = AccessTools.TypeByName("DamageType");
            var toTextObjct = AccessTools.Method(typeof(EnumExtensions), nameof(EnumExtensions.ToTextObject));
            var toString = AccessTools.Method(typeof(Object), nameof(Object.ToString));

            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case ", {0} was dealt in {1} [{2}{3}]":
                            yield return new CodeInstruction(OpCodes.Ldstr, ", {0} {1}[{2}{3}]");
                            //yield return new CodeInstruction(OpCodes.Ldnull);
                            //yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            //yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case " was absorbed":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=6OQzLYHL} was absorbed");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "{0} damage was dealt which was {1}{2}{3} {4}{5}{6}":
                            var codeInstruction = new CodeInstruction(OpCodes.Ldstr, "{0} 伤害（{1} {4}[{2}{3}]  {5}{6}）");
                            codeInstruction.labels.AddRange(instruction.labels);
                            yield return codeInstruction;
                            //yield return new CodeInstruction(OpCodes.Ldnull);
                            //yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            //yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        default:
                            yield return instruction;
                            break;
                    }

                    found = true;
                }
                else if (instruction.opcode == OpCodes.Box && instruction.operand == (object)DamageType)
                {
                    yield return instruction;
                    yield return new CodeInstruction(OpCodes.Ldnull);
                    yield return new CodeInstruction(OpCodes.Call, toTextObjct);
                    yield return new CodeInstruction(OpCodes.Callvirt, toString);
                }
                else
                {
                    yield return instruction;
                }
            }
            if (found is false)
                throw new ArgumentException("Cannot find ldstr in TORDamageDisplay.DisplayDamageResult");
        }

        //[HarmonyPrefix]
        //[HarmonyPatch(typeof(TORDamageDisplay), "DisplayDamageResult")]
        //public static bool Prefix(int resultDamage, float[] categories, float[] percentages, float wardsaveFactor, bool isVictim)
        //{
        //    Color displaycolor = Color.White;
        //    DamageType dominantAdditionalEffect = DamageType.Physical;
        //    float dominantCategory = 0f;
        //    string additionalDamageTypeText = "";
        //    string sign = "";
        //    for (int i = 2; i < categories.Length; i++)
        //    {
        //        if (dominantCategory < categories[i])
        //        {
        //            dominantCategory = categories[i];
        //            dominantAdditionalEffect = (DamageType)i;
        //        }
        //        if (categories[i] > 0f)
        //        {
        //            string categorysign = "";
        //            if (percentages[i] > 0f)
        //            {
        //                categorysign = "+";
        //            }
        //            DamageType t = (DamageType)i;
        //            string s = string.Format(", {0} was dealt in {1} [{2}{3}]", new object[]
        //            {
        //                (int)categories[i],
        //                t.ToTextObject().ToString(),
        //                categorysign,
        //                percentages[i].ToString(".%")
        //            });
        //            if (additionalDamageTypeText == "")
        //            {
        //                additionalDamageTypeText = s;
        //            }
        //            else
        //            {
        //                additionalDamageTypeText = additionalDamageTypeText.Add(s, false);
        //            }
        //        }
        //    }
        //    if (isVictim)
        //    {
        //        displaycolor = Color.FromUint(9856100U);
        //    }
        //    else
        //    {
        //        switch (dominantAdditionalEffect)
        //        {
        //            case DamageType.Magical:
        //                displaycolor = Colors.Cyan;
        //                break;
        //            case DamageType.Fire:
        //                displaycolor = Colors.Red;
        //                break;
        //            case DamageType.Holy:
        //                displaycolor = Colors.Yellow;
        //                break;
        //            case DamageType.Lightning:
        //                displaycolor = Color.FromUint(5745663U);
        //                break;
        //        }
        //    }
        //    if (percentages[1] > 0f)
        //    {
        //        sign = "+";
        //    }
        //    string wardsaveFactorText = "";
        //    if (wardsaveFactor < 1f)
        //    {
        //        wardsaveFactorText = ", " + (1f - wardsaveFactor).ToString(".%") + " was absorbed";
        //    }
        //    InformationManager.DisplayMessage(new InformationMessage(string.Format(new TextObject("{0} damage was dealt which was {1}{2}{3} {4}{5}{6}").ToString(), new object[]
        //    {
        //        resultDamage,
        //        (int)categories[1],
        //        sign,
        //        (percentages[1] != 0f) ? ("(" + percentages[1].ToString(".%") + ")") : "",
        //        DamageType.Physical.ToTextObject().ToString(),
        //        additionalDamageTypeText,
        //        wardsaveFactorText
        //    }), displaycolor));

        //    return false;
        //}
    }
}
