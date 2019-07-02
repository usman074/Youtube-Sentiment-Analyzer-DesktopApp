using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            
            usman().Wait();
            Console.ReadKey();
        }

        static async Task usman()
        {
            HttpClient cl = new HttpClient();
            cl.BaseAddress = new Uri("https://www.googleapis.com/youtube/v3/commentThreads");
            cl.DefaultRequestHeaders.Accept.Clear();
            //telling server to send data in json format
            cl.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            String url = "?part=snippet&videoId=AcUauzCn7RE&key=AIzaSyBfdKaVnrbrZ281s3GFFKAIXdPtEL2PTgI";
            //await suspended the execution of method until get Async is completed
            //Get Async returns an HttpResponseMessage that contains the HTTP response. If the status code in the response is a success code,
            //the response body contains the JSON representation of a product.
            HttpResponseMessage res = await cl.GetAsync(url);
            if (res.StatusCode == System.Net.HttpStatusCode.OK)
            {
                commentcs c = res.Content.ReadAsAsync<commentcs>().Result;
                //Console.WriteLine("Kind: " + c.kind);
                //Console.WriteLine("Etag: " + c.etag);
                //Console.WriteLine("TR: " + c.pageInfo.totalResults);
                //Console.WriteLine("TRPP: " + c.pageInfo.resultsPerPage);
                int x = 0;
                Int32.TryParse(c.pageInfo.totalResults, out x);
                for (int i = 0; i < x; i++)
                {
                    Console.WriteLine("text disp: " + c.items[i].snippet.topLevelComment.snippet.textDisplay);
                    Console.WriteLine("text org: " + c.items[i].snippet.topLevelComment.snippet.textOriginal);
                    Console.WriteLine("--------------------------------------------------------------------------------------------------");
                }
                   
                //String x = await res.Content.ReadAsStringAsync();
                //Console.WriteLine(x);
            }
          //  Console.ReadKey();
        }
    }
}
