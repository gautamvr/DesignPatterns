using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class ScanTimer
    {
        public void StartTimer()
        {
            Console.WriteLine("Timer is started");

        }

        public void StopTimer()
        {
            Console.WriteLine("Timer is stopped");
        }
    }
}
