using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using TOR_Core.AbilitySystem.Spells.Prayers;

namespace TheOldRealms_CNs.Patches
{
    [HarmonyPatch]
    internal class BattlePrayerScreenPatch
    {
        [HarmonyTranspiler]
        [HarmonyPatch(typeof(BattlePrayerScreen), "TaleWorlds.Core.IGameStateListener.OnActivate")]
        public static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions /*, ILGenerator generator*/)
        {
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr && instruction.operand.ToString() == "BattlePrayerBook")
                {
                    yield return new CodeInstruction(OpCodes.Ldstr, "BattlePrayerBookOverride");
                    found = true;
                }
                else
                {
                    yield return instruction;
                }
            }
            if (found is false)
                throw new ArgumentException("Cannot find ldstr 'BattlePrayerBook' in BattlePrayerScreen.OnActivate");
        }
    }
}
