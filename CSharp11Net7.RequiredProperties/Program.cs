using System.Net.Http.Headers;
using System.Text.Json;


var req = new Request()
{ 
    //BaseUrl = "https://jsonplaceholder.typicode.com/"
};

//req.BaseUrl = "";

//req.BaseUrl = "https://jsonplaceholder.typicode.com/";

var res = await req.MakeRequest("todos/1");

Console.WriteLine(res);


Console.ReadLine();


class Request
{
    public required string BaseUrl { get; set; }

    public object BodyObject { get; set; }

    public HttpMethod Method { get; set; }

    public async Task<string> MakeRequest(string url)
    {
        //if (BaseUrl is null)
        //    throw new ArgumentNullException(nameof(BaseUrl));

        //if (url is null)
        //    throw new ArgumentNullException(nameof(url));

        using var client = new HttpClient();

        var req = new HttpRequestMessage()
        {
            Method = this.Method,
            RequestUri = new Uri(BaseUrl + url)
        };

        if (bodyObject is not null)
        {
            req.Content = new StringContent(JsonSerializer.Serialize(bodyObject));
            req.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
        }

        var httpRes = await client.SendAsync(req);

        return await httpRes.Content.ReadAsStringAsync();
    }

}