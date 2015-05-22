using System;
using System.Linq;
using System.Threading.Tasks;

namespace ConcurrencyinCSharpBook
{
    class Program
    {
        static void Main(string[] args)
        {
            // MainAsync().Wait();
            // TimeOutHttp().Wait();
            //Progress().Wait();
            ProcessAsTheyComplete().Wait();
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

        static async Task Progress()
        {
            var progress = new Progress<int>();
            progress.ProgressChanged += Progress_ProgressChanged;
           var result = await AsyncProgress.ReportProgress(progress);
            Console.WriteLine("Result from Progress method is {0}",result.ToString());
        }

        private static void Progress_ProgressChanged(object sender, int e)
        {
            Console.WriteLine("Progress from async method {0}",e.ToString());
        }

         static async Task ProcessAsTheyComplete()
        {
            var a = Async.DelayAndReturn(2);
            var b = Async.DelayAndReturn(3);
            var c = Async.DelayAndReturn(1);
            var tasks = new[] { a, b, c };
            var completed = tasks.Select(t => Async.ProcessAsyncResult(t)).ToArray();
            await Task.WhenAll(completed);
        }
    }
}
