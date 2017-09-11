using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class House
    {
        private List<IPart> houseParts;
        public House()
        {
            houseParts = new List<IPart>();
            houseParts.Add(new Basement());
            houseParts.Add(new Walls());
            houseParts.Add(new Walls());
            houseParts.Add(new Walls());
            houseParts.Add(new Walls());
            houseParts.Add(new Door());
            houseParts.Add(new Window());
            houseParts.Add(new Window());
            houseParts.Add(new Window());
            houseParts.Add(new Window());
            houseParts.Add(new Roof());
        }
        public List<IPart> GetHouseParts()
        {
            return houseParts;
        }
        public int GetHouseCount()
        {
            return houseParts.Count;
        }
        public IPart this[int index]
        {
            get
            {
                return houseParts.ElementAt(index);
            }
            
        }
    }
}
