using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Text;
using TaleWorlds.Localization;
using TaleWorlds.ModuleManager;

namespace TheOldRealms_CNs.Patches
{
    internal class Test
    {
        public Test()
        {
            //var xmlPath = ModuleHelper.GetModuleFullPath("TheOldRealms_CNs") + "ModuleData/tor_custom_xmls/tor_cc_options.xml";
            //new TextObject("{=GJfeZNQc}Shader compilation in progress. Remaining shaders to compile:").ToString();

            SubModule.CustomStrings.GetValueSafe<string,string>("CustomStrings");


            //var str = this.UnderscoreFirstCharToUpper("_sigmarsProclaimerKeystone");
        }

        //public string UnderscoreFirstCharToUpper(this string input)
        //{
        //    if (input == null)
        //    {
        //        throw new ArgumentNullException("input");
        //    }
        //    if (!(input == ""))
        //    {
        //        return input[1].ToString().ToUpper() + input.Substring(2);
        //    }
        //    throw new ArgumentException("input cannot be empty", "input");
        //}
    }
}
