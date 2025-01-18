using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using TaleWorlds.Localization;
using TOR_Core.AbilitySystem;
using TOR_Core.CampaignMechanics.TORCustomSettlement.CustomSettlementMenus;
using TOR_Core.Utilities;

namespace TheOldRealms_CNs.Patches
{
    [HarmonyPatch]
    internal class CareerAbilityHUD_VMPatch
    {
        [HarmonyTranspiler]
        [HarmonyPatch(typeof(CareerAbilityHUD_VM), "ChargeLevel", MethodType.Setter)]
        public static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions /*, ILGenerator generator*/)
        {
            var _chargeLevel = AccessTools.Field(typeof(CareerAbilityHUD_VM), "_chargeLevel");
            var Concat = AccessTools.Method(typeof(string), nameof(string.Concat), new Type[] { typeof(string), typeof(string) });

            var found = false;
            var i = 0;
            var listInstructions = new List<CodeInstruction>(instructions);
            foreach (var instruction in listInstructions)
            {
                if (instruction.opcode == OpCodes.Ldarg_0 && listInstructions[i + 1].opcode == OpCodes.Ldflda && listInstructions[i + 1].operand == (object)_chargeLevel)
                {
                    yield return new CodeInstruction(OpCodes.Ldstr, "{=ABfcRrsO}CareerAbility Charing： ");
                    yield return new CodeInstruction(OpCodes.Ldnull);
                    yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                    yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                    yield return instruction;
                    found = true;
                }
                else if (instruction.opcode == OpCodes.Call && instruction.operand == (object)Concat)
                {
                    yield return new CodeInstruction(OpCodes.Call, AccessTools.Method(typeof(string), nameof(string.Concat), new Type[] { typeof(string), typeof(string), typeof(string) }));
                }
                else
                {
                    yield return instruction;
                }
                i++;
            }
            if (found is false)
                throw new ArgumentException("Cannot find instruction.opcode == OpCodes.Ldarg_0 in CareerAbilityHUD_VM.ChargeLevelPropertySetter");
        }
    }
}
