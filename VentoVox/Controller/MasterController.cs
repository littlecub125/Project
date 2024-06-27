using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VentoVox.Interface;

namespace VentoVox.Seq
{
    public class MasterController
    {
        const int SequenceNone = -1;
        Thread thHwSeq = null;
        Thread thAppSeq = null;
        bool bLoop = false;
        int nCurrentSeqNum = 0;
   
        Queue<ArgsData> seqQueue = new Queue<ArgsData>();


        IControlManager seqManager = null;

        public MasterController(IControlManager seq)
        {
            seqManager = seq;
        }
        public void StopSeq()
        {
            seqQueue.Clear();
            seqManager.Stop();
        }
        public string GetName()
        {
            return seqManager.GetSeqName();
        }

        public void SetName(string strName)
        {
            seqManager.SetSeqName(strName);
        }

        public bool SetCmd(ArgsData args)
        {
            seqQueue.Enqueue(args);
            return true;
        }
        public List<(string, bool)> GetSequenceFlag()
        {
            return seqManager.GetSequenceFlag();
        }
        public void StartLoop()
        {
            bLoop = true;
            thHwSeq = new Thread(SequenceLoop);
            thHwSeq.Start();

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
            seqManager.Terminate();
            while (IsSeqRunning())
            {
                Thread.Sleep(10);
            }
            bLoop = false;
            thHwSeq.Join();
            thHwSeq = null;
        }

        private void SequenceLoop()
        {
            while (bLoop)
            {
                if (seqQueue.Count > 0)
                {
                    ArgsData args = seqQueue.Dequeue();
                    nCurrentSeqNum = args.seqNum;
                    seqManager.Run(args);
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
