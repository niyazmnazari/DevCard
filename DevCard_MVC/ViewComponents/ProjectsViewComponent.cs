using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using DevCard_MVC.Models;

namespace DevCard_MVC.ViewComponents
{
	public class ProjectsViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke() {
			var projects = new List<Project>
			{
				new Project(1,"Project Heading","Project intro lorem ipsum dolor sit amet, consectetuer adipiscing elit. Cum sociis natoque penatibus et magnis dis parturient montes.","project-1.jpg","Client: Google"),
				new Project(2,"Project Heading","Project intro lorem ipsum dolor sit amet, consectetuer adipiscing elit. Cum sociis natoque penatibus et magnis dis parturient montes.","project-2.jpg","Client: Google"),
				new Project(3,"Project Heading","Project intro lorem ipsum dolor sit amet, consectetuer adipiscing elit. Cum sociis natoque penatibus et magnis dis parturient montes.","project-3.jpg","Client: Google"),
				new Project(4,"Project Heading","Project intro lorem ipsum dolor sit amet, consectetuer adipiscing elit. Cum sociis natoque penatibus et magnis dis parturient montes.","project-4.jpg","Client: Google"),
			};
			return View("_Projects", projects);
		}
	}
}
