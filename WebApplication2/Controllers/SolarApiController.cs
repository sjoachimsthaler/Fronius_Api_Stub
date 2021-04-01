using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public SolarApiController(ILogger<SolarApiController> logger)
        {
            Logger = logger;
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
        public CommonInverterData GetInverterRealtimeData(int deviceId)
        {
            //var deviceId = Request.Query["deviceId"];
            // TODO request hier
            Logger.LogInformation("GET: GetInverterRealtimeData");

            
            CommonInverterData data = new CommonInverterData()
            {
                Body = new CommonInverterDataBody
                {
                    Data = new CommonIverterDataData
                    {
                        DayEnergy = new ValueWithUnit()
                        {
                            Unit = "Wh",
                            Value = 0
                        },
                        DeviceStatus = new DeviceStatus()
                        {
                            
                        },
                        FrequencyAC = new ValueWithUnit()
                        {
                            Unit = "Hz",
                            Value = 50.0
                        },
                        IAC = new ValueWithUnit()
                        {
                            Unit = "A",
                            Value = 0
                        },
                        IDC = new ValueWithUnit()
                        {
                            Unit = "A",
                            Value = 0
                        },
                        PAC = new ValueWithUnit()
                        {
                            Unit = "W",
                            Value = 0
                        },
                        TOTAL_ENERGY = new ValueWithUnit()
                        {
                            Unit = "Wh",
                            Value = 0
                        },
                        UAC = new ValueWithUnit()
                        {
                            Unit = "V",
                            Value = 230
                        },
                        UDC = new ValueWithUnit()
                        {
                            Unit = "V",
                            Value = 0
                        },
                        YEAR_ENERGY = new ValueWithUnit()
                        {
                            Unit = "Wh",
                            Value = 0
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

            if (deviceId == 1)
            {
                data.Body.Data.PAC.Value = 0;
            }
            else if (deviceId == 2)
            {
                data.Body.Data.PAC.Value = 0;
            }
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
