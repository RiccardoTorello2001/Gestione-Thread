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
                  Thread.Sleep(500);
                  Console.WriteLine("Termine worker thread");
  
            });

            workerThread.Start();
            workerThread.Join(500);

            if(workerThread.ThreadState!=ThreadState.Stopped)
            {

            }
        }
    }
}
