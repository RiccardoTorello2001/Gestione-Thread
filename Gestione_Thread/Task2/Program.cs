using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var resultTask=new Task((inputvalue)=>
            PerformSomeLongCalulation(inputvalue), 5000D);

            resultTask.Start();
        }

        private static void PerformSomeLongCalulation(object inputvalue)
        {
            throw new NotImplementedException();
        }
    }
}
