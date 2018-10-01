using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TaskParallelProgram
{
    class TPLClass2
    {
        static void Main(string[] args)
        {
            Task t1 = Task.Factory.StartNew(() => DoWork(1, 1000));
            // through factory it start automically don't write for t1.start();
            Task t2 = Task.Factory.StartNew(() => DoWork(2, 2000));

            Task tt3 = Task.Factory.StartNew(() => DoWork(3, 1500));

            Console.ReadLine();
        }
        static void DoWork(int id, int sleep)
        {
            Console.WriteLine("Task {0} is beginning...", id);
            Thread.Sleep(sleep);
            Console.WriteLine("Task {0} is completed...", id);
        }
    }
}
