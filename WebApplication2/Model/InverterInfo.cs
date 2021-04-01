using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Model
{

    public class InverterInfoResponse
    {
        [System.Text.Json.Serialization.JsonPropertyName("Body")]
        public Body Body { get; set; }
        [System.Text.Json.Serialization.JsonPropertyName("Head")]
        public Head Head { get; set; }
    }

    public class Head
    {
        [System.Text.Json.Serialization.JsonPropertyName("RequestArguments")]
        public Requestarguments RequestArguments { get; set; }
        [System.Text.Json.Serialization.JsonPropertyName("Status")]
        public Status Status { get; set; }
        [System.Text.Json.Serialization.JsonPropertyName("Timestamp")]
        public DateTime Timestamp { get; set; } = DateTime.Now;
    }

    public class Requestarguments
    {
    }

    public class Status
    {
        [System.Text.Json.Serialization.JsonPropertyName("Code")]
        public int Code { get; set; }
        [System.Text.Json.Serialization.JsonPropertyName("Reason")]
        public string Reason { get; set; } = "";
        [System.Text.Json.Serialization.JsonPropertyName("UserMessage")]
        public string UserMessage { get; set; } = "";
    }

    public class Body
    {
        [System.Text.Json.Serialization.JsonPropertyName("Data")]
        public Data Data { get; set; }
    }

    public class Data
    {
        [System.Text.Json.Serialization.JsonPropertyName("1")]
        public InverterInfo Inverter1 { get; set; }
        [System.Text.Json.Serialization.JsonPropertyName("2")]
        public InverterInfo Inverter2 { get; set; }
    }


    public class InverterInfo
    {
        [System.Text.Json.Serialization.JsonPropertyName("DT")]
        public int DT { get; set; }
        [System.Text.Json.Serialization.JsonPropertyName("PVPower")]
        public int PVPower { get; set; }
        [System.Text.Json.Serialization.JsonPropertyName("Show")]
        public int Show { get; set; }
        [System.Text.Json.Serialization.JsonPropertyName("UniqueID")]
        public string UniqueID { get; set; }
        [System.Text.Json.Serialization.JsonPropertyName("ErrorCode")]
        public int ErrorCode { get; set; }
        [System.Text.Json.Serialization.JsonPropertyName("StatusCode")]
        public int StatusCode { get; set; }
        [System.Text.Json.Serialization.JsonPropertyName("CustomName")]
        public string CustomName { get; set; }
    }

    
}
