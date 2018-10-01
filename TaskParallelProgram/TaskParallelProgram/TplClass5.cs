using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskParallelProgram
{
    class TplClass5
    {
        static void HelloConsole(object message)
        {
            Console.WriteLine("Hello {0}" ,  message);
        }
        static void Main(string[] args)
        {
            //Action delegate  
            Task task1 = Task.Factory.StartNew(new Action<object>(HelloConsole), "Task 1");

            //anonymous function  
            Task task2 = Task.Factory.StartNew(delegate (object obj)
            {
                HelloConsole(obj);
            }, "Task 2");

            //lambda expression  
            Task task3 = Task.Factory.StartNew((obj) => HelloConsole(obj), "Task 3");

            //task1.Start();
            //task2.Start();
            //task3.Start();

            Console.WriteLine("Main method complete. Press any key to finish.");
            Console.ReadKey();
        }
    }
}
