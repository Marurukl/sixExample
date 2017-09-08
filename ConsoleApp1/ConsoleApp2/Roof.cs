using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Roof:IPart
    {
        private bool isBuilt = false;
        string name = "Крыша";
        public int Id { get; set; }

        public string Name => name;

        public bool IsBuilt { get => isBuilt; set => isBuilt = value; }
    }
}
