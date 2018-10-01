using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TaskParallelProgram
{
    class TPLClass1
    {
        static void Main(string[] args)
        {
            Task t1 = new Task(() => DoWork(1, 1000));
            t1.Start();
            Task t2 = new Task(() => DoWork(2, 3000));
            t2.Start();
            Task t3 = new Task(() => DoWork(3, 1500));
            t3.Start();

            Console.ReadLine();
        }
        static void DoWork(int id , int sleep)
        {
            Console.WriteLine("Task {0} is beginning...", id);
            Thread.Sleep(sleep);
            Console.WriteLine("Task {0} is completed...", id);
        }
    }
}
