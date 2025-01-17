//using HarmonyLib;
//using System;
//using System.Collections.Generic;
//using System.Text;
//using TaleWorlds.CampaignSystem;
//using TaleWorlds.CampaignSystem.GameMenus;
//using TaleWorlds.Localization;
//using TOR_Core.CampaignMechanics.TORCustomSettlement.CustomSettlementMenus;

//namespace TheOldRealms_CNs.Behavior
//{
//    internal class TheOldRealmsCNsBehavior : CampaignBehaviorBase
//    {
//        public override void RegisterEvents()
//        {
//            CampaignEvents.OnSessionLaunchedEvent.AddNonSerializedListener(this, new Action<CampaignGameStarter>(this.OnSessionLaunched));
//        }

//        private void OnSessionLaunched(CampaignGameStarter starter)
//        {
//            var gameMenuManager = Traverse.Create(starter).Field<GameMenuManager>("_gameMenuManager");
//            var gameMenu = gameMenuManager.Value.GetGameMenu("oak_of_ages_tree_symbols_menu");
//            var menuTitleProperty = Traverse.Create(gameMenu).Property<TextObject>("MenuTitle");
//            menuTitleProperty.Value = new TextObject("{=KinyMyGK}Tree Symbols: Choose one Symbol activated for your party. The Symbols provide strong enhancements, yet they will also provide strong disadvantages. Choose wisely, only one Symbol can be active at once.");
//        }

//        public override void SyncData(IDataStore dataStore)
//        {
//        }
//    }
//}
