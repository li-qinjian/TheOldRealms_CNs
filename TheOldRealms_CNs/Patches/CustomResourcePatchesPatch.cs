using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using TaleWorlds.Localization;
using TOR_Core.AbilitySystem.Spells.Prayers;
using TOR_Core.CampaignMechanics.CustomResources;
using TOR_Core.HarmonyPatches;

namespace TheOldRealms_CNs.Patches
{
    [HarmonyPatch]
    internal class CustomResourcePatchesPatch
    {
        [HarmonyTranspiler]
        [HarmonyPatch(typeof(CustomResourcePatches), "AdditionalPartyScreenClosingLogic")]
        public static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions /*, ILGenerator generator*/)
        {
            var NamePropertyGetter = AccessTools.PropertyGetter(typeof(CustomResource), "Name");
            var LocalizedNameGetter = AccessTools.PropertyGetter(typeof(CustomResource), "LocalizedName");

            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr && instruction.operand.ToString() == "You don't have enough ")
                {
                    yield return new CodeInstruction(OpCodes.Ldstr, "{=rSRZwwck}You don't have enough ");
                    yield return new CodeInstruction(OpCodes.Ldnull);
                    yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                    yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                    found = true;
                }
                else if (instruction.opcode == OpCodes.Callvirt && instruction.operand == (object)NamePropertyGetter)
                {
                    yield return new CodeInstruction(OpCodes.Callvirt, LocalizedNameGetter);
                    yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                }
                else
                {
                    yield return instruction;
                }
            }
            if (found is false)
                throw new ArgumentException("Cannot find ldstr in CustomResourcePatches.AdditionalPartyScreenClosingLogic");
        }
    }
}
