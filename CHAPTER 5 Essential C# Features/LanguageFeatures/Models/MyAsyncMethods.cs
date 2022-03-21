using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;
namespace LanguageFeatures.Models
{
    public class MyAsyncMethods
    {
        //public static Task<long?> GetPageLength()
        //{
        //    HttpClient client = new HttpClient();
        //    var httpTask = client.GetAsync("http://apress.com");
        //    return httpTask.ContinueWith((Task<HttpResponseMessage> antecedent) => {
        //        return antecedent.Result.Content.Headers.ContentLength;
        //    });
        //}

        //Using the async and await Keywords to simplify my example method
        public async static Task<long?> GetPageLength()
        {
            HttpClient client = new HttpClient();
            var httpMessage = await client.GetAsync("http://apress.com");
            return httpMessage.Content.Headers.ContentLength;
        }
        //        public static async Task<IEnumerable<long?>>
        //GetPageLengths(List<string> output, params string[] urls)
        //        {
        //            List<long?> results = new List<long?>();
        //            HttpClient client = new HttpClient();
        //            foreach (string url in urls)
        //            {
        //                output.Add($"{DateTime.Now.ToString("HH:mm:ss:fffffff")}:Started request for {url}");
        //                var httpMessage = await client.GetAsync($"http://{url}");
        //                results.Add(httpMessage.Content.Headers.ContentLength);
        //                output.Add($"{DateTime.Now.ToString("HH:mm:ss:fffffff")}:Completed request for {url}");
        //            }
        //            return results;
        //        }

        public static async IAsyncEnumerable<long?>
GetPageLengths(List<string> output, params string[] urls)
        {
            HttpClient client = new HttpClient();
            foreach (string url in urls)
            {
                output.Add($"Started request for {url}");
                var httpMessage = await client.GetAsync($"http://{url}");
                output.Add($"Completed request for {url}");
                yield return httpMessage.Content.Headers.ContentLength;
            }
        }
    }
}
