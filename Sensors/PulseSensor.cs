using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IranianAgentInvestigation.Sensors
{
    public class PulseSensor:Sensor
    {
        public string sensorName { get; private set; }
        public string operation { get; private set; }
        public int counter{ get; private set; }
        
        public PulseSensor(string sensorName):base(sensorName)
        {
            this.sensorName = sensorName;
        }
        public override bool Activate(string weakness)
        {
            if (counter == null)
            {
                counter = 0;
            }
            counter++;
            if (weakness.ToLower() == sensorName)
            {
                return true;
            }

            return false;
        }
    }
}
