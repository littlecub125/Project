using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentoVox.Model;

namespace VentoVox.Interface
{
    public struct ArgsData : IDisposable
    {

        public int seqNum;
        public int[] intValue;
        public double[] doubleValue;
        public string stringValue;
        public FoodData MenuData;


        public void Dispose()
        {
            intValue = null;
            doubleValue = null;
        }

    }


    public interface IControlManager
    {
        
        void SetSeqName(string seqName);
        string GetSeqName();
        void Run(ArgsData data);
        void Stop();

        void Terminate();

        List<(string, bool)> GetSequenceFlag();
    }
}
