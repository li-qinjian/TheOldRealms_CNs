using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Localization;
using TheOldRealms_CNs.Extensions;
using TOR_Core.AbilitySystem.SpellBook;
using TOR_Core.AbilitySystem.Spells;
using TOR_Core.AbilitySystem.Spells.Prayers;
using TOR_Core.CampaignMechanics.Religion;
using TOR_Core.CharacterDevelopment.CareerSystem;
using TOR_Core.Extensions;

namespace TheOldRealms_CNs.Patches
{
    [HarmonyPatch]
    internal class BattlePrayersVMPatch
    {
        [HarmonyTranspiler]
        [HarmonyPatch(typeof(BattlePrayersVM), "Initialize")]
        public static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions /*, ILGenerator generator*/)
        {
            var PrayerLevel = AccessTools.TypeByName("PrayerLevel");
            var toTextObjct = AccessTools.Method(typeof(EnumExtensions), nameof(EnumExtensions.ToTextObject));

            var found = false;
            var i = 0;
            var instructionsList = new List<CodeInstruction>(instructions); 
            foreach (var instruction in instructionsList)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "Devoted to : ":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=XFvGclRH}Devoted to : ");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "Prayer level: ":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=BssrlIDo}Prayer level: ");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        default:
                            yield return instruction;
                            break;
                    }
                }
                else if (instruction.opcode == OpCodes.Ldloca_S && instructionsList[i + 1].opcode == OpCodes.Constrained && instructionsList[i + 1].operand == (object)PrayerLevel)
                {
                    yield return new CodeInstruction(OpCodes.Ldloc_S, instruction.operand);
                }
                else if (instruction.opcode == OpCodes.Constrained && instruction.operand == (object)PrayerLevel)
                {
                    yield return new CodeInstruction(OpCodes.Box, PrayerLevel);
                    yield return new CodeInstruction(OpCodes.Ldnull);
                    yield return new CodeInstruction(OpCodes.Call, toTextObjct);
                    found = true;
                }
                else
                {
                    yield return instruction;
                }
                i++;
            }
            if (found is false)
                throw new ArgumentException("Cannot find ldstr 'Devoted to : ' in BattlePrayersVM.Initialize");
        }
    }
}
