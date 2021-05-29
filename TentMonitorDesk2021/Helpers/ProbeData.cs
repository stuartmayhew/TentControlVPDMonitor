using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;

namespace TentMonitorDesk2021.Helpers
{
    public class ProbeData
    {
        public decimal Humidity { get; set; }
        public decimal Temp { get; set; }
        public decimal VPD { get; set; }
        public string tokenStr { get; set; }
        public string Targets { get; set; }

        public List<string> ActionList { get; set; }

        public bool needsAdjust
        {
            get
            {
                var db = new TentData();
                var settings = db.Settings.FirstOrDefault();
                var nightStart = settings.nightStart;
                var nightEnd = settings.nightEnd;

                decimal tempFactor = settings.tempRangeFactor;
                decimal RHFactor = settings.RHRangeFactor;
                decimal optTemp;
                decimal optRH;
                var timeNow = int.Parse(DateTime.Now.ToString("HH")) * 100;
                bool isNight = (timeNow >= nightStart && timeNow <= nightEnd);

                    if (isNight)
                        optTemp = settings.optTempNight;
                    else
                        optTemp = settings.optTempDay;

                    if (isNight)
                        optRH = settings.optRHNight;
                    else
                        optRH = settings.optRHDay;



                if (Temp < optTemp - tempFactor)
                    return true;
                if (Temp > optTemp + tempFactor)
                    return true;

                if (Humidity < optRH - RHFactor)
                    return true;
                if (Humidity > optRH + RHFactor)
                    return true;

                return false;
            }
        }

        public class TokenData
        {
            public string authorization { get; set; }
            public string apikey { get; set; }
        }
        public ProbeData()
        {
            ActionList = new List<string>();
            var auth = GetAuth();
            var authObj = Newtonsoft.Json.JsonConvert.DeserializeObject<TokenData>(auth);
            var token = GetToken(authObj);
            JObject obj = JObject.Parse(token);
            tokenStr = obj["accesstoken"].ToString();
            ReadData(tokenStr);
        }
        
        class authClass
        {
            public string authorization { get; set; }
        }

        private string GetToken(TokenData authObj)
        {
            var auth = new authClass() { authorization = authObj.authorization };

            var payload = Newtonsoft.Json.JsonConvert.SerializeObject(auth);

            var client = new RestClient("https://api.sensorpush.com/api/v1/oauth");
            var req = new RestRequest("accesstoken", Method.POST);
            req.AddJsonBody(payload);
            var response = client.Post(req);
            return response.Content;
        }

        public class AuthToken
        {
            public string Authorization { get; set; }
        }

        private object ListGateways(string token)
        {
            var auth = new AuthToken() { Authorization = token };
            var payload = Newtonsoft.Json.JsonConvert.SerializeObject(auth);

            var client = new RestClient("https://api.sensorpush.com/api/v1/devices");
            var req = new RestRequest("gateways", Method.POST);
            //req.AddJsonBody(payload);
            req.AddHeader("Authorization:", token);

            var response = client.Post(req);
            return response.Content;
        }


        public void ReadData(string token)
        {
            string jData = @"{ ""limit"": 1 }";

            var client = new RestClient("https://api.sensorpush.com/api/v1");
            var req = new RestRequest("samples", Method.POST);
            req.AddJsonBody(jData);
            req.AddHeader("Authorization",token);
            req.AddHeader("accept", "application/json");

            var response = client.Post(req);
            JToken toke = JToken.Parse(response.Content);
            var adata = toke["sensors"]["341219.8836852952524783"]; 
            var bdata = toke["sensors"]["16787263.4127096176910978"];
            Temp = decimal.Parse(bdata[0]["temperature"].ToString());
            Humidity = decimal.Parse(bdata[0]["humidity"].ToString());
            var tVPD = VPDCalculator.CalcVPD(Temp, Humidity);
            VPD = tVPD.VPD;

        }
        public class OauthConfig
        {
            public string email { get; set; }
            public string password { get; set; }

            public OauthConfig()
            {
                email = "stumay111@gmail.com";
                password = "shadow111";
            }
        }

        private string GetAuth()
        {
            var client = new RestClient("https://api.sensorpush.com/api/v1/oauth");
            var req = new RestRequest("authorize", Method.POST);
            var config = new OauthConfig();//values to pass in request
            var payload = Newtonsoft.Json.JsonConvert.SerializeObject(config);


            req.AddJsonBody(payload);
            var response = client.Post(req);
            return response.Content;
        }


        private ProbeData GetProbeData()
        {
            return new ProbeData();
        }



        private RestSharp.IRestResponse ListSensors(object token,object gateway = null)
        {
            Dictionary<string, string> rest_obj = new Dictionary<string, string>();
            string json = @"{""email"": ""stumay111@gmail.com"", ""password"": ""shadow111""}";

            var payLoad = Newtonsoft.Json.JsonConvert.SerializeObject(json);

            var url = "https://api.sensorpush.com/api/v1/devices/sensors";
            var client = new RestClient(url);
            var request = new RestRequest();
            request.AddJsonBody(payLoad);
            var response = client.Post(request);
            return response;
        }
    }
    public class LogData
    {

        public decimal LogHour { get; set; }
        public decimal Data { get; set; }
    }
}