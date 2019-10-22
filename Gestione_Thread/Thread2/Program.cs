using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread2
{
    class Program
    {
        static void Main(string[] args)
        {

            string someVariabile = "Matteo Tumiati";

            var workerThread = new Thread((o) =>
              {
                  Console.WriteLine("Saluti da:{0}", o);
              });



            workerThread.Start(someVariabile);

            Console.ReadLine();

        }
    }
}
