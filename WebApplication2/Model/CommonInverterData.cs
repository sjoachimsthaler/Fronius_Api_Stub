using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebApplication2.Model
{
    public class CommonInverterData
    {
        [JsonPropertyName("Body")]
        public CommonInverterDataBody Body { get; set; }

        [JsonPropertyName("Head")]
        public Head Head { get; set; }
    }

    public class CommonInverterDataBody
    {
        [JsonPropertyName("Data")]
        public CommonIverterDataData  Data { get; set; }
    }

    public class CommonIverterDataData
    {
        [JsonPropertyName("DAY_ENERGY")]
        public ValueWithUnit DayEnergy { get; set; }
        [JsonPropertyName("DeviceStatus")]
        public DeviceStatus DeviceStatus { get; set; }
        [JsonPropertyName("FAC")]
        public ValueWithUnit FrequencyAC { get; set; }
        [JsonPropertyName("IAC")]
        public ValueWithUnit IAC { get; set; }
        [JsonPropertyName("IDC")]
        public ValueWithUnit IDC { get; set; }
        [JsonPropertyName("PAC")]
        public ValueWithUnit PAC { get; set; }
        [JsonPropertyName("TOTAL_ENERGY")]
        public ValueWithUnit TOTAL_ENERGY { get; set; }
        [JsonPropertyName("UAC")]
        public ValueWithUnit UAC { get; set; }
        [JsonPropertyName("UDC")]
        public ValueWithUnit UDC { get; set; }
        [JsonPropertyName("YEAR_ENERGY")]
        public ValueWithUnit YEAR_ENERGY { get; set; }
    }

    public class ValueWithUnit
    {
        [JsonPropertyName("Unit")]
        public string Unit { get; set; } = "Wh";
        [JsonPropertyName("Value")]
        public double Value { get; set; } = 0.0;
    }

    public class DeviceStatus
    {
        [JsonPropertyName("ErrorCode")]
        public int ErrorCode { get; set; } = 0;
        [JsonPropertyName("LEDColor")]
        public int LedColor { get; set; } = 2;
        [JsonPropertyName("LEDState")]
        public int LedState { get; set; } = 0;
        [JsonPropertyName("MgmtTimerRemainingTime")]
        public int MgmtTimerRemainingTime { get; set; } = -1;
        [JsonPropertyName("StateToReset")]
        public bool StateToReset { get; set; } = false;
        [JsonPropertyName("StatusCode")]
        public int StatusCode { get; set; } = 7;
    }

    // "Data" : {
    //"DAY_ENERGY" : {
    //"Unit" : "Wh",
    //"Value" : 1393.2
    //},
    //"DeviceStatus" : {
    //    "ErrorCode" : 0,
    //"LEDColor" : 2,
    //"LEDState" : 0,
    //"MgmtTimerRemainingTime" : -1,
    //"StateToReset" : false ,
    //"StatusCode" : 7
    //},
    //"FAC" : {
    //    "Unit" : "Hz",
    //"Value" : 49.969999999999999
    //},
    //"IAC" : {
    //    "Unit" : "A",
    //"Value" : 0.35999999999999999
    //},
    //"IDC" : {
    //    "Unit" : "A",
    //"Value" : 0.32000000000000001
    //},
    //"PAC" : {
    //    "Unit" : "W",
    //"Value" : 84
    //},
    //"TOTAL_ENERGY" : {
    //    "Unit" : "Wh",
    //"Value" : 1734796.1200000001
    //},
    //"UAC" : {
    //    "Unit" : "V",
    //"Value" : 232.40000000000001
    //},
    //"UDC" : {
    //    "Unit" : "V",
    //"Value" : 399.89999999999998
    //},
    //"YEAR_ENERGY" : {
    //    "Unit" : "Wh",
    //"Value" : 322593.5
    //}
    //}
    //},
    //"Head" : {
    //    "RequestArguments" : {
    //        "DataCollection" : "CommonInverterData",
    //"DeviceClass" : "Inverter",
    //"DeviceId" : "1",
    //"Scope" : "Device"
    //    },
    //"Status" : {
    //        "Code" : 0,
    //"Reason" : "",
    //"UserMessage" : ""
    //},
    //"Timestamp" : "2019-06-12T15:31:03+02:00"
    //}
    //}
}
