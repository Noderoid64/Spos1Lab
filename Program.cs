using System;

using Lab1.Entities;
using Lab1.Services;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = new System.Diagnostics.Stopwatch();


            MatrixEntityBuilder builder = new MatrixEntityBuilder();
            MatrixEntity m1 = builder.build(10000, 10000);
            MatrixEntity m2 = builder.build(10000, 1);
            MatrixEntity m3 = builder.build(1, 10000);

            for (int i = 0; i < 10; i++)
            {
                watch.Start();
                MatrixEntity res = m2.multy(m1);
                watch.Stop();
                Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
                watch.Reset();
            }
            Console.WriteLine("---------------------------------");
            for (int i = 0; i < 10; i++)
            {
                watch.Start();
                MatrixEntity res = m1.multy(m3);
                watch.Stop();
                Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
                watch.Reset();
            }

        }
    }
}
