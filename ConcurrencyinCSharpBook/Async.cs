using System;
using System.Threading.Tasks;

namespace ConcurrencyinCSharpBook
{
    public static class Async
    {
        public static async Task<int> DelayAndReturn(int i)
        {
            await Task.Delay(TimeSpan.FromSeconds(i * 2));
            return i;
        }
       public static async Task ProcessAsyncResult(Task<int> i)
        {
            var result = await i;
            Console.WriteLine(result);
        }

    }
}