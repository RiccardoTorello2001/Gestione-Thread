using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread5
{
    class Program
    {
        static void Main(string[] args)
        {
            var workerThread = new Thread(() =>
            {
                  Console.WriteLine("inizio di un thread molto lungo");
                  Thread.Sleep(5000);
                  Console.WriteLine("Termine worker thread");
  
            });

            workerThread.Start();
            workerThread.Join(500);

            if(workerThread.ThreadState!=ThreadState.Stopped)
            {
                workerThread.Abort();
            }

            Console.WriteLine("Termina applicazione");

            var workerThread1 = new Thread(() =>
            {
                try
                {
                    Console.WriteLine("inizio di un thread molto lungo");
                    Thread.Sleep(5000);
                    Console.WriteLine("Termine worker thread");
                }
                catch (ThreadAbortException ex)
                {

                }


            });

            workerThread1.IsBackground = false;
            workerThread1.Priority = ThreadPriority.Lowest;


        }
    }
}
