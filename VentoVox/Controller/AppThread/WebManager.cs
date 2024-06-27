using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentoVox.Interface;

namespace VentoVox
{
    public class WebManager: IControlManager
    {
        public enum WebCmdList
        {

        }


        private static WebManager _instance;

        string _seqName = string.Empty;
        public static WebManager Instance()
        { 
            if (_instance == null)
            {
                _instance =new WebManager();
            }
            return _instance;
        }
        public static IControlManager CreateManager()
        {
            WebManager seq = new WebManager();
            return seq;
        }

        public string GetSeqName()
        {
            return _seqName;
        }


        public void Run(ArgsData data)
        {
            throw new NotImplementedException();
        }

        public void SetSeqName(string seqName)
        {
            _seqName = seqName;
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }

        public void Terminate()
        {
            throw new NotImplementedException();
        }

        public List<(string, bool)> GetSequenceFlag()
        {
            throw new NotImplementedException();
        }
    }
}
