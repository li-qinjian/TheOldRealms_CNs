using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using TaleWorlds.CampaignSystem.Settlements.Buildings;
using TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.TownManagement;
using TaleWorlds.Engine;
using TaleWorlds.Localization;
using TaleWorlds.ModuleManager;
using TOR_Core.CampaignMechanics.CharacterCreation;
using TOR_Core.Utilities;

namespace TOR_Localization.Patches
{
    [HarmonyPatch]
    internal class TORSubModulePatch
    {
        [HarmonyTranspiler]
        [HarmonyPatch(typeof(TOR_Core.SubModule), "OnApplicationTick")]
        public static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions /*, ILGenerator generator*/)
        {
            var found = false;
            foreach (var instruction in instructions)
            {

                if (instruction.opcode == OpCodes.Ldstr && instruction.operand.ToString() == "Shader compilation in progress. Remaining shaders to compile: ")
                {
                    yield return new CodeInstruction(OpCodes.Ldsfld, AccessTools.Field(typeof(TOR_Localization.SubModule), nameof(TOR_Localization.SubModule.ShadersCompilingString)));

                    found = true;
                }
                else
                {
                    yield return instruction;
                }
            }
            if (found is false)
                throw new ArgumentException("Cannot find ldstr Shader compilation in progress. Remaining shaders to compile:  in TOR_Core.SubModule.OnApplicationTick");
        }
    }
}
