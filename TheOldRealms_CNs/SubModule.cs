using System.Collections.Generic;

using TaleWorlds.Core;

using HarmonyLib;
using System.Xml;
using TaleWorlds.Library;
using TaleWorlds.MountAndBlade;
using TaleWorlds.Localization;
using TaleWorlds.GauntletUI;
using TOR_Core.AbilitySystem;
using TheOldRealms_CNs.Extensions;
using TOR_Core.Ink;
using TOR_Core.Items;

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

            this.ReInitializeTORModule();
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

        private void ReInitializeTORModule()
        {
            var templates = Traverse.Create<AbilityFactory>().Field<Dictionary<string, AbilityTemplate>>("_templates");
            templates.Value.Clear();
            AbilityFactory.LoadTemplates();

            var inkStoryManagerInstance = Traverse.Create<InkStoryManager>().Field<InkStoryManager>("_instance");
            var loadStories = Traverse.Create(inkStoryManagerInstance.Value).Method("LoadStories");
            loadStories.GetValue();

            var _itemToInfoMap = Traverse.Create(typeof(ExtendedItemObjectManager)).Field<Dictionary<string, ExtendedItemObjectProperties>>("_itemToInfoMap");
            _itemToInfoMap.Value.Clear();
            ExtendedItemObjectManager.LoadXML();
        }

        private void InitialCustomsStrings()
        {   if(string.IsNullOrEmpty(ShadersCompilingString))
                ShadersCompilingString = new TextObject("{=GJfeZNQc}Shader compilation in progress. Remaining shaders to compile:").ToString();
            this.AddCustomStringToDictionary("5o5BUr4y", new TextObject("{=5o5BUr4y}Required clan renown: 2").ToString());
            this.AddCustomStringToDictionary("6QmA5K0l", new TextObject("{=6QmA5K0l}Required clan renown: 4").ToString());
            this.AddCustomStringToDictionary("JaEMdu7u", new TextObject("{=JaEMdu7u}Unlocks Dark Magic").ToString());
            this.AddCustomStringToDictionary("zv0Eiz5S", new TextObject("{=zv0Eiz5S}Unlocks 2nd Lore").ToString());
            this.AddCustomStringToDictionary("x2PwiTkd", new TextObject("{=x2PwiTkd}Unlocks Lore of Heavens").ToString());
            this.AddCustomStringToDictionary("S8jyzkTS", new TextObject("{=S8jyzkTS}Unlocks Greater Powerstones").ToString());
            this.AddCustomStringToDictionary("HpyiXD0C", new TextObject("{=HpyiXD0C}Unlocks Mighty Powerstones").ToString());
            this.AddCustomStringToDictionary("Yn0Wvubl", new TextObject("{=Yn0Wvubl}Swiftshiver shards upgrade for troops").ToString());
            this.AddCustomStringToDictionary("Zkgx1XzI", new TextObject("{=Zkgx1XzI}Hagbane Tipps upgrade for troops").ToString());
            this.AddCustomStringToDictionary("yApOnGrj", new TextObject("{=yApOnGrj}Unlocks Starfire shafts").ToString());
        }
        
        private void AddCustomStringToDictionary(string key, string value)
        {
            if (!CustomStrings.ContainsKey(key))
            {
                CustomStrings.Add(key, value);
            }
        }
    }
}
