using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IranianAgentInvestigation.Sensors
{
    public class Sensor
    {
        public string sensorName { get; private set; }
        public string operation { get; private set; }
        public Sensor(string sensorName)
        {
            this.sensorName = sensorName;
        }
        
    }
}
