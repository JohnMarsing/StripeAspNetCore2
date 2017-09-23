namespace StripeAspNetCore2.Web.Navigation
{
	public static class Home
	{
		public const string Controller = "Home";

		public static class Index
		{
			public const string Action = "Index";
			public const string FaClass = "fa fa-home";
			public const string Title = "Home";
			public const string FaClass2 = "fa fa-cc-stripe";
			public const string Title2 = "Stripe";
		}
		public static class About
		{
			public const string Action = "About";
			public const string FaClass = "fa fa-info";
			public const string Title = Action;
		}
		public static class Contact
		{
			public const string Action = "Contact";
			public const string FaClass = "fa fa-user-circle";
			public const string Title = Action;
		}


	}

	public static class Payments
	{
		public const string Controller = "Payments";

		public static class Index
		{
			public const string Action = "Index";
			public const string FaClass = "fa fa-dollar";
			public const string Title = "Donations";
		}

		public static class Charge
		{
			public const string Action = "Charge";
			public const string FaClass = "fa fa-dollar";
			public const string Title = "Donations";
		}

		public static class Donate
		{
			public const string Action = "Donate";
			public const string FaClass = "fa fa-dollar";
			public const string Title = "Donations";
		}

		public static class Donate2
		{
			public const string Action = "Donate2";
			public const string FaClass = "fa fa-dollar";
			public const string Title = "Donations";
		}
	}

	public static class Donate
	{
		public const string Controller = "Donate";

		//public static class Index
		//{
		//	public const string Action = "Index";
		//	public const string FaClass = "fa fa-dollar";
		//	public const string Title = "Donations";
		//}

		public static class Charge
		{
			public const string Action = "Charge";
			public const string FaClass = "fa fa-dollar";
			public const string Title = "Donations";
		}
	}

	//public static class Charge
	//{
	//	public const string Controller = "Charge";
	//}

	public static class Admin
	{
		public const string Controller = "Admin";

		public static class Index
		{
			public const string Action = "Index";
			public const string FaClassNavBar = "fa fa-cogs";
			public const string FaClassPage = "text-danger fa fa-cogs fa-2x";
			public const string Title = Action;
		}

		public static class ThrowException
		{
			public const string Action = "ThrowException";
			public const string FaClass = "fa fa-key fa-lg fa-2x";
			public const string Title = "Test Thrown Exception"; // Action;
		}

		public static class ErrorTest
		{
			public const string Action = "Error";
			public const string FaClass = "fa fa-bomb fa-lg fa-2x";
			public const string Title = "Test Error"; // Action;
		}
	}

}
