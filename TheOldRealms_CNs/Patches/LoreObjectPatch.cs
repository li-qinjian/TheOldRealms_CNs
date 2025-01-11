using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using TaleWorlds.Localization;
using TOR_Core.AbilitySystem.Spells;
using TOR_Core.CampaignMechanics.CharacterCreation;

namespace TheOldRealms_CNs.Patches
{
    [HarmonyPatch]
    internal class LoreObjectPatch
    {
        [HarmonyTranspiler]
        [HarmonyPatch(typeof(LoreObject), "GetAll")]
        public static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions /*, ILGenerator generator*/)
        {
            var found = false;
            var i = 0;
            var listInstructions = new List<CodeInstruction>(instructions);
            foreach (var instruction in listInstructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "Minor Magic":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=JX7zCt89}Minor Magic");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Lore of Fire":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=2FOZvUat}Lore of Fire");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Lore of Light":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=UsRNAJeh}Lore of Light");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Lore of Heavens":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=fjbmyqlW}Lore of Heavens");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Lore of Life":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=OYcNcuJG}Lore of Life");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Lore of Metal":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=I9jG7hj8}Lore of Metal");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Lore of Beasts":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=C61DCGqh}Lore of Beasts");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "High Magic":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=Y5iq8Hmn}High Magic");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Dark Magic":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=oWhw9ZtM}Dark Magic");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Necromancy":
                            if (listInstructions[i + 1].opcode == OpCodes.Ldstr && listInstructions[i + 1].operand.ToString() == "necromancy_symbol")
                            {
                                yield return new CodeInstruction(OpCodes.Ldstr, "{=LgRvw60L}Necromancy");
                                yield return new CodeInstruction(OpCodes.Ldnull);
                                yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                                yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                                found = true;
                            }
                            else
                            {
                                yield return instruction;
                            }
                            break;
                        default:
                            yield return instruction;
                            break;
                    }
                }
                else
                {
                    yield return instruction;
                }
                i++;
            }
            if (found is false)
                throw new ArgumentException("Cannot find ldstr 'Choose God' in LoreObject.GetAll");
        }
    }
}
