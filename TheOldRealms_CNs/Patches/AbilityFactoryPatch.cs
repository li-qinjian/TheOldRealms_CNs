using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using TaleWorlds.ModuleManager;
using TOR_Core.AbilitySystem;
using TOR_Core.Utilities;

namespace TheOldRealms_CNs.Patches
{
    /// <summary>
    /// 在TOR_Core加载之后加载本MOD，会导致TOR_Core中的静态方法，preifx及postfix无法被调用，如果将本MOD放在TOR_Core之前加载，则会导致本MOD覆盖TOR_Core的内容，无法正确覆盖。所以只能通过Transpiler的方式修改TOR_Core的内容，然后在本MOD PatchAll之后，再调用TORMOD中的LoadXML函数
    /// </summary>
    [HarmonyPatch]
    internal class AbilityFactoryPatch
    {
        private static string XMLPath = ModuleHelper.GetModuleFullPath(SubModule.ModuleName) + "ModuleData/tor_custom_xmls/";

        //[HarmonyPrefix]
        //[HarmonyPatch(typeof(AbilityFactory), nameof(AbilityFactory.LoadTemplates))]
        //public static bool Prefix()
        //{
        //    XmlSerializer ser = new XmlSerializer(typeof(List<AbilityTemplate>), new XmlRootAttribute("AbilityTemplates"));
        //    if (File.Exists(XMLPath))
        //    {
        //        var templates = Traverse.Create<AbilityFactory>().Field<Dictionary<string, AbilityTemplate>>("_templates");

        //        foreach (AbilityTemplate item in (ser.Deserialize(File.OpenRead(XMLPath)) as List<AbilityTemplate>))
        //        {
        //            templates.Value.Add(item.StringID, item);
        //        }
        //    }
        //    return false;
        //}


        [HarmonyTranspiler]
        [HarmonyPatch(typeof(AbilityFactory), "LoadTemplates")]
        public static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions /*, ILGenerator generator*/)
        {
            var TORCoreModuleExtendedDataPath = AccessTools.PropertyGetter(typeof(TORPaths), "TORCoreModuleExtendedDataPath");
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Call && instruction.operand == (object)TORCoreModuleExtendedDataPath)
                {
                    yield return new CodeInstruction(OpCodes.Ldstr, XMLPath);

                    found = true;
                }
                else
                {
                    yield return instruction;
                }
            }
            if (found is false)
                throw new ArgumentException("Cannot find TOR_Core.Utilities.TORPaths::get_TORCoreModuleExtendedDataPath() in AbilityFactory.LoadTemplates");
        }
    }
}
