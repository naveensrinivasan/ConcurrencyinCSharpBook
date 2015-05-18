using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConcurrencyinCSharpBook
{
    public static class UsingAnyAndAll
    {
        public static async Task<IEnumerable<string>> DownloadAll(IEnumerable<string> urls)
        {
            var requests = urls.Select(url => new HttpClient().GetStringAsync(url));
            return await Task.WhenAll(requests);
        }
        
        public static async Task<string> DownloadAny(IEnumerable<string> urls)
        {
            var requests = urls.Select(url => new HttpClient().GetStringAsync(url));
            var result=  await Task.WhenAny(requests);
            return await result;
        }
    }
}
