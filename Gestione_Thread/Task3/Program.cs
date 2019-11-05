using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var resultTask =Task.Factory.StartNew((inputvalue)=>
            PerformSomeLongCalulation(inputvalue), 5000D);

            Console.WriteLine("il risultato è {0}", resultTask.Result);

            
        }

        private static void PerformSomeLongCalulation(object inputvalue)
        {
            throw new NotImplementedException();
        }
    }
}
