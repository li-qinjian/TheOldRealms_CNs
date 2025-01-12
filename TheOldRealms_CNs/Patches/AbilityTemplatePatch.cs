using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Library;
using TaleWorlds.Localization;
using TheOldRealms_CNs.Extensions;
using TOR_Core.AbilitySystem;
using TOR_Core.AbilitySystem.SpellBook;
using TOR_Core.AbilitySystem.Spells;
using TOR_Core.CampaignMechanics.CustomResources;
using TOR_Core.Extensions;
using TOR_Core.Utilities;

namespace TheOldRealms_CNs.Patches
{
    [HarmonyPatch]
    internal class AbilityTemplatePatch
    {
        //[HarmonyTranspiler]
        //[HarmonyPatch(typeof(AbilityTemplate), "GetStats")]
        //public static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions /*, ILGenerator generator*/)
        //{
        //    var toString = AccessTools.Method(typeof(Object), nameof(Object.ToString));
        //    var toTextObjct = AccessTools.Method(typeof(AbilityTemplateExtensions), nameof(AbilityTemplateExtensions.toTextObject));
        //    var SpellCastingLevelType = AccessTools.TypeByName("SpellCastingLevel");
        //    var AbilityEffectTypeType = AccessTools.TypeByName("AbilityEffectType");
        //    var found = false;
        //    var i = 0;
        //    var listInstructions = new List<CodeInstruction>(instructions);
        //    foreach (var instruction in listInstructions)
        //    {
        //        if (instruction.opcode == OpCodes.Ldstr && instruction.operand.ToString() == " seconds")
        //        {
        //            yield return new CodeInstruction(OpCodes.Ldstr, "{=4yHGR23S} seconds");
        //            yield return new CodeInstruction(OpCodes.Ldnull);
        //            yield return new CodeInstruction(OpCodes.Newobj, AccessTools.Constructor(typeof(TextObject), new Type[] { typeof(string), typeof(Dictionary<string, object>) }));
        //            yield return new CodeInstruction(OpCodes.Callvirt, AccessTools.Method(typeof(Object), nameof(Object.ToString)));

        //            found = true;
        //        }
        //        else if (instruction.opcode == OpCodes.Callvirt && instruction.operand == (object)toString)
        //        {
        //            if (listInstructions[i - 1].opcode == OpCodes.Constrained && (listInstructions[i - 1].operand == (object)SpellCastingLevelType) || listInstructions[i - 1].operand == (object)AbilityEffectTypeType)
        //            {
        //                yield return new CodeInstruction(OpCodes.Ldnull);
        //                yield return new CodeInstruction(OpCodes.Callvirt, toTextObjct);
        //                //yield return new CodeInstruction(OpCodes.Pop);
        //                yield return new CodeInstruction(OpCodes.Callvirt, toString);

        //            }
        //            else
        //            {
        //                yield return instruction;
        //            }
        //        }
        //        else
        //        {
        //            yield return instruction;
        //        }
        //        i++;
        //    }
        //    if (found is false)
        //        throw new ArgumentException("Cannot find ldstr 'seconds' in AbilityTemplate.GetStats");
        //}

        [HarmonyPrefix]
        [HarmonyPatch(typeof(AbilityTemplate), "GetStats")]
        public static bool Prefix(Hero hero, AbilityTemplate spellTemplate, ref MBBindingList<StatItemVM> __result)
        {
            MBBindingList<StatItemVM> mbbindingList = new MBBindingList<StatItemVM>();
            switch (spellTemplate.AbilityType)
            {
                case AbilityType.Innate:
                    break;
                case AbilityType.Spell:
                    mbbindingList.Add(new StatItemVM(new TextObject("{=tor_spell_stat_tag_name_str}Spell Name: ", null).ToString(), new TextObject(spellTemplate.Name, null).ToString()));
                    mbbindingList.Add(new StatItemVM(new TextObject("{=tor_spell_stat_tag_wom_cost_str}Winds of Magic cost: ", null).ToString(), hero.GetEffectiveWindsCostForSpell(spellTemplate).ToString() + CustomResourceManager.GetResourceObject("WindsOfMagic").GetCustomResourceIconAsText(false)));
                    mbbindingList.Add(new StatItemVM(new TextObject("{=tor_spell_stat_tag_tier_str}Spell Tier: ", null).ToString(), ((SpellCastingLevel)spellTemplate.SpellTier).ToTextObject().ToString()));
                    mbbindingList.Add(new StatItemVM(new TextObject("{=tor_spell_stat_tag_type_str}Spell Type: ", null).ToString(), spellTemplate.AbilityEffectType.ToTextObject().ToString()));
                    mbbindingList.Add(new StatItemVM(new TextObject("{=tor_spell_stat_tag_cooldown_str}Cooldown: ", null).ToString(), spellTemplate.CoolDown.ToString() + new TextObject("{=4yHGR23S} seconds").ToString()));
                    break;
                case AbilityType.Prayer:
                    mbbindingList.Add(new StatItemVM(new TextObject("{=tor_prayer_stat_tag_name_str}Prayer Name: ", null).ToString(), new TextObject(spellTemplate.Name, null).ToString()));
                    mbbindingList.Add(new StatItemVM(new TextObject("{=tor_prayer_stat_tag_tier_str}Prayer Tier: ", null).ToString(), ((PrayerLevel)spellTemplate.SpellTier).ToTextObject().ToString()));
                    mbbindingList.Add(new StatItemVM(new TextObject("{=tor_prayer_stat_tag_type_str}Prayer Type: ", null).ToString(), spellTemplate.AbilityEffectType.ToTextObject().ToString()));
                    mbbindingList.Add(new StatItemVM(new TextObject("{=tor_spell_stat_tag_cooldown_str}Cooldown: ", null).ToString(), spellTemplate.CoolDown.ToString() + new TextObject("{=4yHGR23S} seconds").ToString()));
                    break;
                case AbilityType.ItemBound:
                    break;
                case AbilityType.CareerAbility:
                    break;
                default:
                    break;
            }

            __result = mbbindingList;
            return false;
        }
    }
}
