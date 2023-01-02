using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DevCard_MVC.ViewComponents
{
	public class LatestArticlesViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var articles = new List<Article>
			{
				new Article(1,"Top 3 JavaScript Frameworks","Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean\r\n\t\t\t\t\t\t\tcommodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis\r\n\t\t\t\t\t\t\tparturient...","blog-post-thumb-card-1.jpg" ),
				new Article(2,"About Remote Working","Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean\r\n\t\t\t\t\t\t\tcommodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis\r\n\t\t\t\t\t\t\tparturient...","blog-post-thumb-card-2.jpg" ),
				new Article(3,"A Guide to Becoming a Full-Stack Developer","Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean\r\n\t\t\t\t\t\t\tcommodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis\r\n\t\t\t\t\t\t\tparturient...","blog-post-thumb-card-3.jpg"),
			};
			return View("_LatestArticles", articles);
		}
	}
}
