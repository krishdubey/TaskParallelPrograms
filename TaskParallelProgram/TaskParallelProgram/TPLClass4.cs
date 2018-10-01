using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskParallelProgram
{
    class TPLClass4
    {
        static void HelloConsole()
        {
            Console.WriteLine("Hello Task");
        }

        static void Main(string[] args)
        {
            //Action delegate  
            Task task1 = new Task(new Action(HelloConsole));

            //anonymous function  
            Task task2 = new Task(delegate
            {
                HelloConsole();
            });

            //lambda expression  
            Task task3 = new Task(() => HelloConsole());

            task1.Start();
            task2.Start();
            task3.Start();

            Console.WriteLine("Main method complete. Press any key to finish.");
            Console.ReadLine();
        }
    }
}
