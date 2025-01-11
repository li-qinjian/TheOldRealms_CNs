using System.Collections.Generic;

using TaleWorlds.Core;

using HarmonyLib;
using System.Xml;
using TaleWorlds.Library;
using TaleWorlds.MountAndBlade;
using TaleWorlds.Localization;
using TaleWorlds.GauntletUI;

namespace TheOldRealms_CNs
{
    public class SubModule : MBSubModuleBase
    {
        internal static string ModuleName = "TheOldRealms_CNs";

        internal static Dictionary<string, string> CustomStrings = new Dictionary<string, string>();

        internal static string ShadersCompilingString;

        protected override void OnSubModuleLoad()
        {
            base.OnSubModuleLoad();
            var harmony = new Harmony(SubModule.ModuleName);
            harmony.PatchAll();
        }

        protected override void OnSubModuleUnloaded()
        {
            base.OnSubModuleUnloaded();
        }

        protected override void OnBeforeInitialModuleScreenSetAsRoot()
        {
            base.OnBeforeInitialModuleScreenSetAsRoot();

            InformationManager.DisplayMessage(new InformationMessage((new TextObject("{=30yE54FF}TheOldRealms_CNs Loaded")).ToString(), Colors.Green));

            this.InitialCustomsStrings();
        }

        private void InitialCustomsStrings()
        {   if(string.IsNullOrEmpty(ShadersCompilingString))
                ShadersCompilingString = new TextObject("{=GJfeZNQc}Shader compilation in progress. Remaining shaders to compile:").ToString();
            this.PutCustomStringInDictionary("5o5BUr4y", new TextObject("{=5o5BUr4y}Required clan renown: 2").ToString());
            this.PutCustomStringInDictionary("6QmA5K0l", new TextObject("{=6QmA5K0l}Required clan renown: 4").ToString());
            this.PutCustomStringInDictionary("JaEMdu7u", new TextObject("{=JaEMdu7u}Unlocks Dark Magic").ToString());
            this.PutCustomStringInDictionary("zv0Eiz5S", new TextObject("{=zv0Eiz5S}Unlocks 2nd Lore").ToString());
            this.PutCustomStringInDictionary("x2PwiTkd", new TextObject("{=x2PwiTkd}Unlocks Lore of Heavens").ToString());
            this.PutCustomStringInDictionary("S8jyzkTS", new TextObject("{=S8jyzkTS}Unlocks Greater Powerstones").ToString());
            this.PutCustomStringInDictionary("HpyiXD0C", new TextObject("{=HpyiXD0C}Unlocks Mighty Powerstones").ToString());
            this.PutCustomStringInDictionary("Yn0Wvubl", new TextObject("{=Yn0Wvubl}Swiftshiver shards upgrade for troops").ToString());
            this.PutCustomStringInDictionary("Zkgx1XzI", new TextObject("{=Zkgx1XzI}Hagbane Tipps upgrade for troops").ToString());
            this.PutCustomStringInDictionary("yApOnGrj", new TextObject("{=yApOnGrj}Unlocks Starfire shafts").ToString());
        }
        
        private void PutCustomStringInDictionary(string key, string value)
        {
            if (!CustomStrings.ContainsKey(key))
            {
                CustomStrings.Add(key, value);
            }
        }
    }
}
