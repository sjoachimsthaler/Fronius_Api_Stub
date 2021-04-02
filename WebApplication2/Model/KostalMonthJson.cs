using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Model
{
    public class KostalMonthJson
    {
        public Monthcurves MonthCurves { get; set; }
    }

    public class Monthcurves
    {
        public bool ShowVirtualDatasets { get; set; }
        public string Format { get; set; }
        public string Unit { get; set; }
        public string IncrementUnit { get; set; }
        public int IncrementStep { get; set; }
        public Dataset[] Datasets { get; set; }
    }

    public class Dataset
    {
        public string Type { get; set; }
        public Datum[] Data { get; set; }
    }

    public class Datum
    {
        public string Timestamp { get; set; }
        public int[] Data { get; set; }
    }

}
