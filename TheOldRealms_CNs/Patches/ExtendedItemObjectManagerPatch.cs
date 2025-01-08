using HarmonyLib;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using TaleWorlds.Engine;
using TaleWorlds.Library;
using TaleWorlds.Localization;
using TaleWorlds.ModuleManager;
using TOR_Core.Items;
using TOR_Core.Utilities;

namespace TOR_Localization.Patches
{
    [HarmonyPatch]
    public static class ExtendedItemObjectManagerPatch
    {
        private static string XMLPath = ModuleHelper.GetModuleFullPath("TOR_Localization") + "ModuleData/tor_custom_xmls/tor_extendeditemproperties.xml";

        [HarmonyPrefix]
        [HarmonyPatch(typeof(ExtendedItemObjectManager), "LoadXML")]
        public static bool Prefix()
        {
            if (File.Exists(XMLPath))
            {
                List<ExtendedItemObjectProperties> list = new XmlSerializer(typeof(List<ExtendedItemObjectProperties>)).Deserialize(File.OpenRead(XMLPath)) as List<ExtendedItemObjectProperties>;

                if (list != null && list.Count > 0)
                {
                    var extendedItemInfoMap = Traverse.Create(typeof(ExtendedItemObjectManager)).Field<Dictionary<string, ExtendedItemObjectProperties>>("_itemToInfoMap");

                    foreach (ExtendedItemObjectProperties item in list)
                    {
                        extendedItemInfoMap.Value.Add(item.ItemStringId, item);
                    }
                }
            }
            return false;
        }
    }
}
