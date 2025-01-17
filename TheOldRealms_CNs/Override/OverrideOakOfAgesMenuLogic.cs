using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Text;
using TaleWorlds.CampaignSystem.GameMenus;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Localization;
using System.Linq;
using TOR_Core.CampaignMechanics.TORCustomSettlement.CustomSettlementMenus;
using TaleWorlds.Core;

namespace TheOldRealms_CNs.Override
{
    /// <summary>
    /// 不知道为什么，OakOfAgesMenuLogic.AddTreeSymbolMenu方法注入就报错，只能在这里等他初始化好，再改
    /// </summary>
    public class TreeSymbol
    {
        // Token: 0x170002CB RID: 715
        // (get) Token: 0x060015D5 RID: 5589 RVA: 0x0007B5E7 File Offset: 0x000797E7
        // (set) Token: 0x060015D6 RID: 5590 RVA: 0x0007B5EF File Offset: 0x000797EF
        public int Cost { get; set; }

        // Token: 0x170002CC RID: 716
        // (get) Token: 0x060015D7 RID: 5591 RVA: 0x0007B5F8 File Offset: 0x000797F8
        // (set) Token: 0x060015D8 RID: 5592 RVA: 0x0007B600 File Offset: 0x00079800
        public string UpgradeId { get; set; }

        // Token: 0x170002CD RID: 717
        // (get) Token: 0x060015D9 RID: 5593 RVA: 0x0007B609 File Offset: 0x00079809
        // (set) Token: 0x060015DA RID: 5594 RVA: 0x0007B611 File Offset: 0x00079811
        public int MinimumLevel { get; set; }

        // Token: 0x04000CAC RID: 3244
        public TextObject ToolTipText = new TextObject("", null);

        // Token: 0x04000CAD RID: 3245
        public TextObject UpgradeText = new TextObject("", null);

        // Token: 0x04000CAE RID: 3246
        public TextObject ApplyText = new TextObject("", null);
    }

    public class OverrideOakOfAgesMenuLogic
    {
        public OverrideOakOfAgesMenuLogic(CampaignGameStarter campaignGameStarter)
        {
            this.Initialize(campaignGameStarter);
        }

        private static readonly List<TreeSymbol> TreeSymbols = new List<TreeSymbol>
        {
            new TreeSymbol
            {
                UpgradeId = "WEKithbandSymbol",
                Cost = 500,
                MinimumLevel = 0,
                UpgradeText = new TextObject("Decipher the Symbol of the Kithband. {TREESYMBOLUNLOCKCOST}{FORESTHARMONY}", null),
                ApplyText = new TextObject("Apply the Symbol of the Kithband. {TREESYMBOLCHANGECOST}{FORESTHARMONY}", null),
                ToolTipText = new TextObject(GameTexts.FindText("tor_treesymbol_description", "WEKithbandSymbol").Value + "{UPGRADEFAILEDREASON}", null)
            },
            new TreeSymbol
            {
                UpgradeId = "WEWardancerSymbol",
                Cost = 500,
                MinimumLevel = 0,
                UpgradeText = new TextObject("Decipher the Symbol of the Wardancer. {TREESYMBOLUNLOCKCOST}{FORESTHARMONY}", null),
                ApplyText = new TextObject("Apply the Symbol of the Wardancer. {TREESYMBOLCHANGECOST}{FORESTHARMONY}", null),
                ToolTipText = new TextObject(GameTexts.FindText("tor_treesymbol_description", "WEWardancerSymbol").Value + "{UPGRADEFAILEDREASON}", null)
            },
            new TreeSymbol
            {
                UpgradeId = "WETreekinSymbol",
                Cost = 500,
                MinimumLevel = 0,
                UpgradeText = new TextObject("Decipher the Symbol of the Treekin. {TREESYMBOLUNLOCKCOST}{FORESTHARMONY}", null),
                ApplyText = new TextObject("Apply the Symbol of the Treekin. {TREESYMBOLCHANGECOST}{FORESTHARMONY}", null),
                ToolTipText = new TextObject(GameTexts.FindText("tor_treesymbol_description", "WETreekinSymbol").Value + "{UPGRADEFAILEDREASON}", null)
            },
            new TreeSymbol
            {
                UpgradeId = "WEOrionSymbol",
                Cost = 500,
                MinimumLevel = 15,
                UpgradeText = new TextObject("Decipher the Symbol of Orion. {TREESYMBOLUNLOCKCOST}{FORESTHARMONY}", null),
                ApplyText = new TextObject("Apply the Symbol of Orion. {TREESYMBOLCHANGECOST}{FORESTHARMONY}", null),
                ToolTipText = new TextObject(GameTexts.FindText("tor_treesymbol_description", "WEOrionSymbol").Value + "{UPGRADEFAILEDREASON}", null)
            },
            new TreeSymbol
            {
                UpgradeId = "WEArielSymbol",
                Cost = 500,
                MinimumLevel = 15,
                UpgradeText = new TextObject("Decipher the Symbol of Ariel. {TREESYMBOLUNLOCKCOST}{FORESTHARMONY}", null),
                ApplyText = new TextObject("Apply the Symbol of Ariel. {TREESYMBOLCHANGECOST}{FORESTHARMONY}", null),
                ToolTipText = new TextObject(GameTexts.FindText("tor_treesymbol_description", "WEArielSymbol").Value + "{UPGRADEFAILEDREASON}", null)
            },
            new TreeSymbol
            {
                UpgradeId = "WEWandererSymbol",
                Cost = 500,
                MinimumLevel = 15,
                UpgradeText = new TextObject("Decipher the Symbol of the Wanderer.{TREESYMBOLUNLOCKCOST}{FORESTHARMONY}", null),
                ApplyText = new TextObject("Apply the Symbol of the Wanderer. {TREESYMBOLCHANGECOST}{FORESTHARMONY}", null),
                ToolTipText = new TextObject(GameTexts.FindText("tor_treesymbol_description", "WEWandererSymbol").Value + "{UPGRADEFAILEDREASON}", null)
            },
            new TreeSymbol
            {
                UpgradeId = "WEDurthuSymbol",
                Cost = 500,
                MinimumLevel = 20,
                UpgradeText = new TextObject("Decipher the Symbol of Durthu.{TREESYMBOLUNLOCKCOST}{FORESTHARMONY}", null),
                ApplyText = new TextObject("Apply the Symbol of Durthu. {TREESYMBOLCHANGECOST}{FORESTHARMONY}", null),
                ToolTipText = new TextObject(GameTexts.FindText("tor_treesymbol_description", "WEDurthuSymbol").Value + "{UPGRADEFAILEDREASON}", null)
            }
        };

        private void Initialize(CampaignGameStarter campaignGameStarter)
        {
            var gameMenuManager = Traverse.Create(campaignGameStarter).Field<GameMenuManager>("_gameMenuManager");
            GameMenu gameMenu = gameMenuManager.Value.GetGameMenu("oak_of_ages_tree_symbols_menu");
            var menuTitleProperty = Traverse.Create(gameMenu).Field<TextObject>("_defaultText");
            menuTitleProperty.Value = new TextObject("{=KinyMyGK}Tree Symbols: Choose one Symbol activated for your party. The Symbols provide strong enhancements, yet they will also provide strong disadvantages. Choose wisely, only one Symbol can be active at once.");

            var menuItems = Traverse.Create(gameMenu).Field<List<GameMenuOption>>("_menuItems");

            for (var i = 0; i < TreeSymbols.Count; i++)
            {
                var treeSymbol = TreeSymbols[i]; 

                var menuItem_unlock = menuItems.Value.LastOrDefault<GameMenuOption>(gameMenuOption => gameMenuOption.IdString == $"treeSymbolMenu_{i}_unlock");
                var menuItem_unlockTextProperty = Traverse.Create(menuItem_unlock).Property<TextObject>("Text");
                var menuItem_unlockText2Property = Traverse.Create(menuItem_unlock).Property<TextObject>("Text2");
                menuItem_unlockTextProperty.Value = menuItem_unlockText2Property.Value = new TextObject(string.Format("{{={0}}}{1}", $"tor_treeSymbolMenu_{i}_unlock_str", treeSymbol.UpgradeText.Value));

                var menuItem = menuItems.Value.LastOrDefault<GameMenuOption>(gameMenuOption => gameMenuOption.IdString == $"treeSymbolMenu_{i}");
                var menuItemTextProperty = Traverse.Create(menuItem).Property<TextObject>("Text");
                var menuItemText2Property = Traverse.Create(menuItem).Property<TextObject>("Text2");
                menuItemTextProperty.Value = menuItemText2Property.Value = new TextObject(string.Format("{{={0}}}{1}", $"tor_treeSymbolMenu_{i}_str", treeSymbol.ApplyText.Value));
            }

            var menuItem_treeSymbolMenu_H = menuItems.Value.FirstOrDefault<GameMenuOption>(gameMenuOption => gameMenuOption.IdString == "treeSymbolMenu_H");
            var menuItem_treeSymbolMenu_HTextProperty = Traverse.Create(menuItem_treeSymbolMenu_H).Property<TextObject>("Text");
            var menuItem_treeSymbolMenu_HText2Property = Traverse.Create(menuItem_treeSymbolMenu_H).Property<TextObject>("Text2");
            menuItem_treeSymbolMenu_HTextProperty.Value = menuItem_treeSymbolMenu_HText2Property.Value = new TextObject("{=DERcfqv4}Remove symbol");

            var menuItem_treeSymbolMenu_H_2 = menuItems.Value.LastOrDefault<GameMenuOption>(gameMenuOption => gameMenuOption.IdString == "treeSymbolMenu_H");
            var menuItem_treeSymbolMenu_H_2TextProperty = Traverse.Create(menuItem_treeSymbolMenu_H_2).Property<TextObject>("Text");
            var menuItem_treeSymbolMenu_H_2Text2Property = Traverse.Create(menuItem_treeSymbolMenu_H_2).Property<TextObject>("Text2");
            menuItem_treeSymbolMenu_H_2TextProperty.Value = menuItem_treeSymbolMenu_H_2Text2Property.Value = new TextObject("{=Hvg8XhRh}Remove symbol");

            var menuItem_Leave = menuItems.Value.LastOrDefault<GameMenuOption>(gameMenuOption => gameMenuOption.IdString == "treeSymbolMenu_leave");
            var menuItem_LeaveTextProperty = Traverse.Create(menuItem_Leave).Property<TextObject>("Text");
            var menuItem_LeaveText2Property = Traverse.Create(menuItem_Leave).Property<TextObject>("Text2");
            menuItem_LeaveTextProperty.Value = menuItem_LeaveText2Property.Value = new TextObject("{=13Vft5qv}Leave...");
        }
    }
}
