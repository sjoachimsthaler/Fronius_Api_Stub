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
        public InverterInfo GetInverterInfo()
        {
            Logger.LogInformation("GET: GetInverterInfo");
            var inverterInfo = new InverterInfo()
            {
                Id = 1,
                UniqueId = "INVKOSTAL",
                CustomName = "CombinedKostalInverters",
                DeviceType = 192,
                ErrorCode = 0,
                StatusCode = 7
            };
            return inverterInfo;
        }

        [HttpGet]
        [Route("getapiversion.cgi")]
        public ApiVersion GetApiVersion()
        {
            Logger.LogInformation("GET: GetInverterInfo");
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
            Logger.LogInformation("GET: GetInverterInfo");
            InverterRealtimeData data = new InverterRealtimeData();
            return data;
        }
    }
}
