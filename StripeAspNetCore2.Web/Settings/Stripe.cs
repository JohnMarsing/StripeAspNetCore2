namespace StripeAspNetCore2.Web.Settings
{
	public class Stripe
	{
		public string PublishableKey { get; set; }
		public string SecretKey { get; set; }

		//public const string SiteName = "Stripe Asp.Net Core 2";

		public static string SiteName
		{
			get { return "Stripe Asp.Net Core 2"; }
		}

		public string SecretKeyPartial
		{
			get
			{
				if (!string.IsNullOrEmpty(SecretKey))
				{
					return SecretKey.Substring(3, 3);
				}
				else
				{
					return "???";
				}

			}
		}


	}
}
