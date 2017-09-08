using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class TeamLeader:IWorker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Salary { get; set; }
        public bool VerifyPart(IPart part)
        {
            return part.IsBuilt;
        }
        
    }
}
