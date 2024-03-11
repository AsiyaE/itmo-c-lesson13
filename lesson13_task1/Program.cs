using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson13_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Building b1 = new Building("ул. Варшавская д. 17", 30, 20, 50);
            Console.WriteLine(b1.Print());


            MultiBuilding mb1 = new MultiBuilding("ул. Ленсовета д. 17", 40, 20, 60, 7);
            Console.WriteLine(mb1.Print());
            Console.WriteLine(mb1.FloorNumber);

            Console.ReadKey();
        }
    }
}
