using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace TaskParallelProgram
{
    class CallMethodClass
    {
        static void Main(string[] args)
        {
             
           
            Task task = new Task(() => Workload());
            task.Start();

            //waiting for the task  
            Console.WriteLine("Waiting for task to complete.");
            task.Wait();
            Console.WriteLine("Task Completed.");

            //creating and starting another task             
            task = new Task(new Action(Workload));
            task.Start();
            Console.WriteLine("Waiting 2 secs for task to complete.");
            task.Wait(2000);
            Console.WriteLine("Wait ended - task completed.");

            Console.WriteLine("Main method complete. Press any key to finish.");
            Console.ReadKey();
        }
        static void Workload()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Task - iteration {0}", i);

                //sleeping for 1 second  
                Thread.Sleep(1000);
            }

        }
    }
}
