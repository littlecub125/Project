using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentoVox.ControlManager;
using VentoVox.Interface;
using VentoVox.Seq;

namespace VentoVox.Master
{
    #region HW & Web Manager
    public partial class SeqManager
    {
        private static SeqManager _instance = null;

        public static SeqManager GetInstance()
        {
            if (_instance == null)
            {
                _instance = new SeqManager();
            }
            return _instance;
        }

        public enum AppThread
        {
            WebManager,
            NUM_OF_APP_MANAGERS,
        }

        public enum HWThread
        {
            HWManager,
            NUM_OF_HW_MANAGERS,
        }

        public bool[] InitSequence()
        {
            bool[] bResult = new bool[4];

            iWebManager = WebManager.CreateManager();
  
            AppMaster[(int)AppThread.WebManager] = new ExtController(iWebManager);
     
            if (AppMaster[(int)AppThread.WebManager] != null)
            {
                bResult[(int)AppThread.WebManager] = true;
            }

            iHWController = HWControlManager.CreateManager();

            HwMaster[(int)HWThread.HWManager] = new ExtController(iHWController);
            if (HwMaster != null)
            {
                bResult[(int)HWThread.HWManager] = true;
            }

            return bResult;
        }
        public void StopAllSequence()
        {
            for (int i = 0; i < Enum.GetValues(typeof(HWThread)).Length; i++)
            {
                HwMaster[i].StopSeq();
            }

            for (int i = 0; i < Enum.GetValues(typeof(AppThread)).Length; i++)
            {
                AppMaster[i].StopSeq();
            }

        }
        public void Terminate()
        {
          
            for (int i = 0; i<Enum.GetValues(typeof(AppThread)).Length; i++)
            {
                AppMaster[i].TerminateLoop();
            }
            for (int i = 0; i < Enum.GetValues(typeof(HWThread)).Length; i++)
            {
                HwMaster[i].TerminateLoop();
            }


        }


        IControlManager iHWController = null;

        IControlManager iWebManager = null;


        public ExtController[] HwMaster = new ExtController[(int)HWThread.NUM_OF_HW_MANAGERS];

        public ExtController[] AppMaster = new ExtController[(int) AppThread.NUM_OF_APP_MANAGERS];

 
    }
    #endregion


    #region Data & Log & OrderManager
    public partial class SeqManager
    {



    }
    #endregion
}
