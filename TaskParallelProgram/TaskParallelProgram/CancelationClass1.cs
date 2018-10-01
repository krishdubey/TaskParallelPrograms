using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace TaskParallelProgram
{
    class CancelationClass1
    {
        static void Main(string[] args)
        {
            // creating cancelation token
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            CancellationToken token = cancellationTokenSource.Token;
            // creating task
            Task task = new Task(() =>
            {
                for (int i = 0; i < 1000000; i++)
                {
                    if (token.IsCancellationRequested)
                    {
                        Console.WriteLine("Cancel() called:");
                        return;
                    }
                    Console.WriteLine("Loop value {0}", i);
                }
            }, token);
            Console.WriteLine("Press any key to start tasks");
            Console.WriteLine("Press any key to cancle the running tasks");
            Console.ReadLine();
            // starting the task
            task.Start();
            // reading the console value
            Console.ReadLine();

            //canceling the task
            Console.WriteLine("Cancelling task");
            cancellationTokenSource.Cancel();

            Console.WriteLine("Main method complete.Press any key to finish");
            Console.ReadLine();
        }
    }
}
