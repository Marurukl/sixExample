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
        public void GenerateReport(List<IPart> houseParts)
        {
            double num = 0;
            for (int i = 0;i < houseParts.Count;i++)
            {
                if (VerifyPart(houseParts[i])==true)
                {
                    Console.WriteLine("Построена {0} часть дома ",houseParts[i].Name);
                    num++;
                }
                else
                {
                    Console.WriteLine("Еще не построена {0} часть дома ", houseParts[i].Name);
                }
            }
            //определение процента
            double numInPrecent = (num * 100) / houseParts.Count;
            if (numInPrecent == 100)
            {
                Console.WriteLine("Дом Был Завершен!");
                PrintHouse();

            }
            Console.WriteLine("Завершено {0}% дома", numInPrecent);
        }
    }
}
