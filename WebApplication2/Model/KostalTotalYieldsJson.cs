using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Model
{
    public class KostalTotalYieldsJson
    {
        public Totalcurves TotalCurves { get; set; }
    }

    public class Totalcurves
    {
        public bool ShowVirtualDatasets { get; set; }
        public string Format { get; set; }
        public string Unit { get; set; }
        public string IncrementUnit { get; set; }
        public int IncrementStep { get; set; }
        public TotalDataset[] Datasets { get; set; }
    }

    
    public class TotalDataset
    {
        public string Type { get; set; }
        public TotalDatum[] Data { get; set; }
    }

    public class TotalDatum
    {
        public string Timestamp { get; set; }
        public int Data { get; set; }
    }

}
