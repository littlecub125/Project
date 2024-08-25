using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using VentoVox.Interface;
using static VentoVox.ControlManager.Application.LogManager;

namespace VentoVox.Seq
{
    public class ExtController
    {
        const int SequenceNone = -1;
        Thread thSeq = null;
      
        bool bLoop = false;
        int nCurrentSeqNum = 0;
   
        Queue<ArgsData> seqQueue = new Queue<ArgsData>();


        IControlManager seqControl = null;

  

        public ExtController(IControlManager seq)
        {
            seqControl = seq;
            StartLoop();
        }
        public void StopSeq()
        {
            seqQueue.Clear();
            seqControl.Stop();
        }
        public string GetName()
        {
            return seqControl.GetControllerName();
        }


        public bool SetCmd(ArgsData args)
        {
            seqQueue.Enqueue(args);
            return true;
        }
        public List<(string, bool)> GetSequenceFlag()
        {
            return seqControl.GetSequenceFlag();
        }
        public void StartLoop()
        {
            bLoop = true;
            thSeq = new Thread(SequenceLoop);
            thSeq.Start();
        }
 
        public bool IsSeqRunning()
        {
            if (nCurrentSeqNum != SequenceNone || seqQueue.Count > 0)
            {
                return true;
            }

            return false;
        }

        public void TerminateLoop()
        {
            seqControl.Terminate();
            while (IsSeqRunning())
            {
                Thread.Sleep(10);
            }
            bLoop = false;
            thSeq.Join();
            thSeq = null;
        }

        private void SequenceLoop()
        {
            while (bLoop)
            {
                if (seqQueue.Count > 0)
                {
                    ArgsData args = seqQueue.Dequeue();
                    nCurrentSeqNum = args.seqNum;
                    seqControl.Run(args);
                    args.Dispose();
                    Thread.Sleep(10);
                }
                else
                {
                    nCurrentSeqNum = SequenceNone;
                    Thread.Sleep(100);
                }
            }
        }
    }
}
