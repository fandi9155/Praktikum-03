using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasClassdanObjeck
{
    class Program
    {
        static void Main(string[] args)
        {
          taxi taksi = new taxi();

            taksi.DriverName();
            taksi.OnDuty();
            taksi.NumberOfPpassenger();


            taksi.PickUpPassenger();
            taksi.DropOffPasengger();

            Console.ReadKey();
        }
    }
}
