using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tasks
{
    public class MyAsyncClass
    {
        public async Task SleepAsync()
        {
            for(int i=0; i<10;i++)
            {
                await Task.Delay(500);
                Console.WriteLine($"{i * 500}");
            }            
        }
    }
}
