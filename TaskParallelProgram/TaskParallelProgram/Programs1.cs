using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Drawing;

namespace TaskParallelProgram
{
    class Programs1
    {


        public static void Main()
        {
            // A simple source for demonstration purposes. Modify this path as necessary.
            try
            {


                String[] files = System.IO.Directory.GetFiles(@"G:\HTML1\", "*.jpg");
                String newDir = @"G:\HTML1\krishna\Modified";
                System.IO.Directory.CreateDirectory(newDir);

                // Method signature: Parallel.ForEach(IEnumerable<TSource> source, Action<TSource> body)
                // Be sure to add a reference to System.Drawing.dll.
                Parallel.ForEach(files, (currentFile) =>
                {
                    // The more computational work you do here, the greater 
                    // the speedup compared to a sequential foreach loop.
                    String filename = System.IO.Path.GetFileName(currentFile);
                    var bitmap = new Bitmap(currentFile);

                    bitmap.RotateFlip(RotateFlipType.Rotate180FlipNone);
                    // NewMethod(bitmap);
                    bitmap.Save(Path.Combine(newDir, filename));

                    // Peek behind the scenes to see how work is parallelized.
                    // But be aware: Thread contention for the Console slows down parallel loops!!!

                    Console.WriteLine("Processing {0} on thread {1}", filename, Thread.CurrentThread.ManagedThreadId);
                    //close lambda expression and method invocation
                });



                // Keep the console window open in debug mode.
                Console.WriteLine("Processing complete. Press any key to exit.");
                Console.ReadKey();

            }
            catch (DirectoryNotFoundException dirEx)
            {
                Console.WriteLine(dirEx);
            }
        }

        
    }
}
