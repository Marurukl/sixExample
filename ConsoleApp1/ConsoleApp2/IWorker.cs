using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public interface IWorker
    {
        int Id { get; set; }
        string Name { get; set; }
        string SurName { get; set; }
        int Salary { get; set; }

    }
}
