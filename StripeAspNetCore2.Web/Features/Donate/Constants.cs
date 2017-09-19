using System;
//using System.Configuration;

namespace StripeAspNetCore2.Web.Features.Donate.Constants
{
	public static class ControllerNames
	{
		public const string Payment = "Payment";
		public const string Donate = "Donate";
	}

	public static class Actions
	{
		public const string Index = "Index";
		public const string Charge = "Charge";
		public const string Donate = "Donate";
		public const string Confirmation = "Confirmation";
	}


	public static class Description 
	{
		public const string GoldMembership = "gold membership payment";
		public const string Donation = "one-time donation";
	}
		

	public static class MyStripeSettings
	{
		//private static readonly Lazy<bool>
		//	_isTestMode = new Lazy<bool>(() =>
		//	{
		//		bool result;
		//		return bool.TryParse(
		//					ConfigurationManager.AppSettings["stripe:IsTestMode"], out result) && result;
		//	});


		public static bool IsTestMode
		{
			//get { return _isTestMode.Value; }
			get { return true; }
		}

		public static bool IsProductionMode
		{
			//get { return !_isTestMode.Value; }
			get { return false; }
		}


		//private static readonly Lazy<string>
		//_secretKeyTest = new Lazy<string>(() => ConfigurationManager.AppSettings["stripe:SecretKeyTest"]);

		//private static readonly Lazy<string>
		//_secretKey = new Lazy<string>(() => ConfigurationManager.AppSettings["stripe:SecretKey"]);


		public const string PublishableKey = "pk_test_ENefMle57I9dCow7LRdEsJC3";
		//public static string PublishableKey
		//{
		//	get { return "pk_test_ENefMle57I9dCow7LRdEsJC3"; }
		//}

		public static string SecretKey
		{
			get
			{
				if (IsTestMode)
				{
					//return _secretKeyTest.Value;
					return PublishableKey;
				}
				else
				{
					//return _secretKey.Value;
					return PublishableKey;
				}
				//
			}
		}


		public static string SiteName
		{
			get { return "Stripe Asp.Net Core 2"; }
		}

	}
}