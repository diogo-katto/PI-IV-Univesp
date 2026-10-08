using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IoTMonitor.Models
{
    public class Reading
    {
        public int Id { get; set; }
        public double Humidity { get; set; }
        public double Temperature { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}