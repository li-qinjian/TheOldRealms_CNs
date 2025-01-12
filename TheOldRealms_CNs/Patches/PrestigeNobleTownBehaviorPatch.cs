using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using TaleWorlds.Localization;
using TOR_Core.AbilitySystem.Spells.Prayers;
using TOR_Core.CampaignMechanics.Menagery;

namespace TheOldRealms_CNs.Patches
{
    [HarmonyPatch]
    internal class PrestigeNobleTownBehaviorPatch
    {
        [HarmonyTranspiler]
        [HarmonyPatch(typeof(PrestigeNobleTownBehavior), "SelectDemiGryphen")]
        public static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions /*, ILGenerator generator*/)
        {
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "Choose your demigryph!":
                            var codeInstruction = new CodeInstruction(OpCodes.Ldstr, "{=DskvrbLy}Choose your demigryph!");
                            codeInstruction.labels.AddRange(instruction.labels);
                            codeInstruction.blocks.AddRange(instruction.blocks);
                            yield return codeInstruction;
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "The Noble offers you his service, one of his demi gryphens he kept in the menagerie is available to you.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=cp867vwt}The Noble offers you his service, one of his demi gryphens he kept in the menagerie is available to you.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "OK":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=APcnKMgv}OK");
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
                throw new ArgumentException("Cannot find ldstr 'Choose your demigryph!' in PrestigeNobleTownBehavior.SelectDemiGryphen");
        }
    }
}
