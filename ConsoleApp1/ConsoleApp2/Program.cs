using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Team team = new Team();
            House house = new House();
            int operationForHome = (house.GetHouseCount() / team.GetWorkerCount());
            for (int i=0;i < operationForHome ; i++)
            {
                Console.WriteLine("_________________________________");
                team.BuildHouse(house.GetHouseParts());
                Console.WriteLine("  ");
            }
            Console.ReadLine();
        }
    }
}
