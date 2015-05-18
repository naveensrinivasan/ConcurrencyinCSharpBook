using System;
using System.Threading.Tasks;
using System.Net.Http;

namespace ConcurrencyinCSharpBook
{
    class DownloadWithTimeout
    {
        public  static  async Task<string> DownloadStringWithTimeout(string uri)
        {
            using (var client = new HttpClient())
            {
                var downloadstring = client.GetStringAsync(new Uri(uri));
                var timeOut = Task.Delay(3000);
                var completedTask = await Task.WhenAny(new[] { downloadstring, timeOut }).ConfigureAwait(false);

                if (completedTask == timeOut)
                    return null;
                return await downloadstring;
            }
        }
    }
}
