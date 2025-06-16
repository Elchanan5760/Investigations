using IranianAgentInvestigation.Manager;

namespace Investigation
{
    public class Program
    {
        static public void Main(string[] args)
        {
            InvestigationManager manager = new InvestigationManager();
            manager.Menu();
        }
    }
}