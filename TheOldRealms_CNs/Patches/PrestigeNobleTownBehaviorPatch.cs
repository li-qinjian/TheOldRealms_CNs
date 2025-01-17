using HarmonyLib;
using Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Localization;
using TaleWorlds.ObjectSystem;
using TOR_Core.AbilitySystem.Spells.Prayers;
using TOR_Core.CampaignMechanics.Menagery;
using TOR_Core.Extensions;

namespace TheOldRealms_CNs.Patches
{
    [HarmonyPatch]
    internal class PrestigeNobleTownBehaviorPatch
    {
        [HarmonyTranspiler]
        [HarmonyPatch(typeof(PrestigeNobleTownBehavior), "SelectDemiGryphen")]
        public static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions /*, ILGenerator generator*/)
        {
            var found = false;
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldstr)
                {
                    var stringOperand = instruction.operand.ToString();
                    switch (stringOperand)
                    {
                        case "Choose your demigryph!":
                            var codeInstruction = new CodeInstruction(OpCodes.Ldstr, "{=DskvrbLy}Choose your demigryph!");
                            codeInstruction.labels.AddRange(instruction.labels);
                            codeInstruction.blocks.AddRange(instruction.blocks);
                            yield return codeInstruction;
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "The Noble offers you his service, one of his demi gryphens he kept in the menagerie is available to you.":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=cp867vwt}The Noble offers you his service, one of his demi gryphens he kept in the menagerie is available to you.");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        case "OK":
                            yield return new CodeInstruction(OpCodes.Ldstr, "{=APcnKMgv}OK");
                            yield return new CodeInstruction(OpCodes.Ldnull);
                            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
                            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));
                            found = true;
                            break;
                        default:
                            yield return instruction;
                            break;
                    }
                    found = true;
                }
                else
                {
                    yield return instruction;
                }
            }
            if (found is false)
                throw new ArgumentException("Cannot find ldstr 'Choose your demigryph!' in PrestigeNobleTownBehavior.SelectDemiGryphen");
        }

        [HarmonyPrefix]
        [HarmonyPatch(typeof(PrestigeNobleTownBehavior), "OnSessionLaunched")]
        public static bool PrefixOnSessionLaunched(CampaignGameStarter obj, PrestigeNobleTownBehavior __instance)
        {
            var methodNameOfInitializeVariables = Traverse.Create(__instance).Methods().FirstOrDefault<string>(methodName => methodName.Contains("InitializeVariables"));
            var InitializeVariables = Traverse.Create<PrestigeNobleTownBehavior>().Method(methodNameOfInitializeVariables);
            InitializeVariables.GetValue();

            var methodNameOfEmpirePrestigeNobleStartCondition = Traverse.Create(__instance).Methods().FirstOrDefault<string>(methodName => methodName.Contains("EmpirePrestigeNobleStartCondition"));
            var EmpirePrestigeNobleStartCondition = Traverse.Create<PrestigeNobleTownBehavior>().Method(methodNameOfEmpirePrestigeNobleStartCondition);

            var IsPartOfEmpire = Traverse.Create(__instance).Method("IsPartOfEmpire");
            var HasRenown2 = Traverse.Create(__instance).Method("HasRenown2");
            var _knowsPlayer = Traverse.Create(__instance).Field<bool>("_knowsPlayer");

            obj.AddDialogLine("noble_foreign", "start", "close_window", new TextObject("{=X4LBsLaO}You do not serve the Empire stranger, begone.").ToString(), () => EmpirePrestigeNobleStartCondition.GetValue<bool>() && !IsPartOfEmpire.GetValue<bool>(), null, 200);
            obj.AddDialogLine("noble_missRank", "start", "close_window", new TextObject("{=0YIMCTQ6}I do not do business with nobodies’ stranger, and I do not know you. Now begone. (Low Renown).").ToString(), () => EmpirePrestigeNobleStartCondition.GetValue<bool>() && !HasRenown2.GetValue<bool>(), null, 200);
            obj.AddDialogLine("noble_introduction_1", "start", "noble_introduction_2", new TextObject("{=reHQ3AzZ}It is a pleasure to make your acquaintance, I am Lord Berthold Wendehals. You have been making quite a name for yourself it would seem, many amongst the Imperial courts know of your exploits.").ToString(), () => !_knowsPlayer.Value && EmpirePrestigeNobleStartCondition.GetValue<bool>(), null, 200);
            obj.AddDialogLine("noble_introduction_2", "noble_introduction_2", "noble_introduction_3", new TextObject("{=pkqYp8hB}I make it my business to know important, and useful, people. Connections are my trade you see, I do believe a relationship between us could prove to be very lucrative.").ToString(), () => !_knowsPlayer.Value, null, 200);
            obj.AddDialogLine("noble_introduction_3", "noble_introduction_3", "prestige_noble_main_hub", new TextObject("{=8E21Zzmi}I can help you further your power and influence within the courts of the Empire and all I ask in return is that you return the favour when needed.").ToString(), () => !_knowsPlayer.Value, delegate
            {
                _knowsPlayer.Value = true;
            }, 200);
            obj.AddDialogLine("noble_hub_intro", "start", "prestige_noble_main_hub", new TextObject("{=0ByZ4WiN}There are a number of projects that could be of interest to you. What should we consider?").ToString(), () => EmpirePrestigeNobleStartCondition.GetValue<bool>() && _knowsPlayer.Value, null, 200);
            obj.AddDialogLine("noble_hub_intro", "noble_hub_intro2", "prestige_noble_main_hub", new TextObject("{=ilghwzDN}Is there something else what I can do for you?").ToString(), () => EmpirePrestigeNobleStartCondition.GetValue<bool>() && _knowsPlayer.Value, null, 200);
            obj.AddPlayerLine("prestige_items", "prestige_noble_main_hub", "noble_prestige_items_intro", new TextObject("{=28D3NqMt}Are there any items of interest you might have for me?").ToString(), null, null, 200);
            InitPrestigeItemDialog(obj, __instance);
            obj.AddPlayerLine("infrastructure_projects", "prestige_noble_main_hub", "noble_prestige_infrastructure_hub", new TextObject("{=yKHtQwkx}I would like to invest in infrastructure, what are my options?").ToString(), null, null, 200);
            InitInfrastructureProjectsDialog(obj, __instance);
            obj.AddPlayerLine("influence_projects", "prestige_noble_main_hub", "noble_prestige_political_power_hub", new TextObject("{=Hm9kyZDu}I have an interest in the many organisations of the Empire, are there any who I could aid?").ToString(), null, null, 200);
            InitPoliticalPowerProjects(obj, __instance);
            obj.AddPlayerLine("influence_projects", "prestige_noble_main_hub", "close_window", new TextObject("{=EitZwuRG}Thanks, I will come back to you.").ToString(), null, null, 200);

            return false;
        }

        static void InitPrestigeItemDialog(CampaignGameStarter obj, PrestigeNobleTownBehavior __instance)
        {
            obj.AddDialogLine("noble_prestige_items_intro", "noble_prestige_items_intro", "noble_prestige_item_hub", new TextObject("{=YMcRiZfG}Hmm.. currently there is only one thing I have on hand, but it is very unique. A beast from the Imperial Menagerie, should you be interested?").ToString(), null, null, 200);
            obj.AddPlayerLine("noble_prestige_item_selection_mount", "noble_prestige_item_hub", "noble_prestige_item_explain_mount", new TextObject("{=MouwZnD1}What sort of beast?").ToString(), null, null, 200);
            obj.AddPlayerLine("prestige_item_noble_hub_selection_back", "noble_prestige_item_hub", "noble_hub_intro2", new TextObject("{=tNxwSIzf}Maybe something different.(back)").ToString(), null, null, 200);
            InitSelectionMount(obj, __instance);
        }

        static void InitSelectionMount(CampaignGameStarter obj, PrestigeNobleTownBehavior __instance)
        {
            //var methodNameOfHasEnoughPrestigeForMount = Traverse.Create(__instance).Methods().FirstOrDefault<string>(methodName => methodName.Contains("HasEnoughPrestigeForMount"));
            //var HasEnoughPrestigeForMount = Traverse.Create<PrestigeNobleTownBehavior>().Method(methodNameOfHasEnoughPrestigeForMount);
       

            var SelectDemiGryphen = Traverse.Create(__instance).Method("SelectDemiGryphen");
            
            obj.AddDialogLine("noble_prestige_item_explain_mount", "noble_prestige_item_explain_mount", "noble__prestige_item_choice", new TextObject("{=UKRx0qt1}Due to some rather unfortunate circumstances, we have a monstrous steed without a rider. A Demigryph, to be precise. While the rider will be missed, the keeper of the Imperial Menagerie doesn't know what to do with it. Luckily, I have contacts within the Order of the fallen Knight and they may be willing to entrust the mount to you... ({1000}{PRESTIGE_ICON})").ToString(), null, null, 200);
            obj.AddPlayerLine("noble__prestige_item_choice_agree", "noble__prestige_item_choice", "noble_hub_intro2", new TextObject("{=N2sTSXQz}Price is no issue, such a mighty steed would be worth it. ({PRESTIGE_COST}{PRESTIGE_ICON}) ").ToString(), () => HasEnoughPrestigeForMount(), () => SelectDemiGryphen.GetValue(), 200);
            obj.AddPlayerLine("noble_prestige_item_choice_decline", "noble__prestige_item_choice", "noble_hub_intro2", new TextObject("{=VquLZAMx}Not at this time, perhaps later.").ToString(), null, null, 200);
        }

        static void InitInfrastructureProjectsDialog(CampaignGameStarter obj, PrestigeNobleTownBehavior __instance)
        {
            var _constructedBuildings = Traverse.Create(__instance).Field<List<string>>("_constructedBuildings");
            //var methodNameOfHasEnoughGold =  Traverse.Create(__instance).Methods().FirstOrDefault<string>(methodName => methodName.Contains("HasEnoughGold"));
            //var HasEnoughGold = Traverse.Create<PrestigeNobleTownBehavior>().Method(methodNameOfHasEnoughGold);


            //var methodNameOfStartTransaction = Traverse.Create(__instance).Methods().FirstOrDefault<string>(methodName => methodName.Contains("StartTransaction"));
            //var StartTransaction = Traverse.Create<PrestigeNobleTownBehavior>().Method(methodNameOfStartTransaction);


            obj.AddDialogLine("noble_prestige_infrastructure_hub", "noble_prestige_infrastructure_hub", "noble_prestige_infrastructure_hub_selection", new TextObject("{=zMoYOYNL}An interesting choice, there are a number of projects slated for the future...but with the right amount of coin I can ensure you are known as the magnimonous benefactor behind their expedited construction.").ToString(), null, null, 200);
            string text3 = "noble_prestige_building_selection_";
            string text4 = "noble_prestige_building_explain_";
            string[] array3 = new string[5] { new TextObject("{=HqaxWOly}[Dedicate a statue to Sigmar Heldenhammer]").ToString(), new TextObject("{=GYmDGH1Z}[Help fund the construction of a Temple of Shallya]").ToString(), new TextObject("{=caCAJrRd}[Construct a new dry dock]").ToString(), new TextObject("{=fd7b5xox}[Imperial Training Grounds]").ToString(), new TextObject("{=tD97rblE}[Renovate the Heldenhammer]").ToString() };
            int[] buildingCosts = new int[5] { 200000, 400000, 500000, 250000, 500000 };
            string[] array4 = new string[5]
            {
                new TextObject("{=6xGrtNNA}The Cult of Sigmar within Altdorf has ambitions to build a rather sizeable statue of our most glorious Sigmar, upon a hill with a prestigous view of his beloved Empire. They are lacking in some funding to ensure it's timely completion, I can ensure your name is written upon such a wondrous memorial for a measly cost. (200000 {GOLD_ICON})").ToString(),
                new TextObject("{=fFBJgMfX}There are many who suffer across the Empire and Shallya's priestesses are needed more than ever, however funding a Temple to the Lady in White is no small endeavour. You can be sure that, for a little coin, your name will be praised for generations for aiding in such a selfless act.(400000 {GOLD_ICON})").ToString(),
                new TextObject("{=LH9dd0Q0}The threat we face from Norsca is ever present, the Elector Count of Nordland has called for the construction of a new dry dock to empower the Imperial Navy. It has already been funded by the local lords...however for a little extra I can ensure you are known as the prime contributor. (500000 {GOLD_ICON})").ToString(),
                new TextObject("{=6iIPCNGF}The forests and the hills of the Empire need constant patrols to ensure the safety of it's citizens, one of the local garrisons is in dire need of training equipment and you have an opportunity to provide it for them. (250000 {GOLD_ICON})").ToString(),
                new TextObject("{=FOhuFJhN}It takes a lot of coin to keep the mighty Heldenhammer afloat, the Grand Theogonist and the Cult of Sigmar will look very favourably upon any who donate to ensure it is battle ready at all times. (500000 {GOLD_ICON})").ToString()
            };
            for (int j = 0; j < buildingCosts.Length; j++)
            {
                int index2 = j;
                obj.AddPlayerLine(text3 + index2, "noble_prestige_infrastructure_hub_selection", text4 + index2, array3[index2], () => !_constructedBuildings.Value.Any((string x) => x.Contains("building" + index2)), null, 200);
                obj.AddDialogLine(text4 + j, text4 + j, $"buildingPrestigeSelection{index2}_choice", array4[index2], null, null, 200);
                obj.AddPlayerLine($"noble_prestige_item_selection_building_{index2}_agree", $"buildingPrestigeSelection{index2}_choice", "noble_hub_intro2", string.Format("{0} {1} {{GOLD_ICON}}", new TextObject("{=h3wvI1aQ}That sounds good, I will send you the funding. ").ToString(), buildingCosts[index2]), () => HasEnoughGold(buildingCosts[index2]), delegate
                {
                    StartTransaction(buildingCosts[index2], index2, _constructedBuildings.Value);
                }, 200);
                obj.AddPlayerLine($"noble_prestige_item_selection_building_{index2}_decline", $"buildingPrestigeSelection{index2}_choice", "noble_hub_intro2", new TextObject("{=C3QfgQdT}Not at this time, perhaps later.").ToString(), null, null, 200);
            }

            obj.AddPlayerLine("noble_prestige_infrastructure_hub_back", "noble_prestige_infrastructure_hub_selection", "noble_hub_intro2", new TextObject("{=N1jGtwBa}Maybe something different.(back)").ToString(), null, null, 200);
        }

        static void InitPoliticalPowerProjects(CampaignGameStarter obj, PrestigeNobleTownBehavior __instance)
        {
            var _politicalPowerProjects = Traverse.Create(__instance).Field<List<string>>("_politicalPowerProjects");

            //var methodNameOfHasEnoughInfluence = Traverse.Create(__instance).Methods().FirstOrDefault<string>(methodName => methodName.Contains("HasEnoughInfluence"));
            //var HasEnoughInfluence = Traverse.Create<PrestigeNobleTownBehavior>().Method(methodNameOfHasEnoughInfluence);

            //var methodNameOfExchangeInfluenceForPrestige = Traverse.Create(__instance).Methods().FirstOrDefault<string>(methodName => methodName.Contains("ExchangeInfluenceForPrestige"));
            //var ExchangeInfluenceForPrestige = Traverse.Create<PrestigeNobleTownBehavior>().Method(methodNameOfExchangeInfluenceForPrestige);

            string text = "noble_prestige_power_projects_selection_";
            string text2 = "noble_prestige_explain_selection_";
            int num = 4;
            string[] array = new string[4] 
            {
                new TextObject("{=DULzdF8h}[Find support for a diplomatic mission to Ulthuan to establish a new trade route.]").ToString(),
                new TextObject("{=y5ngGp7B}[Support the Traders Guild envoy on a mission to establish gunpowder trade with Cathay]").ToString(), 
                new TextObject("{=YoH81dFT}[Support the Engineers Guild technological innovation.]").ToString(),
                new TextObject("{=GLqYf3hm}[Help fund a Huntsmen Expedition to Lustria]").ToString()
            };
            int[] costs = new int[4] { 200, 400, 200, 400 };
            string[] array2 = new string[4]
            {
                new TextObject("{=zUxwTAos}A diplomatic mission is set to leave for Ulthuan, but they fear they are lacking in gifts elegent enough to appease the knife ears...elves. Perhaps you could help them? (200 {INFLUENCE_ICON})").ToString(),
                new TextObject("{=rE1VChys}It is with faith, steel and gunpowder that we protect the Empire and we need a lot of gunpowder. Cathay also also makes use of black powder and in a hope to bring our two peoples closer, the Trade Guild has sent an envoy to establish trade ties. Some Elector Counts are not convinced yet. (400 {INFLUENCE_ICON)})").ToString(),
                new TextObject("{=onED4gTM}The wonders of the Engineers Guild are many but they are equally as costly to invent, test and so forth. Funding their experimental endeavours would earn you an ample amount of public opinion. (200 {INFLUENCE_ICON})").ToString(),
                new TextObject("{=P5P3mZu9}Beasts are myriad within the jungles of Lustria, the Huntsmen are set to go on a hunt soon but could use help acquiring provisions for such an arduous journey. ({costs[3]} {INFLUENCE_ICON})").ToString()
            };
            obj.AddDialogLine("noble_prestige_infrastructure_hub", "noble_prestige_political_power_hub", "noble_prestige_political_power_hub_selection", new TextObject("{=81h5aB1D}Many parties and organisations throught the empire need your support. Are you willing to provide them the power they need?").ToString(), null, null, 200);
            for (int i = 0; i < num; i++)
            {
                int index = i;
                obj.AddPlayerLine(text + index, "noble_prestige_political_power_hub_selection", text2 + index, array[index], () => !_politicalPowerProjects.Value.Any((string x) => x.Contains("powerProject" + index)), null, 200);
                obj.AddDialogLine(text2 + index, text2 + index, $"powerSelection{index}_choice", array2[index], null, null, 200);
                obj.AddPlayerLine($"powerSelection_choice{index}_agree", $"powerSelection{index}_choice", "noble_hub_intro2", string.Format("{0} {1} {{INFLUENCE_ICON}}",new TextObject("{=qEv9OOps}This sounds good, I will support this.").ToString(), costs[index]), () => HasEnoughInfluence(costs[index]), delegate
                {
                    ExchangeInfluenceForPrestige(costs[index], costs[index]);
                    _politicalPowerProjects.Value.Add("powerProject" + index);
                }, 200);
                obj.AddPlayerLine($"powerSelection_choice{index}_decline", $"powerSelection{index}_choice", "noble_hub_intro2", new TextObject("{=A2zGMa9Q}Not at this time, perhaps later.").ToString(), null, null, 200);
            }

            obj.AddPlayerLine(text + 4, "noble_prestige_political_power_hub_selection", "noble_prestige_political_power_hub", new TextObject("{=Xp2zccPw}[Enlarge your Influence throughout the Empire (Repeatable)]").ToString(), () => HasEnoughInfluence(25), delegate
            {
                ExchangeInfluenceForPrestige(25, 15);
            }, 200);
            obj.AddPlayerLine("noble_prestige_politicalpower_hub_back", "noble_prestige_political_power_hub_selection", "noble_hub_intro2", new TextObject("{=wv5RMDBj}Maybe something different.(back)").ToString(), null, null, 200);
        }

        static void ExchangeInfluenceForPrestige(int cost, int exchange)
        {
            Hero.MainHero.AddInfluenceWithKingdom(-cost);
            Hero.MainHero.AddCultureSpecificCustomResource(exchange);
        }

        static bool HasEnoughGold(int price)
        {
            return Hero.MainHero.Gold > price;
        }

        static bool HasEnoughInfluence(int cost)
        {
            return Hero.MainHero.Clan.Influence > (float)cost;
        }

        static bool HasEnoughPrestigeForMount()
        {
            return Hero.MainHero.GetCustomResourceValue("Prestige") >= 1000f;
        }

        static void StartTransaction(int price, int id, List<string> _constructedBuildings)
        {
            Hero.MainHero.ChangeHeroGold(-price);
            Hero.MainHero.AddCustomResource("Prestige", price / 500);
            _constructedBuildings.Add("building" + id);
        }

        [HarmonyPrefix]
        [HarmonyPatch(typeof(PrestigeNobleTownBehavior), "OnNewGameStarted")]
        public static bool PrefixOnNewGameStarted(CampaignGameStarter obj, PrestigeNobleTownBehavior __instance)
        {
            var _altdorf = Traverse.Create(__instance).Field<Settlement>("_altdorf");
            var _empireNoble = Traverse.Create(__instance).Field<Hero>("_empireNoble");

            foreach (Settlement item in Settlement.All)
            {
                if (item.StringId == "town_RL1")
                {
                    _altdorf.Value = item;
                    CharacterObject @object = MBObjectManager.Instance.GetObject<CharacterObject>("tor_prestige_noble_empire");
                    if (@object != null)
                    {
                        _empireNoble.Value = HeroCreator.CreateSpecialHero(@object, _altdorf.Value, null, null, 50);
                        _empireNoble.Value.SupporterOf = _altdorf.Value.OwnerClan;
                        TextObject name = _empireNoble.Value.Template.Name;
                        var title = new TextObject("{=KikYamUt}Berthold Wendehals, ").ToString();
                        _empireNoble.Value.SetName(new TextObject(title + name), _empireNoble.Value.FirstName);
                        HeroHelper.SpawnHeroForTheFirstTime(_empireNoble.Value, _altdorf.Value);
                    }
                    break;
                }
            }

            return false;
        }
    }
}
