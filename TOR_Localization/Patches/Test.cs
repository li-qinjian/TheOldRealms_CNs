using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Text;
using TaleWorlds.Localization;
using TaleWorlds.ModuleManager;

namespace TOR_Localization.Patches
{
    internal class Test
    {
        public Test()
        {
            //var xmlPath = ModuleHelper.GetModuleFullPath("TheOldRealms_CNs") + "ModuleData/tor_custom_xmls/tor_cc_options.xml";
            //new TextObject("{=GJfeZNQc}Shader compilation in progress. Remaining shaders to compile:").ToString();

            SubModule.CustomStrings.GetValueSafe<string,string>("CustomStrings");
        }
    }
}
