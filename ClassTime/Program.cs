using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //ctor
            Time x = new Time(23, 59, 59),
                y = new Time(3, 59, 39);


            //TimeToString
            Console.WriteLine("x = {0}", x.ToString());
            Console.WriteLine("y = {0}\n", y.ToString());


            //To hour, minute and second
            Console.WriteLine($"Hour in x = {x.ToHour()}");
            Console.WriteLine($"Minute in x = {x.ToMinute()}");
            Console.WriteLine($"Second in x = {x.ToSecond()}");
            Console.WriteLine($"Second in x = {x.Second}");



            //Set x
            x.Hour = 22;
            x.Minute = 23;
            x.Second = 21;
            Console.WriteLine("Set x = {0}\n", x.ToString());



            //x+y and x-y
            Console.WriteLine("x + y = {0}", (x + y).ToString());
            Console.WriteLine("x - y = {0}\n", (x - y).ToString());



            //Add
            x.Add_H(100);
            Console.WriteLine("x + 100 hours = {0}", x.ToString());
            x.Add_M(1000);
            Console.WriteLine("x + 1000 minutes = {0}", x.ToString());
            x.Add_S(100000);
            Console.WriteLine("x + 100000 seconds = {0}\n", x.ToString());



            //Sub
            x.Sub_H(100);
            Console.WriteLine("x - 100 hours = {0}", x.ToString());
            x.Sub_M(1000);
            Console.WriteLine("x - 1000 minutes = {0}", x.ToString());
            x.Sub_S(100000);
            Console.WriteLine("x - 100000 seconds = {0}", x.ToString());


            //Logical operations
            Console.WriteLine((x == y) ? "x == y" : "x != y");
            Console.WriteLine((x > y) ? "x > y" : "x < y");
            Console.WriteLine((x >= y) ? "x >= y" : "x <= y");


            Console.ReadKey();
        }
    }
}
