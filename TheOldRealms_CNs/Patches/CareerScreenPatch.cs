using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using TOR_Core.CharacterDevelopment.CareerSystem;

namespace TheOldRealms_CNs.Patches
{
    [HarmonyPatch]
    internal class CareerScreenPatch
    {
        [HarmonyTranspiler]
        [HarmonyPatch(typeof(CareerScreen), "TaleWorlds.Core.IGameStateListener.OnActivate")]
        public static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions /*, ILGenerator generator*/)
        {
            var found = false;
            var constructor = AccessTools.Constructor(typeof(CareerScreenVM), new Type[] { typeof(System.Action) });
            foreach (var instruction in instructions)
            {                
                //if (instruction.opcode == OpCodes.Newobj && instruction.operand == (object)constructor)
                //{
                //    yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(CareerScreenVMOverride), new Type[] { typeof(Action) }));
                //}

                if (instruction.opcode == OpCodes.Ldstr && instruction.operand.ToString() == "CareerScreen")
                {
                    yield return new CodeInstruction(OpCodes.Ldstr, "CareerScreenOverride");

                    found = true;
                }
                else
                {
                    yield return instruction;
                }
            }
            if (found is false)
                throw new ArgumentException("Cannot find ldstr CareerScreen in CareerScreen.OnActivate");
        }
    }
}
