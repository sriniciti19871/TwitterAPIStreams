using Microsoft.Extensions.Configuration;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using TwitterCurlCall.Models;




//Try catch block for exception handling
try
{
    

    var url = "https://api.twitter.com/2/tweets/sample/stream";

    //using block used to enforce use and dispose
    using var client = new HttpClient();
    {
        //Twitter API has been successful at 32 mins in my previous executions. So specifying timeout as 60 minutes
        client.Timeout = TimeSpan.FromHours(1);
        var msg = new HttpRequestMessage(HttpMethod.Get, url);
        msg.Headers.Add("Authorization", "Bearer AAAAAAAAAAAAAAAAAAAAAOKolQEAAAAAhG7h66BZfXp4R%2F6ZeawcUZRzRp0%3DtIHtrLDbV1vgQCYXtQLPoJ2BAgvB5pWK2NbAmHWWp6Mi6renDC");
        msg.Headers.Add("ConsumerKey", "cC3D7bk5rT6xkFiQEVJLfMzpT");
        msg.Headers.Add("ConsumerSecret", "LbBXZBp8OkzxfdLHnZtLEYBhmDptkZFTBLu87XYiT0ZqMyvfhs");

        //Response from API
        var res = await client.SendAsync(msg);

      
        
       
    var content = await res.Content.ReadAsStringAsync();

       

    }
}
//code specifically for a WebException
catch (System.Net.WebException ex)
{
   
        Console.WriteLine(ex.Message);
    
   
}
//Generic Exception block
catch (Exception ex)
{
   
    Console.WriteLine("Generic Exception occured when API was contacted" + ex.Message); 
   
}

finally
{
    Console.WriteLine("Twitter API was attempted to connected");
}



