using System;
using System.Threading.Tasks;

namespace ConcurrencyinCSharpBook
{
    class Program
    {
        static void Main(string[] args)
        {
            // MainAsync().Wait();
             TimeOutHttp().Wait();
             Console.Read();
        }

        static async Task MainAsync()
        {
            var result = await DownloadWithTimeout.DownloadStringWithTimeout("http://www.google.com");
            Console.WriteLine(result);
        }
        static async Task TimeOutHttp()
        {
            var result = await DownloadWithTimeout.DownloadStringWithTimeout("http://www.myown.ljh");
            Console.WriteLine(result);
        }
    }
}
