using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Model
{

    public class Rootobject
    {
        public Head Head { get; set; }
        public Body Body { get; set; }
    }

    public class Head
    {
        public Requestarguments RequestArguments { get; set; }
        public Status Status { get; set; }
        public DateTime Timestamp { get; set; }
    }

    public class Requestarguments
    {
    }

    public class Status
    {
        public int Code { get; set; }
        public string Reason { get; set; }
        public string UserMessage { get; set; }
    }

    public class Body
    {
        public Data Data { get; set; }
    }

    public class Data
    {
        [System.Text.Json.Serialization.JsonPropertyName("1")]
        public _1 _1 { get; set; }
    }

    public class _1
    {
        public int DT { get; set; }
        public int PVPower { get; set; }
        public int Show { get; set; }
        public string UniqueID { get; set; }
        public int ErrorCode { get; set; }
        public int StatusCode { get; set; }
        public string CustomName { get; set; }
    }

    
}
