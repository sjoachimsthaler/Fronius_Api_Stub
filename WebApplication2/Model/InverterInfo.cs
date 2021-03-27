using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Model
{
    public class InverterInfoResponse
    {
        public ResponseBody Body { get; set; }
        public ResponseHeader Head { get; set; }


        public class ResponseBody
        {
            public List<InverterInfo> Data { get; set; }
        }

        public class ResponseHeader
        {
            public List<string> RequestArguments { get; set; }

            public DateTime Timestamp { get; set; } = DateTime.Now;
            public string Reason { get; set; }
            public string UserMessage { get; set; }
            public Status Status { get; set; }
            //{
            //        "RequestArguments" : { },
            //"Status" : {
            //            "Code" : 0,
            //"Reason" : "",
            //"UserMessage" : ""
            //},
            //"Timestamp" : "2019-08-28T07:47:43+00:00"
            //}
        }
    }

    public class Status
    {
        public int Code { get; set; } = 0;
    }


    /// <summary>
    /// 
    /// </summary>
    public class InverterInfo
    {
        public string CustomName { get; set; }
        public int DT { get; set; } = 1;
        public int PVPower { get; set; } = 0;
        public int Show { get; set; } = 1;
        public string StatusCode { get; set; } = "Running";
        //"CustomName" : "tr-3pn -01",
//"DT" : 1,
//"PVPower" : 0,
//"Show" : 1,
//"StatusCode" : "Running",
//"UniqueID" : "29301000987160033"

        ///// <summary>
        /////  This id is unique only within the DATCOM chain is used to address
        /////	inverters within this chain. Use this ID in the FroniusSolarApi where
        /////	a deviceId is required.
        ///// </summary>
        //public int Id { get; set; }
        ///// <summary>
        ///// Unique ID of the inverter (serial number?)
        ///// </summary>
        //public string UniqueId { get; set; }
        //public string CustomName { get; set; }
        ///// <summary>
        /////  Type of the device. This value is not documented,
        /////	but inverters seem to have value 192. Also seen 123 on an 3 phase
        /////	inverter.
        ///// </summary>
        //public int DeviceType { get; set; }
        ///// <summary>
        ///// -1	No _valid_ error code
        /////	 0	OK
        ///// </summary>

        //public int ErrorCode { get; set; }
        ///// <summary>
        ///// 0-6	Startup
        /////	7	Running
        /////	8	Standby
        /////	9	Boot loading
        /////	10	Error
        ///// </summary>
        //public int StatusCode { get; set; }

        //struct InverterInfo
        //{
        //	/*!
        //	 * @brief The id of the inverter.
        //	 * This id is unique only within the DATCOM chain is used to address
        //	 * inverters within this chain. Use this ID in the FroniusSolarApi where
        //	 * a deviceId is required.
        //	 */
        //	int id;
        //	/*!
        //	 * @brief uniqueId Unique ID of the inverter (serial number?)
        //	 */
        //	QString uniqueId;
        //	/*!
        //	 * @brief customName Name of the inverted as assigned by the user.
        //	 * May be empty.
        //	 */
        //	QString customName;
        //	/*!
        //	 * @brief deviceType Type of the device. This value is not documented,
        //	 * but inverters seem to have value 192. Also seen 123 on an 3 phase
        //	 * inverter.
        //	 */
        //	int deviceType;
        //	/*!
        //	 * @brief errorCode
        //	 * -1	No _valid_ error code
        //	 *  0	OK
        //	 */
        //	int errorCode;
        //	/*!
        //	 * @brief statusCode
        //	 * 0-6	Startup
        //	 * 7	Running
        //	 * 8	Standby
        //	 * 9	Boot loading
        //	 * 10	Error
        //	 */
        //	int statusCode;
        //};
    }
}


//{
//    "Body" : {
//        "Data" : {
//            "1" : {
//                "CustomName" : "tr-3pn -01",
//"DT" : 1,
//"PVPower" : 0,
//"Show" : 1,
//"StatusCode" : "Running",
//"UniqueID" : "29301000987160033"
//            }
//        }
//    },
//"Head" : {
//        "RequestArguments" : { },
//"Status" : {
//            "Code" : 0,
//"Reason" : "",
//"UserMessage" : ""
//},
//"Timestamp" : "2019-08-28T07:47:43+00:00"
//}
//}