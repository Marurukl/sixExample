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
        public Team()
        {
            worker = new List<Worker>();
            teamLeader = new TeamLeader();
            worker.Add(new Worker());
            worker.Add(new Worker());
            worker.Add(new Worker());
            worker.Add(new Worker());
        }
        public int GetWorkerCount()
        {
            return worker.Count;
        }
        public void PrintHouse()
        {
            string domik = @"
                           (   )
                          (    )
                           (    )
                          (    )
                            )  )
                           (  (                  /\
                            (_)                 /  \  /\
                    ________[_]________      /\/    \/  \
           /\      /\        ______    \    /   /\/\  /\/\
          /  \    //_\       \    /\    \  /\/\/    \/    \
   /\    / /\/\  //___\       \__/  \    \/
  /  \  /\/    \//_____\       \ |[]|     \
 /\/\/\/       //_______\       \|__|      \
/      \      /XXXXXXXXXX\                  \
        \    /_I_II  I__I_\__________________\
               I_I|  I__I_____[]_|_[]_____I
               I_II  I__I_____[]_|_[]_____I
               I II__I  I     XXXXXXX     I
            ~~~~~'   '~~~~~~~~~~~~~~~~~~~~~~~~";

            Console.WriteLine(domik);
        }
        public void BuildHouse(List<IPart> houseParts)
        {
            Console.WriteLine("Строители Приступили к работе ");
            for (int i = 0, j = 0; i < houseParts.Count; i++, j++)
            {
                if (j == worker.Count)
                {
                    j = 0;
                }
                else if (j <= worker.Count)
                {
                    if (i >= houseParts.Count)
                    {
                        Console.WriteLine("Дом Был Завершен!");
                        break;
                    }
                    if (worker[j].CheckPart(houseParts[i]) == true)
                    {
                        i++;
                    }
                    else if (worker[j].CheckPart(houseParts[i]) == false)
                    {
                        Console.WriteLine("Сторитель №{0} стороит {1} дома", j+1, houseParts[i].Name);
                        worker[j].BuiltPart(houseParts[i]);

                    }
                }
                
            }
            if (teamLeader != null)
            {
                teamLeader.GenerateReport(houseParts);
            }
        }
    }
}

