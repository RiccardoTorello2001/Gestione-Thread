using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var simpleTask = Task.Factory.StartNew(() =>
            {
                  Thread.Sleep(1000);
                  Console.WriteLine("Ciao da simpleTask");
            });

            var parameterTask = Task.Factory.StartNew((name) =>
            {
                  Thread.Sleep(1000);
                  Console.WriteLine("Ciao da parameterTask,{0}", name);
            }, "Matteo Tumiati");

            var resultTask = Task.Factory.StartNew((inputValue) =>
              PerformSomeLongCalulation(inputValue), 5000D);
        }

        private static void PerformSomeLongCalulation(object inputValue)
        {
            throw new NotImplementedException();
        }
    }
}
