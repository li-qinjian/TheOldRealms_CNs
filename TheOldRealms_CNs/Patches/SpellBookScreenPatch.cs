using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using TOR_Core.AbilitySystem.SpellBook;

namespace TheOldRealms_CNs.Patches
{
    [HarmonyPatch]
    internal class SpellBookScreenPatch
    {
        [HarmonyTranspiler]
        [HarmonyPatch(typeof(SpellBookScreen), "TaleWorlds.Core.IGameStateListener.OnActivate")]
        public static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions /*, ILGenerator generator*/)
        {
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr && instruction.operand.ToString() == "SpellBook")
                {
                    yield return new CodeInstruction(OpCodes.Ldstr, "SpellBookOverride");
                    found = true;
                }
                else
                {
                    yield return instruction;
                }
            }
            if (found is false)
                throw new ArgumentException("Cannot find ldstr 'SpellBook' in SpellBookScreen.OnActivate");
        }
    }
}
