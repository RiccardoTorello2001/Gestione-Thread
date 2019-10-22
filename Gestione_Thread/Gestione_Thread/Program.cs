using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Gestione_Thread
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread myThread = new Thread(() =>
            {
                  Console.WriteLine("myThread è iniziato");
                  Thread.Sleep(3000);
                  Console.WriteLine("MyThread è terminato");
            });


            myThread.Start();

            Thread.Sleep(500);

            Console.WriteLine("Main Thread");

            
            Console.ReadLine();
        }
    }
}
