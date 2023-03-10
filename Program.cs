namespace cviceni10._3
    
{
    using System;
    using System.Diagnostics;
    using System.Threading;
    internal class Program
    {
        
            public static void writeNumbers()
            {
                for (int i = 10; i >= 0; i--)
                {
                    Console.WriteLine("cislo: "+i) ;
                }
            }
        public static void writeNumbers2()
        {
            for (int i = 11; i <= 20; i++)
            {
                Console.WriteLine("cislo: " + i);
            }
        }

        static void Main(string[] args)
        {
            Random rand = new Random();
            Thread thread = new Thread(new ThreadStart(Program.writeNumbers));
            Thread thread1 = new Thread(new ThreadStart(Program.writeNumbers2));
            Console.WriteLine("Program Start");
            thread.Start();
            thread.Join();
            Console.WriteLine("Program finish");
            thread1.Start();


            
            ListNum l = new ListNum();
            Thread t1 = new Thread(new ThreadStart(l.Max));
            Thread t2 = new Thread(new ThreadStart(l.Min));
            for (int i = 0; i < 10000000; i++)
            {
                int a = rand.Next(100000) + 1;
                l.Add(a);
            }
            Stopwatch watch = new Stopwatch();
            watch.Start();
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();

            watch.Stop();
            Console.WriteLine("Time: " + watch.ElapsedMilliseconds + "ms");

            watch.Start();
            l.Max();
            l.Min();
            watch.Stop();
            Console.WriteLine("Time: " + watch.ElapsedMilliseconds + "ms");

        }

        
    }
}