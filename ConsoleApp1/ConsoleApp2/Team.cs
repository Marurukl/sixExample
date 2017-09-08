using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Team
    {
        private List<Worker> worker;
        private TeamLeader teamLeader;
        public void SetTeamMembers()
        {
            worker = new List<Worker>();
            teamLeader = new TeamLeader();
            worker.Add(new Worker());
            worker.Add(new Worker());
            worker.Add(new Worker());
            worker.Add(new Worker());
        }

    }
}
