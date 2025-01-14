using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using TaleWorlds.Localization;
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
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=AKmb49uI}Physical");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Magical":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=tXn87GoB}Magical");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "fire":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=Sr9yggir}fire");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "holy":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=aGsiaegH}holy");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Lightning":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=90ruy50y}Lightning");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Frost":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=vj5Nszy4}Frost");
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
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case ", {0} was dealt in {1} [{2}{3}]":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=cHwmL0Qp}, {0} was dealt in {1} [{2}{3}]");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
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
                            var codeInstruction = new CodeInstruction(OpCodes.Ldstr, "{=gunBlw1K}{0} damage was dealt which was {1}{2}{3} {4}{5}{6}");
                            codeInstruction.labels.AddRange(instruction.labels);
                            yield return codeInstruction;
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
                throw new ArgumentException("Cannot find ldstr in TORDamageDisplay.DisplayDamageResult");
        }
    }
}
