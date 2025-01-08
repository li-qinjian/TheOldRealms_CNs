using System.Collections.Generic;

using TaleWorlds.Core;

using HarmonyLib;
using System.Xml;
using TaleWorlds.Library;
using TaleWorlds.MountAndBlade;
using TaleWorlds.Localization;

namespace TOR_Localization
{
    public class SubModule : MBSubModuleBase
    {
        protected override void OnSubModuleLoad()
        {
            base.OnSubModuleLoad();
            var harmony = new Harmony("TOR_Localization");
            harmony.PatchAll();
        }

        protected override void OnSubModuleUnloaded()
        {
            base.OnSubModuleUnloaded();
        }

        protected override void OnBeforeInitialModuleScreenSetAsRoot()
        {
            base.OnBeforeInitialModuleScreenSetAsRoot();
            InformationManager.DisplayMessage(new InformationMessage(((object)new TextObject("中古战锤汉化加载成功", (Dictionary<string, object>)null)).ToString(), Colors.Green));
        }
    }
}
