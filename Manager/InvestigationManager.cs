using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IranianAgentInvestigation.Sensors;
using IranianAgentInvestigation.Agent;

namespace IranianAgentInvestigation.Manager
{
    public class InvestigationManager
    {
        public Sensor[] sensors { set; private get; }
        public void Menu()                      
        {
            IranianAgent iranianAgent = new IranianAgent();
            bool cond = true;
            int index = 0;
            Sensor[] sensors = new Sensor[iranianAgent.weaknesses.Length];
            do
            {
                
                Console.WriteLine("What sensor do you want to add:");
                string sensorName = Console.ReadLine();
                Sensor sensor = new Sensor(sensorName);
                if (sensor.Activate(iranianAgent.weaknesses[index]))
                {
                    sensors[index] = sensor;
                    Console.WriteLine(sensor.sensorName);
                    index++;
                }
                
                Console.WriteLine($"{index}/{iranianAgent.weaknesses.Length}");
                if (index == iranianAgent.weaknesses.Length)
                {
                    foreach (Sensor sensor1 in sensors)
                    {
                        Console.WriteLine($"{sensor1.sensorName}");
                    }
                    Console.WriteLine("The agent was exposed!!!");
                    cond = false;
                }
            }
            while (cond);
        }
                
            

        
    }
}
