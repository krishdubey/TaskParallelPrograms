using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
namespace TaskParallelProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            long totalSize = 0;

            String paths = "G:\\2to5\\appexp\\src";
            Console.WriteLine(paths);
           
            if (!Directory.Exists(paths))
            {
                Console.WriteLine("The directory does not exist.");
               // Console.ReadLine();
                return;
            }
        
            String[] files = Directory.GetFiles(paths);
            Parallel.For(0, files.Length,
                         index => {
                             FileInfo fi = new FileInfo(files[index]);
                             long size = fi.Length;
                             Interlocked.Add(ref totalSize, size);
                         });
            Console.WriteLine("Directory '{0}':", paths);
            Console.WriteLine("{0:N0} files, {1:N0} bytes", files.Length, totalSize);
            Console.ReadLine();
        }
    }
}
