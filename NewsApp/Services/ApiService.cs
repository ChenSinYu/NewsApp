using NewsApp.Models;
using Newtonsoft.Json;

namespace NewsApp.Services
{ 

public class ApiService 
{
	public async Task<Root> GetNews(string categoryName)
	{
		var httpClient = new HttpClient();
		var response = await httpClient.GetStringAsync($"https://gnews.io/api/v4/top-headlines?category={categoryName.ToLower()}general&apikey=1ba9b321735e9019ba44586dc8f21b8f&lang=en");
		return JsonConvert.DeserializeObject<Root>(response);
    }
   }
}