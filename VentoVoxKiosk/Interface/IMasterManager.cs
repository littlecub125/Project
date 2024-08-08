using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentoVox.ControlManager.Application;
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
        string GetControllerName();

        void SetControllerName();
        void Run(ArgsData data);
        void Stop();

        void Terminate();

        List<(string, bool)> GetSequenceFlag();
  
    }
}
