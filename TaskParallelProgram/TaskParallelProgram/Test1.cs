using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace TaskParallelProgram
{
    class Test1
    {
        public static void test1()
        {
            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine("test1 " + i);
                
            }
        }
        public void test2()
        {
            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine("test2 " + i);
            }
        }
        static void Main(string[] args)
        {
            Parallel.For(0, 10, Test1 =>
              {
                  Console.WriteLine(Test1);  //  test1();
              });
            Console.ReadLine();
        }
    }
}
