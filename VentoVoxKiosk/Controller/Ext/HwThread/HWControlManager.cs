﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentoVox.ControlManager.Application;
using VentoVox.Interface;

namespace VentoVox.ControlManager
{
    public class HWControlManager: IControlManager
    {
        public enum HWCmdList
        {

        }


        private string _seqName = string.Empty;


        public static IControlManager CreateManager()
        {
            HWControlManager seq = new HWControlManager();
            return seq;
        }
        public HWControlManager() 
        {
            ConnectDevices();
        }

        private void ConnectDevices()
        {
            // TODO
            // 연결할 디바이스 소싱 필요
        }

        public void Run(ArgsData data)
        {
            switch (data.seqNum)
            {
                default:
                    break;
            }
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }

        public void Terminate()
        {
            throw new NotImplementedException();
        }



        public string GetControllerName()
        {
            return _seqName;
        }



        public List<(string, bool)> GetSequenceFlag()
        {
            throw new NotImplementedException();
        }

        public void SetControllerName()
        {
            throw new NotImplementedException();
        }
    }
}
