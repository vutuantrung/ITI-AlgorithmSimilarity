using System;
using System.Collections.Generic;
using System.Text;

namespace OptimisationAlgorithm.Class
{
    public class Schedule
    {
        public string DepartAirportCode { get; set; }

        public string ArrivedAirportCode { get; set; }

        public float DepartTime { get; set; }

        public float ArrivedTime { get; set; }

        public int Price { get; set; }
    }
}
