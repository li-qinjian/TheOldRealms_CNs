using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using TaleWorlds.ModuleManager;
using TOR_Core.CampaignMechanics.CharacterCreation;
using TOR_Core.CharacterDevelopment;
using TOR_Core.Utilities;

namespace TheOldRealms_CNs.Patches
{
    [HarmonyPatch]
    internal class TORSkillEffectsPatch
    {
        [HarmonyTranspiler]
        [HarmonyPatch(typeof(TORSkillEffects), MethodType.Constructor)]
        public static IEnumerable<CodeInstruction> Transpiler1(IEnumerable<CodeInstruction> instructions /*, ILGenerator generator*/)
        {
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "{=!}Winds of magic recharge rate: +{a0} / hour":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=ns9n1Vah}Winds of magic recharge rate: +{a0} / hour");
                            found = true;
                            break;
                        case "{=!}Maximum winds of magic: +{a0}":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=GDp75qTe}Maximum winds of magic: +{a0}");
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
                throw new ArgumentException("Cannot find ldstr {=!}Winds of magic recharge rate: +{a0} / hour or {=!}Maximum winds of magic: +{a0} in TORSkillEffects.ctor");
        }
    }
}
