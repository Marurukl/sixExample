using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student : IStudent
    {
        int[] arr;
        int count = 0;
        int size = 20;
        public string Name
        {
            get; set;
        }
        public string FullName
        {
            get; set;
        }

        public int[] Grades
        {
            get
            {
                return arr;
            }
            set
            {
                arr = new int[size];
                arr[count] = value[0];
                count++;
            }

        }

        public double GetAvgGrade()
        {
            double avgGrade;
            int allRatings = 0;

            for (int i = 0; i <= size; i++)
            {
                allRatings += arr[i];
            }
            avgGrade = allRatings / size;
            return avgGrade;
        }

        public string GetFullName()
        {
            Console.WriteLine(FullName);
            return FullName;
        }

        public string GetName()
        {
            Console.WriteLine(Name);
            return Name;
        }
    }
}
