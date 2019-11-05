﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread6
{
    class Program
    {
        static void Main(string[] args)
        {
            var workerThread = new Thread(() =>
            {
                try
                {
                    Console.WriteLine("inizio di un thread molto lungo");
                    Thread.Sleep(5000);
                    Console.WriteLine("Termine worker thread");
                }
                catch (ThreadAbortException ex)
                {
                    Console.WriteLine("il thread viene cancellato");
                }


            });

            workerThread.IsBackground = false;
            workerThread.Priority = ThreadPriority.Lowest;
        }
    }
}
