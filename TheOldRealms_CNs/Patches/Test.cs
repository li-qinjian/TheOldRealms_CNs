using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.GameMenus;
using TaleWorlds.CampaignSystem.ViewModelCollection.Party;
using TaleWorlds.Core;
using TaleWorlds.Core.ViewModelCollection.Information;
using TaleWorlds.Localization;
using TaleWorlds.ModuleManager;
using TheOldRealms_CNs.Extensions;
using TOR_Core.AbilitySystem;
using TOR_Core.AbilitySystem.SpellBook;
using TOR_Core.AbilitySystem.Spells;
using TOR_Core.CampaignMechanics.CustomResources;
using TOR_Core.CampaignMechanics.TORCustomSettlement.CustomSettlementMenus;
using TOR_Core.Extensions;
using TOR_Core.Extensions.ExtendedInfoSystem;

namespace TheOldRealms_CNs.Patches
{
    [HarmonyPatch]
    internal class Test
    {
        public Test()
        {

            //var xmlPath = ModuleHelper.GetModuleFullPath("TheOldRealms_CNs") + "ModuleData/tor_custom_xmls/tor_cc_options.xml";
            //new TextObject("{=GJfeZNQc}Shader compilation in progress. Remaining shaders to compile:").ToString();

            //SubModule.CustomStrings.GetValueSafe<string,string>("CustomStrings");


            //var str = this.UnderscoreFirstCharToUpper("_sigmarsProclaimerKeystone");
            //TextObject name = Hero.MainHero.Name;
            //var message = new TextObject("{=30yE54FF}TheOldRealms_CNs Loaded").ToString();
            //MBInformationManager.AddQuickInformation(name.ToString() + , 0, 0, false);
            //new StatItemVM(new TextObject("{=tor_spell_stat_tag_tier_str}Spell Tier: ", null).ToString(), ((SpellCastingLevel)this.SpellTier).toTextObject().ToString());
            //ChivalryLevel chivalryLevel = ChivalryLevel.Chivalrous;
            //var s = new TooltipProperty("我爱你吗", new Func<string>(chivalryLevel.ToTextObject().ToString), 0, false, TooltipProperty.TooltipPropertyFlags.None);
            //new TooltipProperty("Next Rank: ", (chivalryLevel + 1).ToTextObject().ToString(), 0, false, TooltipProperty.TooltipPropertyFlags.None);
            //var s =  new List<string>();
            //var highest = 1;
            //Collection<StatItemVM> statItems = new Collection<StatItemVM>();
            //string labeltxt = "Prayer level: ";
            //PrayerLevel prayerLevel = (PrayerLevel)highest;
            //statItems.Add(new StatItemVM(labeltxt, prayerLevel.ToTextObject().ToString()));

            //HeroExtendedInfo info = new Hero().GetExtendedInfo();
            //var ss =info.SpellCastingLevel.ToTextObject().ToString();
            //var highest2 = 1;
            //Collection<StatItemVM> statItems2 = new Collection<StatItemVM>();
            //string labeltxt2 = "Prayer level2: ";
            //PrayerLevel prayerLevel2 = (PrayerLevel)highest;
            //statItems.Add(new StatItemVM(labeltxt, prayerLevel2.ToString()));
        }

        //private int SpellTier { get; set; } = 1;

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

        //[HarmonyPostfix]
        //[HarmonyPatch(typeof(OakOfAgesMenuLogic), "AddTreeSymbolMenu")]
        //public static void PostfixAddTreeSymbolMenu(CampaignGameStarter starter, OakOfAgesMenuLogic __instance)
        //{
        //    var gameMenuManager = Traverse.Create(starter).Field<GameMenuManager>("_gameMenuManager");
        //    var gameMenu = gameMenuManager.Value.GetGameMenu("oak_of_ages_tree_symbols_menu");
        //    var menuTitleProperty = Traverse.Create(gameMenu).Property<TextObject>("MenuTitle");
        //    menuTitleProperty.Value = new TextObject("{=KinyMyGK}Tree Symbols: Choose one Symbol activated for your party. The Symbols provide strong enhancements, yet they will also provide strong disadvantages. Choose wisely, only one Symbol can be active at once.");

        //    //var TreeSymbols = Traverse.Create<OakOfAgesMenuLogic>().Field<List<dynamic>>("TreeSymbols");
        //    //var UnlockOakUpgrade = Traverse.Create(__instance).Method("UnlockOakUpgrade");
        //    //var UnlockTreeSymbolCondition = Traverse.Create(__instance).Method("UnlockTreeSymbolCondition");
        //    //var OakOfAgeMenuInit = Traverse.Create(__instance).Method("OakOfAgeMenuInit");

        //    //starter.AddGameMenu("oak_of_ages_tree_symbols_menu", "Tree Symbols: Choose one Symbol activated for your party. The Symbols provide strong enhancements, yet they will also provide strong disadvantages. Choose wisely, only one Symbol can be active at once.", new OnInitDelegate((args) => MyOakOfAgeMenuInit(__instance, args)), GameOverlays.MenuOverlayType.None, GameMenu.MenuFlags.None, null);
        //    //MBTextManager.SetTextVariable("TREESYMBOLCHANGECOST", 100);
        //    //MBTextManager.SetTextVariable("TREESYMBOLUNLOCKCOST", 500);
        //    //MBTextManager.SetTextVariable("TREESYMBOLFREEUPGRADE", 400);
        //    //int index = 0;
        //    //using (List<dynamic>.Enumerator enumerator = TreeSymbols.Value.GetEnumerator())
        //    //{
        //    //    while (enumerator.MoveNext())
        //    //    {
        //    //        dynamic symbol = enumerator.Current;
        //    //        starter.AddGameMenuOption("oak_of_ages_tree_symbols_menu", string.Format("treeSymbolMenu_{0}_unlock", index), (string)symbol.UpgradeText.Value,
        //    //            new GameMenuOption.OnConditionDelegate((MenuCallbackArgs args) => { return MyUnlockTreeSymbolCondition(__instance, args, symbol.UpgradeId, symbol.ToolTipText, symbol.Cost, symbol.MinimumLevel); }),
        //    //            new GameMenuOption.OnConsequenceDelegate((MenuCallbackArgs args) =>
        //    //            {
        //    //                MyUnlockOakUpgrade(__instance, symbol.UpgradeId, symbol.Cost);
        //    //            }), false, -1, false, null);
        //    //        //starter.AddGameMenuOption("oak_of_ages_tree_symbols_menu", string.Format("treeSymbolMenu_{0}", index), symbol.ApplyText.Value, (MenuCallbackArgs args) => this.SelectTreeSymbolCondition(args, symbol.UpgradeId, symbol.ToolTipText, 100, true), delegate (MenuCallbackArgs _)
        //    //        //{
        //    //        //    this.SelectTreeSymbolConsequence(symbol.UpgradeId, 100);
        //    //        //}, false, -1, false, null);
        //    //        index++;
        //    //    }
        //    //}
        //    //starter.AddGameMenuOption("oak_of_ages_tree_symbols_menu", "treeSymbolMenu_H", "Remove symbol", (MenuCallbackArgs _) => this.RemoveSymbolCondition(), delegate (MenuCallbackArgs _)
        //    //{
        //    //    this.RemoveSymbolConsequence(true);
        //    //}, false, -1, false, null);
        //    //starter.AddGameMenuOption("oak_of_ages_tree_symbols_menu", "treeSymbolMenu_H", "Magical chalk. {TREESYMBOLFREEUPGRADE}{FORESTHARMONY}", (MenuCallbackArgs args) => this.DefaultUnlockOakUpgradeCondition(args, "WESymbolReduceCosts", 400, new TextObject("Remove Symbol change costs.{newline}{UPGRADEFAILEDREASON}", null), 0), delegate (MenuCallbackArgs _)
        //    //{
        //    //    this.UnlockOakUpgrade("WESymbolReduceCosts", 400);
        //    //}, false, -1, false, null);
        //    //starter.AddGameMenuOption("oak_of_ages_tree_symbols_menu", "treeSymbolMenu_leave", "Leave...", delegate (MenuCallbackArgs args)
        //    //{
        //    //    args.optionLeaveType = GameMenuOption.LeaveType.Leave;
        //    //    return true;
        //    //}, delegate
        //    //{
        //    //    GameMenu.SwitchToMenu("oak_of_ages_menu");
        //    //}, false, -1, false, null);
        //}
    }
}
