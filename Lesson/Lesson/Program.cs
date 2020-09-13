using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson
{
    class Program
    {
        static void Main(string[] args) {
            int a = 4;
            int b = 6;

            Console.WriteLine("Instal a :" + a);
            Console.WriteLine("Instal b :" + b);

            b = a;

            Console.WriteLine("After b=a is :" + b);

            a = 400;

            Console.WriteLine("Final a :" + a);
            Console.WriteLine("Final b :" + b);

            Console.WriteLine("---------------------------------------------------------------------------");

            List<int> list1 = new List<int>() { 1, 2, 3, 4, 4 };
            List<int> list2;

            list2 = list1;

            Console.WriteLine(list1[2]);
            Console.WriteLine(list2[2]);

            list1.RemoveAt(0);

            Console.WriteLine(list1[2]);
            Console.WriteLine(list2[2]);

            Console.ReadLine();
        }
    }
}
