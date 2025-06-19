using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IranianAgentInvestigation.Sensors
{
    public class FactorySensors
    {
        public Sensor CreatSensor(string sensorName)
        {
            switch (sensorName)
            {
                case "basic":
                    return new Sensor(sensorName);
                case "pulse":
                    return new PulseSensor(sensorName);
                default:
                    return null;
            }
        }
    }
}
