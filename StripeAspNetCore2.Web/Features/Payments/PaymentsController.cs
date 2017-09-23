using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Stripe;
using StripeAspNetCore2.Web.Settings;
using StripeAspNetCore2.Web.Features.Shared;
using StripeAspNetCore2.Web.Constants;
using StripeAspNetCore2.Web.Features.Payments;

namespace StripeAspNetCore2.Web.Features.Payments
{
	public class PaymentsController : BaseController
	{

		private readonly IOptions<Settings.Stripe> stripeSettings;

		public PaymentsController(IOptions<Settings.Stripe> stripeSettings)
		{
			this.stripeSettings = stripeSettings;
		}

		public IActionResult Index()
		{
			var vm = new DonateVM();
			return View(vm);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Index(DonateVM vm)
		{
			if (!ModelState.IsValid)
			{
				return View(vm);
			}
			var success = $"HttpPost success: {vm.Amount}. SecretKey: {stripeSettings.Value.SecretKey}";
			//, SecretKeyPartial: {stripeSettings.Value.SecretKeyPartial}
			//return RedirectToAction(Navigation.Payments.Donate.Action);
			return RedirectToAction(Navigation.Payments.Donate2.Action, new { amount=vm.Amount, msg = success });
		}

		public IActionResult Donate2(int amount, string msg)
		{
			var vm = new Donate2VM();
			vm.Amount = amount;
			vm.Message = msg;
			return View(vm);

		}

		public IActionResult Confirmation()
		{
			Information($"Transaction completed, Thank You");
			//return RedirectToAction(Payments.Index.Action);
			return RedirectToAction(Navigation.Payments.Index.Action);
		}

		public IActionResult Charge(int amount)
		{
			if (amount == 5)
			{
				//return RedirectToAction(Payments.Charge.Action, Payments.Controller);
				return RedirectToAction(
					Navigation.Payments.Charge.Action, 
					Navigation.Payments.Controller);
			}
			else
			{
				return RedirectToAction(
					Navigation.Payments.Charge.Action, 
					Navigation.Payments.Controller);
			}

		}

		public ActionResult Charge(string stripeEmail, string stripeToken, int amount)
		{
			Information($"stripeEmail: {stripeEmail}, stripeToken: {stripeToken}, amount: {amount}");
			StripeConfiguration.SetApiKey(AppSettings.SiteTitle);

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