using Stripe;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using StripeAspNetCore2.Web.Features;
using StripeAspNetCore2.Web.Features.Donate.Constants;
using StripeAspNetCore2.Web.Features.Shared;

namespace StripeAspNetCore2.Web.Controllers
{
	public class DonateController : BaseController
	{
		public ActionResult Charge(string stripeEmail, string stripeToken, int amount)
		{
			Information($"stripeEmail: {stripeEmail}, stripeToken: {stripeToken}, amount: {amount}");
			StripeConfiguration.SetApiKey(MyStripeSettings.SiteName);

			var customers = new StripeCustomerService();
			var charges = new StripeChargeService();

				var customer = customers.Create(new StripeCustomerCreateOptions
				{
					Email = stripeEmail,
					SourceToken = stripeToken
				});

				var charge = charges.Create(new StripeChargeCreateOptions
				{
					Amount = amount,
					Description = "Sample Charge",
					Currency = "usd",
					CustomerId = customer.Id
				});

			//return View();

			Information($"Transaction completed");
			return RedirectToAction("Index");
		}

		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}

	}
}