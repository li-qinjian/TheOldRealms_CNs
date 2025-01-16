using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Text;
using TaleWorlds.Core;
using TaleWorlds.Localization;
using TOR_Core.CampaignMechanics.CustomEvents;
using TOR_Core.Utilities;

namespace TheOldRealms_CNs.Patches
{
    [HarmonyPatch]
    internal class CustomEventsCampaignBehaviorPatch
    {
        [HarmonyPrefix]
        [HarmonyPatch(typeof(CustomEventsCampaignBehavior), "OnChaosUprisingStarted")]
        public static bool Prefix(object sender, ChaosUprisingStartedEventArgs e)
        {
            var message = string.Format("混沌腐化严重，就会在 {0} 爆发叛乱", e.Settlement.Name.ToString());
            MBInformationManager.AddQuickInformation(new TextObject(message, null), 0, null, "");
            return false;
        }
    }
}
