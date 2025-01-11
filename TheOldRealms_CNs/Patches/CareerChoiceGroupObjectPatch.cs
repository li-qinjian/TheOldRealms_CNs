using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using TaleWorlds.CampaignSystem;
using TOR_Core.CharacterDevelopment.CareerSystem;
using TOR_Core.Items;

namespace TheOldRealms_CNs.Patches
{
    [HarmonyPatch]
    internal class CareerChoiceGroupObjectPatch
    {
        [HarmonyPrefix]
        [HarmonyPatch(typeof(CareerChoiceGroupObject), "GetConditionText")]
        public static bool Prefix1(Hero hero, ref string __result, CareerChoiceGroupObject.ConditionDelegate ____conditionDelegate)
        {
            string result = "Condition not found.";
            if (____conditionDelegate != null)
            {
                ____conditionDelegate(hero, out result);

                switch (result)
                {
                    case "Required clan renown: 2":
                        result = SubModule.CustomStrings.GetValueSafe<string, string>("5o5BUr4y");
                        break;
                    case "Required clan renown: 4":
                        result = SubModule.CustomStrings.GetValueSafe<string, string>("6QmA5K0l");
                        break;
                    default:
                        break;
                }

            }
            __result = result;
            return false;
        }

        [HarmonyPrefix]
        [HarmonyPatch(typeof(CareerChoiceGroupObject), "GetUnlockText")]
        public static bool Prefix2(Hero hero, ref string __result, CareerChoiceGroupObject.UnlockDelegate ____unlockDelegate)
        {
            string result = "";

            if (____unlockDelegate != null)
            {
                ____unlockDelegate(hero, out result);

                switch (result)
                {
                    case "Unlocks Dark Magic":
                        result = SubModule.CustomStrings.GetValueSafe<string, string>("5o5BUr4y");
                        break;
                    case "Unlocks 2nd Lore":
                        result = SubModule.CustomStrings.GetValueSafe<string, string>("zv0Eiz5S");
                        break;
                    case "Unlocks Lore of Heavens":
                        result = SubModule.CustomStrings.GetValueSafe<string, string>("x2PwiTkd");
                        break;
                    case "Unlocks Greater Powerstones":
                        result = SubModule.CustomStrings.GetValueSafe<string, string>("S8jyzkTS");
                        break;
                    case "Unlocks Mighty Powerstones":
                        result = SubModule.CustomStrings.GetValueSafe<string, string>("HpyiXD0C");
                        break;
                    case "Swiftshiver shards upgrade for troops":
                        result = SubModule.CustomStrings.GetValueSafe<string, string>("Yn0Wvubl");
                        break;
                    case "Hagbane Tipps upgrade for troops":
                        result = SubModule.CustomStrings.GetValueSafe<string, string>("Zkgx1XzI");
                        break;
                    case "Unlocks Starfire shafts":
                        result = SubModule.CustomStrings.GetValueSafe<string, string>("yApOnGrj");
                        break;
                    default:
                        break;
                }

            }
            __result = result;
            return false;
        }
    }
}
