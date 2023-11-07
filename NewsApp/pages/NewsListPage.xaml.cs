using NewsApp.Models;
using NewsApp.Services;

namespace NewsApp.pages;

public partial class NewsListPage : ContentPage
{
	public List<Article> ArticlesList;
	public NewsListPage(string categoryName)
	{
		InitializeComponent();
		Title = categoryName;
		GetNews(categoryName);
		ArticlesList = new List<Article>();
	}

	private async void GetNews(string categoryName)
	{
		var apiService = new ApiService();
		var newsResult = await apiService.GetNews(categoryName);
		foreach (var item in newsResult.Articles) 
		{ 
			ArticlesList.Add(item);
		}
		CvNews.ItemsSource = ArticlesList;
	}
}