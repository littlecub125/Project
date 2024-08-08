
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using VentoVox.Interface;

namespace VentoVox.ControlManager.Application
{
    public class LogManager : INotifyPropertyChanged
    {
        public enum LogLevel
        {
            Normal,
            Warning,
            Error,

        }
        private string _WarningMessage = string.Empty;
        private string _ErrorMessage = string.Empty;
        private string _NormalMessage = string.Empty;
        public event PropertyChangedEventHandler PropertyChanged;
        string strLogFileName = string.Empty;
        string sStartUpPath = string.Empty;

        private static LogManager _instance;

        public Queue<(string, LogLevel)> LogMsgQueue = new Queue<(string, LogLevel)>();


        public static LogManager GetInstance()
        {
            if (_instance == null)
            {
                _instance = new LogManager();
            }
            return _instance;
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

            for (int i = 0; i < LogMsgQueue.Count; i++)
            {
                (string, LogLevel) data;

                data = LogMsgQueue.Dequeue();
             
                string sMsg = string.Format("{0} {1}", data.Item1, data.Item2);

                sw.WriteLine(sMsg);
            }

            sw.Close();
            sw.Dispose();
        }

        
        public string ErrorMessage
        {
            get
            {
                return _ErrorMessage;
            }
            set
            {
                if (_ErrorMessage != value)
                {
                    _ErrorMessage = value;
                    OnPropertyChanged("AlaramMessage");
                }
            }
        }

        public string WarningMessage
        {
            get
            {
                return _WarningMessage;
            }
            set
            {
                _WarningMessage = value;
                OnPropertyChanged("LogMessage");
            }
        }
   
        public string NormalMessage
        {
            get
            {
                return _NormalMessage;
            }
            set
            {
                _NormalMessage = value;
                OnPropertyChanged("NormalMessage");
            }
        }

        public void SetMsg(string msg, LogLevel level)
        {
            switch (level)
            {
                case LogLevel.Error:
                    ErrorMessage = msg;
                    break;

                case LogLevel.Warning:
                    WarningMessage = msg;
                    break;
                case LogLevel.Normal:
                    NormalMessage = msg;    
                    break;
                default:
                    break;
            }
        }
       
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}
