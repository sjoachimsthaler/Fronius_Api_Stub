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
        public Rootobject GetInverterInfo()
        {
            Logger.LogInformation("GET: GetInverterInfo");
            //Logger.LogInformation($"Form: {string.Join(",", Request.Form.Select(x => $"{x.Key} : {x.Value}"))}");
            var root = new Rootobject
            {
                Body = new Body
                {
                    Data = new Data
                    {
                        _1 = new _1
                        {
                            DT = 123,
                            CustomName = "Test",
                            ErrorCode = 0,
                            Show = 1,
                            PVPower = 5400,
                            StatusCode = 7,
                            UniqueID = "476"
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
        public InverterRealtimeData GetInverterRealtimeData()
        {
            Logger.LogInformation("GET: GetInverterRealtimeData");
            InverterRealtimeData data = new InverterRealtimeData();
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
