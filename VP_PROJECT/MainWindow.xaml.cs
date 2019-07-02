using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net.Http;
using System.Net;
using System.IO;  

namespace VP_PROJECT
{
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    List<AnalysisResult> result_data;
    double sum_score;
    double avg_score;
    double sum_sad;
    double avg_sad;
    double sum_joy;
    double avg_joy;
    double sum_fear;
    double avg_fear;
    double sum_disgust;
    double avg_disgust;
    double sum_anger;
    double avg_anger;
    double sad;
    double joy;
    double fear;
    double dis;
    double ang;
    Boolean click = false;

    public MainWindow()
    {
        InitializeComponent();
    }
    private async void whole_analysis_Click(object sender, RoutedEventArgs e)
    {
        result_data = new List<AnalysisResult>();
        sum_score = 0.0;
        avg_score = 0.0;
        sum_sad = 0.0;
        avg_sad = 0.0;
        sum_joy = 0.0;
        avg_joy = 0.0;
        sum_fear = 0.0;
        avg_fear = 0.0;
        sum_disgust = 0.0;
        avg_disgust = 0.0;
        sum_anger = 0.0;
        avg_anger = 0.0;
        sad = 0.0;
        joy = 0.0;
        fear = 0.0;
        dis = 0.0;
        ang = 0.0;
        click = true;
        String yt_id = id_txt.Text;
        try 
        {
            await Fetch_Data(yt_id);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }
    }

    private async void individual_analysis_Click(object sender, RoutedEventArgs e)
    {
        result_data = new List<AnalysisResult>();
        click = false;
        String yt_id = id_txt.Text;
        try
        {
            await Fetch_Data(yt_id);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }
    }
    async Task Fetch_Data(String yt_id)
    {
        String id = yt_id;
        String key = "AIzaSyBfdKaVnrbrZ281s3GFFKAIXdPtEL2PTgI";
        try 
        {
            HttpClient cl = new HttpClient();
            cl.BaseAddress = new Uri("https://www.googleapis.com/youtube/v3/commentThreads");
            cl.DefaultRequestHeaders.Accept.Clear();
            cl.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            String url = "?part=snippet&videoId=" + id + "&key=" + key;
            //await suspended the execution of method until get Async is completed
           //Get Async returns an HttpResponseMessage that contains the HTTP response. If the status code in the response is a success code,
          //the response body contains the JSON representation of a product.
            HttpResponseMessage res = await cl.GetAsync(url);
            if (res.StatusCode == System.Net.HttpStatusCode.OK)
            {

                commentcs c = res.Content.ReadAsAsync<commentcs>().Result;
                int totalResult = Int32.Parse(c.pageInfo.totalResults);
                for (int i = 0; i < totalResult; i++)
                {
                       
                    if (c.items[i].snippet.topLevelComment.snippet.textOriginal.Length > 15)
                    {
                        await ibm(c.items[i].snippet.topLevelComment.snippet.textOriginal);
                           
                    }
                    else
                    {
                        continue;
                    }
                }
                if (click == true)
                {
                    for (int j = 0; j < result_data.Count; j++)
                    {

                        sum_score = sum_score + result_data[j].Score;
                        sum_sad = sum_sad + result_data[j].Sadness;
                        sum_joy = sum_joy + result_data[j].Joy;
                        sum_fear = sum_fear + result_data[j].Fear;
                        sum_disgust = sum_disgust + result_data[j].Disgust;
                        sum_anger = sum_anger + result_data[j].Anger;
                    }

                        avg_score =sum_score / result_data.Count;
                        avg_sad = sum_sad / result_data.Count;
                        avg_joy = sum_joy / result_data.Count;
                        avg_fear = sum_fear / result_data.Count;
                        avg_disgust = sum_disgust / result_data.Count;
                        avg_anger = sum_anger / result_data.Count;

                        wholeAnalysis analysis = new wholeAnalysis(avg_score, avg_sad, avg_joy, avg_fear, avg_disgust, avg_anger);
                        analysis.Show();
                        this.Close();
                }
                else if (click == false)
                {
                    Individual Ianalysis = new Individual(result_data);
                    Ianalysis.Show();
                    this.Close();
                }
                    
            }
              
    }
        catch (Exception e)
        {
                
        }
    }  
            
    async Task ibm(String ab)
    {
           
        String abb = ab;
        string temp = "https://gateway.watsonplatform.net/natural-language-understanding/api/v1/analyze?version=2017-02-27&text=" + abb + "&features=sentiment,keywords,emotion&keywords.sentiment=true";
        HttpWebRequest request;
        try
        {
            request = (HttpWebRequest)WebRequest.Create(temp);

            request.Credentials = new NetworkCredential("082e2d88-9164-4338-b35d-c62580b3a78d", "Eed1kE8nDr8f");
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            request.ContentType = "application/json"; 
            request.MediaType = "application/json";
            request.Accept = "application/json";
            request.Method = "POST";
            string text;
            var response = await request.GetResponseAsync();

            StreamReader sr = new StreamReader(response.GetResponseStream());
                

                text = sr.ReadToEnd();
                    
                HttpResponseMessage res = await CreateJsonResponse(text);
                Analysis x = res.Content.ReadAsAsync<Analysis>().Result;
                double sc = Convert.ToDouble(x.sentiment.document.score);
                String lb = x.sentiment.document.label;
                try { 
                        sad = Convert.ToDouble(x.emotion.document.emotion.sadness);
                        joy = Convert.ToDouble(x.emotion.document.emotion.joy);
                        fear = Convert.ToDouble(x.emotion.document.emotion.fear);
                        dis = Convert.ToDouble(x.emotion.document.emotion.disgust);
                        ang = Convert.ToDouble(x.emotion.document.emotion.anger);
                }
                catch (Exception o)
                { 
                }
                    
                AnalysisResult a = new AnalysisResult(sc, lb, sad, joy, fear, dis, ang);
                result_data.Add(a);

        }
        catch (WebException e)
        {
                
        }
  
    }
    //method to convert string in httpResponseMessage
    //copied from stackoverflow
    public static async Task<HttpResponseMessage> CreateJsonResponse(string json)
    {
            
        return new HttpResponseMessage()
        {
            Content = new StringContent(json, System.Text.Encoding.UTF8, "application/json")
        };

    }
}
}
