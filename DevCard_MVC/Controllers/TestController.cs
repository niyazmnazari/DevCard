using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using System.Net.Mime;

namespace DevCard_MVC.Controllers
{
	public class TestController : Controller
	{
		//public IActionResult Index()
		//{
		//	return PartialView("Footer");
		//}

		//public PartialViewResult Index()
		//{
		//	return PartialView("Footer");
		//}

		//public ContentResult Index()
		//{
		//	//return Content("<h1>Hello Asp.Net MVC Core Students</h1>")
		//	return Content("<h1 style='color:red'>Hello Asp.Net MVC Core Students</h1>", "text/html");
		//}

		//public EmptyResult Index()
		//{
		//	//return new EmptyResult();
		//	return null;
		//}

		//public FileResult Index()
		//{
		//	//return File("~/test.txt" , "text/XML");
		//	var fileByte = System.IO.File.ReadAllBytes("wwwroot/test.xml");
		//	const string fileName = "filename.xml";
		//	return File(fileByte, MediaTypeNames.Text.Xml, fileName);

		//}

		//public JsonResult Index()
		//{
		//	return Json(new { 
		//					id=123,
		//					name="Niyaz", 
		//					job="Web Developer", 
		//					website="web24.ir"});
		//}

		//public JavascriptResult Index()
		//{
		//	return new JavascriptResult("alert('Hello!')");
		//}

		//public RedirectResult Index()
		//{
		//	return Redirect("https://www.google.com");
		//}

		//public RedirectToActionResult Index()
		//{
		//	return RedirectToAction("Contact", "Home");
		//}

		public IActionResult Index() {
			//return new OkResult();
			//return new NotFoundResult();
			//return new BadRequestResult();
			//return new StatusCodeResult(404);
			return new UnauthorizedResult();
		}
	}

	//public class JavascriptResult : ContentResult
	//{
	//	public JavascriptResult(string data)
	//	{
	//		Content=data;
	//		ContentType= "application/javascript";
	//	}
	//}

}
