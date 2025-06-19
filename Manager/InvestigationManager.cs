using IranianAgentInvestigation.Agent;
using IranianAgentInvestigation.Sensors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IranianAgentInvestigation.Manager
{
    public class InvestigationManager
    {
        public Sensor[] sensors { set; private get; }
        int suitable = 0;
        FactorySensors factorySensors = new FactorySensors();
        public void Menu()                      
        {
            IranianAgent iranianAgent = new IranianAgent();
            bool cond = true;
            sensors = new Sensor[iranianAgent.weaknesses.Length];
            do
            { 
                Console.WriteLine("What sensor do you want to add:");
                string sensorName = Console.ReadLine();
                sensorName = sensorName.ToLower();
                Sensor sensor;
                
                cond = ActivateSensors(iranianAgent,sensorName);
                
            }
            while (cond);
        }



        public bool ActivateSensors(IranianAgent iranianAgent,string sensorName)
        {
            int activeCount = suitable;
            for (int i = 0; i < suitable + 1; i++)
            {
                
                if (sensors[i] == null)
                {
                    if (sensorName == iranianAgent.weaknesses[i])
                    {
                        sensors[i] = factorySensors.CreatSensor(sensorName);
                        if (sensors[i].Activate(iranianAgent.weaknesses[i]))
                        {
                            activeCount++;
                        }
                    }
                }
                else
                {
                    sensors[i].Activate(iranianAgent.weaknesses[i]);
                }
                if (sensors[i] is PulseSensor pulse)
                {
                    Console.WriteLine("hi");
                    Console.WriteLine(pulse.counter);
                    if (pulse.counter >= 3)
                    {
                        sensors[i] = null;
                        activeCount--;
                    }
                }
                foreach(Sensor sensor in sensors)
                {
                    Console.WriteLine(sensor);
                }
                
                
                if (activeCount == iranianAgent.weaknesses.Length)
                {
                    break;
                }
                
            }
            suitable = activeCount;
            Console.WriteLine($"{activeCount}/{iranianAgent.weaknesses.Length}");
            if (suitable == iranianAgent.weaknesses.Length)
            {
                Console.WriteLine("The agent was exposed!!!");
                return false;
            }
            return true;
        }

        




    }
}
