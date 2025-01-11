//using HarmonyLib;
//using System;
//using System.Collections.Generic;
//using System.Reflection.Emit;
//using TaleWorlds.Localization;
//using TOR_Core.CharacterDevelopment;

//namespace TheOldRealms_CNs.Patches
//{
//    [HarmonyPatch]
//    internal class TORCareersPatch
//    {
//        [HarmonyTranspiler]
//        [HarmonyPatch(typeof(TORCareers), "InitializeAll")]
//        public static IEnumerable<CodeInstruction> Transpiler2(IEnumerable<CodeInstruction> instructions /*, ILGenerator generator*/)
//        {
//            var found = false;
//            foreach (var instruction in instructions)
//            {

//                if (instruction.opcode == OpCodes.Ldstr)
//                {
//                    var stringOperand = instruction.operand.ToString();
//                    switch (stringOperand)
//                    {
//                        case "Damsel of the Lady":
//                            yield return new CodeInstruction(OpCodes.Ldstr, "{=AYVv3LIC}Damsel of the Lady");
//                            yield return new CodeInstruction(OpCodes.Ldnull);
//                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
//                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
//                            found = true;
//                            break;
//                        default:
//                            yield return instruction;
//                            break;
//                    }
//                }
//                else
//                {
//                    yield return instruction;
//                }
//            }
//            if (found is false)
//                throw new ArgumentException("Cannot find ldstr Choose your family's background... in TORCharacterCreationContent.SetMenuLabelTexts");
//        }
//    }
//}
