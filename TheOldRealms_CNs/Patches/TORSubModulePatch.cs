//using HarmonyLib;
//using System;
//using System.Collections.Generic;
//using System.Text;
//using TaleWorlds.CampaignSystem.Settlements.Buildings;
//using TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.TownManagement;
//using TaleWorlds.Engine;
//using TaleWorlds.Localization;
//using TOR_Core.Utilities;

//namespace TheOldRealms_CNs.Patches
//{
//    [HarmonyPatch(typeof(TOR_Core.SubModule), "OnApplicationTick")]
//    internal class TORSubModulePatch
//    {
//        public static bool Prefix(float dt)
//        {
//            //float my_tick = Traverse.Create<TOR_Core.SubModule>().Field<float>("_tick").Value;
//            //int my_num = Traverse.Create<TOR_Core.SubModule>().Field<int>("_num").Value;
//            //my_tick += dt;
//            //if (my_tick > 0.00000001f)
//            //{
//            //    my_tick = 0f;
//            //    if (!LoadingWindow.IsLoadingWindowActive)
//            //    {
//            //        int num = my_num;
//            //        my_num = Utilities.GetNumberOfShaderCompilationsInProgress();
//            //        if (my_num > 0 && my_num != num)
//            //        {
//            //            TORCommon.Say("着色器加载中。剩余着色器asdfs：" + my_num.ToString());
//            //        }
//            //    }
//            //}

//            TORCommon.Say("着色器加载中。剩余着色器asdfs： "+ Utilities.GetNumberOfShaderCompilationsInProgress());

//            return false;
//        }
//    }
//}
