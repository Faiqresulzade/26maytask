using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Student
    {
        public int[] grades;
        public int [] Grades
        {
            get
            {
                return grades;
            }
            set
            {
                int counter = 1;
                int j = 0;
                int[] grades = new int[counter];

                for (int i = 0; i < value.Length; i++)
                {
                    if (value[i] % 2 == 0)
                    {
                        grades[j] = value[i];
                        counter++;
                        foreach (var item in grades)
                        {
                            Console.WriteLine(item);
                        }
                    }               
                }
            }
        }

    }
}
