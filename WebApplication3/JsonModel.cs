using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3
{

    public class Rootobject
    {
        public Daycurves DayCurves { get; set; }
    }

    public class Daycurves
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
        public int Default { get; set; }
        public Datum[] Data { get; set; }
    }

    public class Datum
    {
        public string Timestamp { get; set; }
        public int Offset { get; set; }
        public int Total { get; set; }
        public int[] Data { get; set; }
    }
}
