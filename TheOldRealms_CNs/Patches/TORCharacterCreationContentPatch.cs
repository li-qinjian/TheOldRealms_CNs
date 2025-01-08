using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using TaleWorlds.ModuleManager;
using TOR_Core.CampaignMechanics.CharacterCreation;
using TOR_Core.Items;
using TOR_Core.Utilities;
using static HarmonyLib.Code;

namespace TOR_Localization.Patches
{
    [HarmonyPatch]
    internal class TORCharacterCreationContentPatch
    {
        [HarmonyTranspiler]
        [HarmonyPatch(typeof(TORCharacterCreationContent), MethodType.Constructor)]
        public static IEnumerable<CodeInstruction> Transpiler1(IEnumerable<CodeInstruction> instructions /*, ILGenerator generator*/)
        {
            var get_TORCoreModuleExtendedDataPath = AccessTools.Method(typeof(TORPaths), "get_TORCoreModuleExtendedDataPath");

            var found = false;
            foreach (var instruction in instructions)
            {
                yield return instruction;
                if (instruction.opcode == OpCodes.Call && instruction.operand == (object)get_TORCoreModuleExtendedDataPath)
                {
                    yield return new CodeInstruction(OpCodes.Ldstr, "TOR_Localization");
                    yield return new CodeInstruction(OpCodes.Call, AccessTools.Method(typeof(ModuleHelper), nameof(ModuleHelper.GetModuleFullPath)));
                    yield return new CodeInstruction(OpCodes.Ldstr, "ModuleData/tor_custom_xmls/");
                    yield return new CodeInstruction(OpCodes.Call, AccessTools.Method(typeof(String), nameof(String.Concat), new Type[] { typeof(string), typeof(string) }));

                    found = true;
                }

            }
            if (found is false)
                throw new ArgumentException("Cannot find TOR_Core.Utilities.TORPaths::get_TORCoreModuleExtendedDataPath() in TORCharacterCreationContent.ctor");
        }

        [HarmonyTranspiler]
        [HarmonyPatch(typeof(TORCharacterCreationContent), "SetMenuLabelTexts")]
        public static IEnumerable<CodeInstruction> Transpiler2(IEnumerable<CodeInstruction> instructions /*, ILGenerator generator*/)
        {
            var found = false;
            foreach (var instruction in instructions)
            {
                //if (instruction.opcode == OpCodes.Ldstr && instruction.operand.ToString() == "Teenage years...")
                if (instruction.opcode == OpCodes.Ldstr)
                    {
                    //yield return new CodeInstruction(OpCodes.Ldstr, "选择你的家庭出身");
                    found = true;
                }
                yield return instruction;
                //else if (instruction.opcode == OpCodes.Ldstr && instruction.operand == (object)"Teenage years...")
                //{
                //    yield return new CodeInstruction(OpCodes.Ldstr, "青年时代...");
                //    found = true;
                //}
                //else if (instruction.opcode == OpCodes.Ldstr && instruction.operand == (object)"Your starting profession...")
                //{
                //    yield return new CodeInstruction(OpCodes.Ldstr, "你的起始职业...");
                //    found = true;
                //}
                if (found is false)
                    throw new ArgumentException("Cannot find ldstr Choose your family's background... in TORCharacterCreationContent.SetMenuLabelTexts");
            }
        }
    }
}