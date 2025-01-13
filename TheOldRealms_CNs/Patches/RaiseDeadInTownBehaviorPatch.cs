using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using TOR_Core.AbilitySystem;
using TOR_Core.CampaignMechanics.RaiseDead;

namespace TheOldRealms_CNs.Patches
{
    [HarmonyPatch]
    internal class RaiseDeadInTownBehaviorPatch
    {
        [HarmonyTranspiler]
        [HarmonyPatch(typeof(RaiseDeadInTownBehavior), "Initialize")]
        public static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions, ILGenerator generator)
        {
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "Go to the graveyard":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=dSsjNOnw}Go to the graveyard");
                            found = true;
                            break;
                        case "Graveyard":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=JZGSiaZf}Graveyard");
                            found = true;
                            break;
                        case "Leave":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=13Vft5qv}Leave");
                            found = true;
                            break;
                        case "Surrender":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=CuTUFYeS}Surrender");
                            found = true;
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
            }
            if (found is false)
                throw new ArgumentException("Cannot find ldstr 'Go to the graveyard' in RaiseDeadInTownBehavior.Initialize");
        }
    }
}
