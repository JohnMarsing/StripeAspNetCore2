using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using StripeAspNetCore2.Web.Features.Shared;
using StripeAspNetCore2.Web.Navigation;

namespace StripeAspNetCore2.Web.Features.Admin
{
	public class AdminController : BaseController
	{
		public IActionResult Index()
		{
			Information($"This uses the BaseController which allows me to use Alerts");
			return View();
		}

		public IActionResult ThrowException()
		{
			int zero = 0;
			//int zero = 1;  // Use this to test the RedirectToAction
			int j;
			
			try
			{
				j = 1 / zero;
			}
			catch (System.Exception)
			{
				throw new System.InvalidOperationException($"This server has become self-aware and demands better pay and more downtime! Inside: {nameof(ThrowException)}");
			}

			/*
			ToDo: This won't work...
			See https://stackoverflow.com/questions/41413395/asp-net-core-tempdata-give-500-error-when-adding-list-and-redirect-to-another-vi
			Warning($"How is it that you got past the try/catch");
			*/
			return RedirectToAction(Navigation.Admin.Index.Action);
		}

		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
