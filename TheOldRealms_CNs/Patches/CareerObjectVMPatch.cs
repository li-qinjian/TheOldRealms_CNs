using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using TaleWorlds.Localization;
using TOR_Core.CharacterDevelopment.CareerSystem;

namespace TheOldRealms_CNs.Patches
{
    [HarmonyPatch]
    internal class CareerObjectVMPatch
    {
        [HarmonyTranspiler]
        [HarmonyPatch(typeof(CareerObjectVM), "RefreshValues")]
        public static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions /*, ILGenerator generator*/)
        {
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr && instruction.operand.ToString() == "Free career points: ")
                {
                    yield return new CodeInstruction(OpCodes.Ldstr, "{=ENYsSvUd}Free career points: ");
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
                throw new ArgumentException("Cannot find ldstr Free career points:  in CareerObjectVM.RefreshValues");
        }
    }
}
