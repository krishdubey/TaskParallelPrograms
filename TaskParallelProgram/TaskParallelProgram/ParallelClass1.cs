using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TaskParallelProgram
{
    class ParallelClass1
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {11,12,25,75,84,65,58,55,45,66};

            // for(int i = 0; i< arr.Length; i++)
            // {
            //   Console.WriteLine("i =" + arr[i]);
            // Thread.Sleep(2000);
            //}
            int i = 0;
            Parallel.For(i, arr.Length ,j=>
                {
                Console.WriteLine("i = " + arr[j]);
                Thread.Sleep(3000);
            });

            Console.ReadLine();
        }
    }


}
