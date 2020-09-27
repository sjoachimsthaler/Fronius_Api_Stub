using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Model
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class ApiVersion
    {
        public int APIVersion { get; set; }
        public string BaseURL { get; set; }
        public string CompatibilityRange { get; set; }
    }


}
