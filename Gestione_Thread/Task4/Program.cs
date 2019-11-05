using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            var mytask = Task.Factory.StartNew(SomeMethod);
            mytask.Wait();

            mytask = Task.Factory.StartNew(SomeMethod);
            mytask.Wait(1000);

            mytask = Task.Factory.StartNew(SomeMethod);
            var anotherTask = Task.Factory.StartNew(SomeMethod);
            Task.WaitAny(mytask, anotherTask);

            List<Task> tasklist = GetTaskList();
            Task.WaitAll(tasklist.ToArray(), 2000);

        }

        private static List<Task> GetTaskList()
        {
            throw new NotImplementedException();
        }

        private static void SomeMethod()
        {
            throw new NotImplementedException();
        }
    }
}
