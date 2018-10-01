using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TaskParallelProgram
{
    class TPLClass3
    {
        static void Main(string[] args)
        {
            Task t1 = Task.Factory.StartNew(() => DoWork(1, 1000)).ContinueWith((prev) => DoOtherWork(1, 3000));
            // through factory it start automically don't write for t1.start();
            Task t2 = Task.Factory.StartNew(() => DoWork(2, 2000)).ContinueWith((prev) => DoOtherWork(2, 2000));

            Task t3 = Task.Factory.StartNew(() => DoWork(3, 1500)).ContinueWith((prev) => DoOtherWork(3, 1000));

            Console.ReadLine();
        }
        static void DoWork(int id, int sleep)
        {
            Console.WriteLine("Task {0} is beginning...", id);
            Thread.Sleep(sleep);
            Console.WriteLine("Task {0} is completed...", id);
        }
        static void DoOtherWork(int id, int sleep)
        {
            Console.WriteLine("OtherTask {0} is beginning...", id);
            Thread.Sleep(sleep);
            Console.WriteLine("OtherTask {0} is completed...", id);
        }
    }
}
