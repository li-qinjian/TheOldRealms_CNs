using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using TaleWorlds.Localization;
using TOR_Core.CampaignMechanics.CustomEncounterDialogs;
using TOR_Core.CampaignMechanics.TORCustomSettlement;

namespace TheOldRealms_CNs.Patches
{
    [HarmonyPatch]
    internal class TORCustomSettlementCampaignBehaviorPatch
    {
        [HarmonyTranspiler]
        [HarmonyPatch(typeof(TORCustomSettlementCampaignBehavior), "OnMissionEnded")]
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
                        case "Victory!":
                            var codeInstruction = new CodeInstruction(OpCodes.Ldstr, "{=NVAfjGRY}Victory!");
                            codeInstruction.labels.AddRange(instruction.labels);
                            yield return codeInstruction;
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
                        case "Defeated!":
                            var codeInstruction2 = new CodeInstruction(OpCodes.Ldstr, "{=NbDpue0c}Defeated!");
                            codeInstruction2.labels.AddRange(instruction.labels);
                            yield return codeInstruction2;
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
                throw new ArgumentException("Cannot find ldstr in TORCustomSettlementCampaignBehavior.OnMissionEnded");
        }
    }
}
