using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using TaleWorlds.Localization;
using TOR_Core.CharacterDevelopment.CareerSystem.Choices;

namespace TheOldRealms_CNs.Patches
{
    [HarmonyPatch]
    internal class CareerChoicesPatch
    {
        [HarmonyTranspiler]
        [HarmonyPatch(typeof(NecrarchCareerChoices), "InitialCareerSetup")]
        public static IEnumerable<CodeInstruction> Transpiler1(IEnumerable<CodeInstruction> instructions, ILGenerator generator)
        {
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr && instruction.operand.ToString() == " became a Vampire")
                {
                    var codeInstruction = new CodeInstruction(OpCodes.Ldstr, "{=ob3n6E3M} became a Vampire");
                    codeInstruction.labels.AddRange(instruction.labels);
                    yield return codeInstruction;
                    yield return new CodeInstruction(OpCodes.Ldnull);
                    yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                    yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));

                    found = true;
                }
                else
                {
                    yield return instruction;
                }
            }
            if (found is false)
                throw new ArgumentException("Cannot find ldstr ' became a Vampire' in NecrarchCareerChoices.InitialCareerSetup");
        }

        [HarmonyTranspiler]
        [HarmonyPatch(typeof(BloodKnightCareerChoices), "InitialCareerSetup")]
        public static IEnumerable<CodeInstruction> Transpiler2(IEnumerable<CodeInstruction> instructions, ILGenerator generator)
        {
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr && instruction.operand.ToString() == " became a Blood Knight Vampire")
                {
                    var codeInstruction = new CodeInstruction(OpCodes.Ldstr, "{=MknKgcKP} became a Blood Knight Vampire");
                    codeInstruction.labels.AddRange(instruction.labels);
                    yield return codeInstruction;
                    yield return new CodeInstruction(OpCodes.Ldnull);
                    yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                    yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));

                    found = true;
                }
                else
                {
                    yield return instruction;
                }
            }
            if (found is false)
                throw new ArgumentException("Cannot find ldstr ' became a Blood Knight Vampire' in BloodKnightCareerChoices.InitialCareerSetup");
        }

        [HarmonyTranspiler]
        [HarmonyPatch(typeof(VampireCountCareerChoices), "InitialCareerSetup")]
        public static IEnumerable<CodeInstruction> Transpiler3(IEnumerable<CodeInstruction> instructions, ILGenerator generator)
        {
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr && instruction.operand.ToString() == " became a Vampire")
                {
                    var codeInstruction = new CodeInstruction(OpCodes.Ldstr, "{=ob3n6E3M} became a Vampire");
                    codeInstruction.labels.AddRange(instruction.labels);
                    yield return codeInstruction;
                    yield return new CodeInstruction(OpCodes.Ldnull);
                    yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                    yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));

                    found = true;
                }
                else
                {
                    yield return instruction;
                }
            }
            if (found is false)
                throw new ArgumentException("Cannot find ldstr ' became a Vampire' in VampireCountCareerChoices.InitialCareerSetup");
        }
    }
}
