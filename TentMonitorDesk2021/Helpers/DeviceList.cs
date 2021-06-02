using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace TentMonitorDesk2021.Helpers
{
    public class DeviceList
    {
        public int error_code { get; set; } 
        public List<Device> deviceList { get; set; }

        public string token = "5a93bb0d-ATivDcek4y2ORTjGAo0qXb0";

        public List<Device> GetDevices()
        {
            //token = GetToken();
            Dictionary<string, string> rest_obj = new Dictionary<string, string>();
            rest_obj.Add("method", "getDeviceList");
            var payLoad = Newtonsoft.Json.JsonConvert.SerializeObject(rest_obj);
            //var content = new FormUrlEncodedContent(rest_obj);
            //var response = await client.PostAsync(url, content);
            //return response;

            var url = "https://wap.tplinkcloud.com?token=" + token;
            var client = new RestClient(url);
            // client.Authenticator = new HttpBasicAuthenticator(username, password);
            var request = new RestRequest();
            request.AddJsonBody(rest_obj);
            var response = client.Post(request);
            var content = response.Content; // Raw content as string
            JObject obj = JObject.Parse(content);
            JToken results = obj.SelectToken("result.deviceList");
            if (results != null)
            {
                var deviceList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Device>>(results.ToString());
                foreach (var device in deviceList)
                {
                    device.State = GetState(device);
                }
                return deviceList;
            }
            return null;
        }

        private string GetToken()
        {
            Dictionary<string, string> rest_obj = new Dictionary<string, string>();
            string json = @"{""method"": ""login"", ""params"": {""appType"": ""Kasa_Android"", ""cloudUserName"": ""stumay111@gmail.com"", ""cloudPassword"": ""Sh@dow111"", ""terminalUUID"": ""MY_UUID_v4""}}";

            var payLoad = json;//Newtonsoft.Json.JsonConvert.SerializeObject(json);
            //var content = new FormUrlEncodedContent(rest_obj);
            //var response = await client.PostAsync(url, content);
            //return response;

            var url = "https://wap.tplinkcloud.com";
            var client = new RestClient(url);
            // client.Authenticator = new HttpBasicAuthenticator(username, password);
            var request = new RestRequest();
            request.AddJsonBody(payLoad);
            var response = client.Post(request);
            var content = response.Content; // Raw content as string
            return "";

        }

        public int GetState(Device device)
        {
            string json = @"{""method"": ""passthrough"", ""params"": { ""deviceId"": ""|device|"",""requestData"": {""system"":{""get_sysinfo"":null},""emeter"":{""get_realtime"":null}}}}";
            json = json.Replace("|device|", device.deviceId);
            var url = "https://wap.tplinkcloud.com?token=" + token;
            var client = new RestClient(url);
            // client.Authenticator = new HttpBasicAuthenticator(username, password);
            var request = new RestRequest();
            request.AddJsonBody(json);
            var response = client.Post(request);
            var content = response.Content; // Raw content as string
            JObject obj = JObject.Parse(content);
            JToken results = obj.SelectToken("result.responseData.system.get_sysinfo.relay_state");
            var result = results.ToString();
            return int.Parse(result);

        }


        public void SetState(Device device, int state, ProbeData probeData)
        {
            string json = @"{""method"": ""passthrough"", ""params"": { ""deviceId"": ""|device|"",""requestData"": {""system"":{""set_relay_state"":{""state"":|newState|}}}}}";
            json = json.Replace("|device|", device.deviceId);
            json = json.Replace("|newState|", state.ToString());

            var url = "https://wap.tplinkcloud.com?token=" + token;
            var client = new RestClient(url);
            // client.Authenticator = new HttpBasicAuthenticator(username, password);
            var request = new RestRequest();
            request.AddJsonBody(json);
            var response = client.Post(request);
            probeData.ActionList.Add("Turned " + device.alias + " " + (state == 1 ? "on" : "off"));
        }

    }

    public class Device
    {
        public string deviceType { get; set; }
        public int role { get; set; }
        public string fwVer { get; set; }
        public string appServerUrl { get; set; }
        public string deviceRegion { get; set; }
        public string deviceId { get; set; }
        public string deviceName { get; set; }
        public string deviceHwVer { get; set; }
        public string alias { get; set; }
        public string deviceMac { get; set; }
        public string oemId { get; set; }
        public string deviceModel { get; set; }
        public string hwId { get; set; }
        public string fwId { get; set; }
        public bool isSameRegion { get; set; }
        public int status { get; set; }

        [ScriptIgnore]
        public int State { get; set; }
    }
}