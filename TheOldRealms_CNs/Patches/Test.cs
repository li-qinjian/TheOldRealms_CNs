using System;
using System.Collections.Generic;
using System.Text;
using TaleWorlds.ModuleManager;

namespace TOR_Localization.Patches
{
    internal class Test
    {
        public Test()
        {
            var xmlPath = ModuleHelper.GetModuleFullPath("TheOldRealms_CNs") + "ModuleData/tor_custom_xmls/tor_cc_options.xml";
        }
    }
}
