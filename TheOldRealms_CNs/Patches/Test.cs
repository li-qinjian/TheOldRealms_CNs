using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using TaleWorlds.CampaignSystem;
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
using TOR_Core.Extensions;
using TOR_Core.Extensions.ExtendedInfoSystem;

namespace TheOldRealms_CNs.Patches
{
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
    }
}
