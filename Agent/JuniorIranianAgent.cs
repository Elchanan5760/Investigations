using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace IranianAgentInvestigation.Agent
{
    public abstract class IranianAgent
    {
        public abstract int id { get; set; }
        public abstract string name { get; set; }
        public abstract string rank { get; set; }
        public abstract string[] weaknesses { get; set; }
    }
}
