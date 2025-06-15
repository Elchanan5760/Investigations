using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IranianAgentInvestigation.Agent
{
    public class JuniorIranianAgent
    {
        public string[] weaknesses { get; private set; }
        public JuniorIranianAgent(string weaknes1, string weaknes2)
        {
            weaknesses[0] = weaknes1;
            weaknesses[1] = weaknes2;
        }
    }
}
