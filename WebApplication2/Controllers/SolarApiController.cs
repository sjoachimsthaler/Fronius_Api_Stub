using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

using WebApplication2.Model;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("solarapi")]
    [Route("solar_api")]
    [Route("solarapi/v1")]
    [Route("solar_api/v1")]
    public class SolarApiController : ControllerBase
    {
        public ILogger<SolarApiController> Logger { get; }
        public HttpClient HttpClient { get; }

        public SolarApiController(ILogger<SolarApiController> logger, HttpClient httpClient)
        {
            Logger = logger;
            HttpClient = httpClient;
        }

        [HttpGet]
        [Route("GetInverterInfo")]
        [Route("GetInverterInfo.cgi")]
        public InverterInfoResponse GetInverterInfo()
        {
            

            Logger.LogInformation("GET: GetInverterInfo");
            //Logger.LogInformation($"Form: {string.Join(",", Request.Form.Select(x => $"{x.Key} : {x.Value}"))}");
            var root = new InverterInfoResponse
            {
                Body = new Body
                {
                    Data = new Data
                    {
                        Inverter1 = new InverterInfo
                        {
                            DT = 0,
                            CustomName = "Inverter1",
                            ErrorCode = 0,
                            Show = 1,
                            PVPower = 5400,
                            StatusCode = 7,
                            UniqueID = "Kostal_PV_1"
                        },
                        Inverter2 = new InverterInfo
                        {
                            DT = 0,
                            CustomName = "Inverter2",
                            ErrorCode = 0,
                            Show = 1,
                            PVPower = 5400,
                            StatusCode = 7,
                            UniqueID = "Kostal_PV_2"
                        }
                    }
                },
                Head = new Head
                {
                    RequestArguments = new Requestarguments(),
                    Status = new Status
                    {
                        Code = 0,
                        Reason = "",
                        UserMessage = ""
                    },
                    Timestamp = DateTime.Now
                }
            };
            return root;
        }

        //[HttpGet]
        //[Route("GetInverterInfo")]
        //[Route("GetInverterInfo.cgi")]
        //public InverterInfoResponse GetInverterInfo()
        //{
        //    Logger.LogInformation("GET: GetInverterInfo");
        //    //Logger.LogInformation($"Form: {string.Join(",", Request.Form.Select(x => $"{x.Key} : {x.Value}"))}");
        //    Logger.LogInformation($"Query: {string.Join(",", Request.Query.Select(x => $"{x.Key} : {x.Value}"))}");

        //    var inverterInfo = new InverterInfoResponse()
        //    {
        //        Body = new InverterInfoResponse.ResponseBody
        //        {
        //            Data = new List<InverterInfo>
        //            {
        //                new InverterInfo
        //                {
        //                    CustomName = "CombinedKostal",

        //                }
        //            }
        //        },
        //        Head = new InverterInfoResponse.ResponseHeader
        //        {

        //        }
        //        //Id = 1,
        //        //UniqueId = "INVKOSTAL",
        //        //CustomName = "CombinedKostalInverters",
        //        //DeviceType = 192,
        //        //ErrorCode = 0,
        //        //StatusCode = 7
        //    };
        //    return inverterInfo;
        //}

        [HttpGet]
        [Route("getapiversion.cgi")]
        public ApiVersion GetApiVersion()
        {
            Logger.LogInformation("GET: GetApiVersion");
            Logger.LogInformation(Request.QueryString.ToString());
            var apiVersion = new ApiVersion
            {
                APIVersion = 1,
                BaseURL = "/solar_api/v1/",
                CompatibilityRange = "1.5 - 9"
            };
           
            return apiVersion;
        }

        [HttpGet]
        [Route("GetInverterRealtimeData.cgi")]
        public async Task<CommonInverterData> GetInverterRealtimeDataAsync(int deviceId = 1)
        {
            //var deviceId = Request.Query["deviceId"];
            // TODO request hier
            Logger.LogInformation("GET: GetInverterRealtimeData");
            KostalMeasurements inverterData = null;
            KostalTotalYieldsJson totalYieldsJson = null;
            string stringResponse = "";
            Dictionary<string, rootDeviceMeasurement> measurements = new Dictionary<string, rootDeviceMeasurement>();
            string baseIp = "http://192.168.178.31";
            if (deviceId == 2)
            {
                baseIp = "http://192.168.178.29";
            }
            else if (deviceId == 1)
            {
                baseIp = "http://192.168.178.31";
            }

            var stringResponseTask = HttpClient.GetStringAsync($"{baseIp}/measurements.xml");
            //monthjson = await HttpClient.GetFromJsonAsync<KostalMonthJson>($"{baseIp}/yields.json?month=1");
            var totalYieldsJsonTask = HttpClient.GetFromJsonAsync<KostalTotalYieldsJson>($"{baseIp}/yields.json?total=1");
            
            await Task.WhenAll(new Task[] { stringResponseTask, totalYieldsJsonTask });
            stringResponse = stringResponseTask.Result;
            totalYieldsJson = totalYieldsJsonTask.Result;

            if (!string.IsNullOrEmpty(stringResponse))
            {
                XmlSerializer xmlResponse = new XmlSerializer(typeof(KostalMeasurements));
                using (var streamReader = new StringReader(stringResponse))
                {
                    inverterData = (KostalMeasurements)xmlResponse.Deserialize(streamReader);
                }

                measurements = inverterData.Device.Measurements.ToDictionary(x => x.Type);
            }
            
            CommonInverterData data = new CommonInverterData()
            {
                Body = new CommonInverterDataBody
                {
                    Data = new CommonIverterDataData
                    {
                        DayEnergy = new ValueWithUnit()
                        {
                            Unit = "Wh",
                            Value = 0 // monthjson.MonthCurves.Datasets[0].Data[0].Data[DateTime.Today.Day - 1]
                        },
                        DeviceStatus = new DeviceStatus()
                        {
                            
                        },
                        FrequencyAC = new ValueWithUnit()
                        {
                            Unit = "Hz",
                            Value = measurements["AC_Frequency"].ValueSpecified ? (double)measurements["AC_Frequency"].Value : 50
                        },
                        IAC = new ValueWithUnit()
                        {
                            Unit = "A",
                            Value = measurements["AC_Current"].ValueSpecified ? (double)measurements["AC_Current"].Value : 0
                        },
                        //IDC = new ValueWithUnit()
                        //{
                        //    Unit = "A",
                        //    Value = measurements["DC_Current1"].ValueSpecified ? (double)measurements["DC_Current1"].Value : 0
                        //},
                        PAC = new ValueWithUnit()
                        {
                            Unit = "W",
                            Value = measurements["AC_Power"].ValueSpecified ? (double)measurements["AC_Power"].Value : 0
                        },
                        TOTAL_ENERGY = new ValueWithUnit()
                        {
                            Unit = "Wh",
                            Value = totalYieldsJson.TotalCurves.Datasets[0].Data.Sum(x => x.Data)
        },
                        UAC = new ValueWithUnit()
                        {
                            Unit = "V",
                            Value = measurements["AC_Voltage"].ValueSpecified ? (double)measurements["AC_Voltage"].Value : 230
                        },
                        //UDC = new ValueWithUnit()
                        //{
                        //    Unit = "V",
                        //    Value = measurements["DC_Voltage1"].ValueSpecified ? (double)measurements["DC_Voltage1"].Value : 0
                        //},
                        YEAR_ENERGY = new ValueWithUnit()
                        {
                            Unit = "Wh",
                            Value = totalYieldsJson.TotalCurves.Datasets[0].Data.Last().Data
                        }
                    }
                },
                Head = new Head
                {
                    RequestArguments = new Requestarguments(),
                    Status = new Status(),
                    Timestamp = DateTime.Now
                }
            };

            return data;
        }

        [HttpGet]
        [Route("GetSensorRealtimeData.cgi")]
        public InverterRealtimeData GetSensorRealtimeData()
        {
            Logger.LogInformation("GET: GetSensorRealtimeData");
            InverterRealtimeData data = new InverterRealtimeData();
            return data;
        }

        [HttpGet]
        [Route("GetActiveDeviceInfo.cgi")]
        public InverterRealtimeData GetActiveDeviceInfo()
        {
            Logger.LogInformation("GET: GetActiveDeviceInfo.cgi");
            InverterRealtimeData data = new InverterRealtimeData();
            return data;
        }
    }
}
