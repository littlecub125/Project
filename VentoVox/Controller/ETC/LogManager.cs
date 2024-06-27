using panelMain;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using VentoVox.Interface;

namespace VentoVox.ControlManager.Application
{
    public class LogManager 
    {
        public enum LogLevel
        {
            Normal,
            Warning,
            Error,


        }

        string strLogFileName = string.Empty;
        string sStartUpPath = string.Empty;

        private static LogManager _instance;

        private Queue<(string, LogLevel)> LogMsg = new Queue<(string, LogLevel)>();


        public void SetToastMsg(string msg, LogLevel level)
        {
            ToastMsg toastMsg = new ToastMsg(msg, level);

            string strLog = DateTime.Now + " " + msg; 
            (string, LogLevel) item = (strLog, level);

            LogMsg.Enqueue(item);

            toastMsg.Show();
        }

        public void SaveLogMsg()
        {
            sStartUpPath = System.Windows.Forms.Application.StartupPath + @"\Log\";
            if (!Directory.Exists(sStartUpPath))
            {
                Directory.CreateDirectory(sStartUpPath);
            }

            if (strLogFileName.CompareTo(sStartUpPath + DateTime.Today.ToString("yyyyMMdd") + ".log") != 0)
            {
                strLogFileName = sStartUpPath + DateTime.Today.ToString("yyyyMMdd") + ".log";
            }
            FileInfo fi = new FileInfo(strLogFileName);
            StreamWriter sw;

            if (fi.Exists == false)
                sw = new StreamWriter(strLogFileName);
            else
                sw = File.AppendText(strLogFileName);

            for (int i = 0; i < LogMsg.Count; i++)
            {
                (string, LogLevel) data;

                data = LogMsg.Dequeue();
             
                string sMsg = string.Format("{0} {1}", data.Item1, data.Item2);

                sw.WriteLine(sMsg);
            }

            sw.Close();
            sw.Dispose();
        }


    }
}
