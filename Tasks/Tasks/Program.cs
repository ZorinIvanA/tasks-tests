using System;
using System.Threading;
using System.Threading.Tasks;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Test();
            Console.Read();
        }

        static async Task Test()
        {
            try
            {
                var cl = new MyAsyncClass();
                Task t = cl.SleepAsync();
                Console.WriteLine("Helloo");
                Thread.Sleep(1000);
                Console.WriteLine("world");
                await t;
                Console.Read();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.Read();
            }
        }
    }
}
