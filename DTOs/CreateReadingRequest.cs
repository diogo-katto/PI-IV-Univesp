using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IoTMonitor.DTOs
{
    public class CreateReadingRequest
    {
        public double Humidity { get; set; }
        public double Temperature { get; set; }
    }
}