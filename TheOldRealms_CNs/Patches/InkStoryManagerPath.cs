using HarmonyLib;
using System.Collections.Generic;
using System.IO;
using TaleWorlds.ModuleManager;
using TOR_Core.Ink;

namespace TheOldRealms_CNs.Patches
{
    [HarmonyPatch]
    internal class InkStoryManagerPath
    {
        private static string XMLPath = ModuleHelper.GetModuleFullPath(SubModule.ModuleName) + "InkStories/";

        [HarmonyPrefix]
        [HarmonyPatch(typeof(InkStoryManager), "LoadStories")]
        public static bool Prefix(Dictionary<string, InkStory> ____stories)
        {
            ____stories.Clear();
            if (Directory.Exists(XMLPath))
            {
                foreach (string file in Directory.GetFiles(XMLPath, "*.ink"))
                {
                    ____stories.Add(Path.GetFileNameWithoutExtension(file), new InkStory(Path.GetFileNameWithoutExtension(file), file));
                }
            }
            return false;
        }
    }
}
