//using System;
//using System.Collections.Generic;
//using System.Text;
//using TaleWorlds.Library;
//using TaleWorlds.Localization;
//using TOR_Core.CharacterDevelopment.CareerSystem;

//namespace TheOldRealms_CNs.Extensions
//{
//    public class CareerScreenVMOverride : CareerScreenVM
//    {
//        private string doneButtonLabel;

//        public CareerScreenVMOverride(Action closeAction) : base(closeAction)
//        {
//            this.doneButtonLabel = new TextObject("{=str_tor_emp_lord_averland_factionleader}完成").ToString();
//        }

//        [DataSourceProperty]
//        public string DoneButtonLabel
//        {
//            get
//            {
//                return this.doneButtonLabel;
//            }
//            set
//            {
//                if (value != this.doneButtonLabel)
//                {
//                    this.doneButtonLabel = value;
//                    base.OnPropertyChangedWithValue<string>(value, "DoneButtonLabel");
//                }
//            }
//        }
//    }
//}
