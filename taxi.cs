using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasClassdanObjeck
{
    class taxi
    {
        string nama;
        int nomor;
        int duty;

        public void DriverName()
        {
            Console.WriteLine("Driver Name : jono");
        }

        public void OnDuty()
        {
            Console.WriteLine("On Duty : Yes");
        }

        public void NumberOfPpassenger()
        {
            Console.WriteLine("Number Of Passenger : 10");
        }

        public void PickUpPassenger()
        {
            Console.WriteLine("jono Sedang Menjemput Penumpang");
        }

        public void DropOffPasengger()
        {
            Console.WriteLine("jono Sedang Mengantar Penumpang");
        }


    }
}
