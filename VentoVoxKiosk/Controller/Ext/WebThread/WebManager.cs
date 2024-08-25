using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using VentoVox.ControlManager.Application;
using VentoVox.Interface;
using static VentoVox.ControlManager.Application.LogManager;

namespace VentoVox
{
    public class WebManager: IControlManager
    {
        public enum WebCmdList
        {
            Post,
            Get,
            Put,
            Delete,
        }

        private HttpClient WebClient = null;
        const string APIUrl = "http://13.209.103.55:8080/api/items";
        string _seqName = string.Empty;

        public static IControlManager CreateManager()
        {
            WebManager seq = new WebManager();
    ;       
            return seq;
        }
        public WebManager()
        {
            InitClient();
        }

        private void InitClient()
        {
            WebClient = new HttpClient();
            
        }


        public string GetControllerName()
        {
            return _seqName;
        }


        public async void Run(ArgsData data)
        {
            HttpResponseMessage response = null;
     
            string postData = string.Empty;
            StringContent content = null;
            try
            {
                switch (data.seqNum)
                {
                    case (int)WebCmdList.Post: // API 데이터 추가하기

                        postData = data.stringValue;
                        content = new StringContent(postData, System.Text.Encoding.UTF8, "application/json");
                        response = await WebClient.PostAsync(APIUrl, content);


                        break;

                    case (int)WebCmdList.Get: // API 데이터 가져오기
                        response = await WebClient.GetAsync(APIUrl);
                        break;

                    case (int)WebCmdList.Put: // API 데이터 업데이트
                        postData = data.stringValue;
                        content = new StringContent(postData, System.Text.Encoding.UTF8, "application/json");
                        response = await WebClient.PutAsync(APIUrl, content);

                        break;

                    case (int)WebCmdList.Delete: // API 데이터 삭제하기
                        response = await WebClient.DeleteAsync(APIUrl);
                        break;

                    default:
                        break;
                }

                string result = $"MethodType = {response.RequestMessage.Method}, StstusCode = {response.StatusCode}, StatusDesc = {response.ReasonPhrase}";
                if (response.IsSuccessStatusCode)
                {
                    string responseData = await response.Content.ReadAsStringAsync();
                    if (response.RequestMessage.Method == HttpMethod.Get)
                    {
                        JObject jsonData = JObject.Parse(responseData);
                    }
   
                    LogManager.GetInstance().SetMsg($"데이터 가져오기 성공", LogLevel.Web);
                }
                else
                {
                    LogManager.GetInstance().SetMsg($"API 요청 실패. 상태 코드: {response.StatusCode}", LogLevel.Web);
                }

                LogManager.GetInstance().SetMsg($"{result}", LogLevel.Web);
            }
            catch (Exception ex)
            {
                LogManager.GetInstance().SetMsg(ex.Message, LogLevel.Error);
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
