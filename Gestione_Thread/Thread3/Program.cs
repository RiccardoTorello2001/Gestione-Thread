using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread3
{
    class Program
    {
        static void Main(string[] args)
        {

            string someVariabile1 = "Riccardo Torello";
            var workerThread1 = new Thread(() =>
            {
                Thread.Sleep(500);
                Console.WriteLine("Saluti da:{0}", someVariabile1);
            });


            workerThread1.Start();


            someVariabile1 = "Daniele bochicchio";
            Console.ReadLine();
        }
    }
}
