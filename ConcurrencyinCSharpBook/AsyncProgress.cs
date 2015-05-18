using System;
using System.Threading.Tasks;

namespace ConcurrencyinCSharpBook
{
    static class AsyncProgress
    {
        public static async Task<int> ReportProgress(IProgress<int> progress = null)
        {
            for (int i = 1; i < 11; i++)
            {
                if (progress != null) {
                    progress.Report(i * 10);
                }
                await Task.Delay(1000);
            }
            return 100;
        }
    }
}
