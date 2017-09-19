using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using StripeAspNetCore2.Web.Infrastructure;

namespace StripeAspNetCore2.Web.Features
{
	public class BaseController : Controller
	{
		public void Success(string message, bool dismissable = true)
		{
			AddAlert(AlertStyles.Success, message, dismissable);
		}

		public void Information(string message, bool dismissable = true)
		{
			AddAlert(AlertStyles.Information, message, dismissable);
		}

		public void Warning(string message, bool dismissable = true)
		{
			AddAlert(AlertStyles.Warning, message, dismissable);
		}

		public void Danger(string message, bool dismissable = true)
		{
			AddAlert(AlertStyles.Danger, message, dismissable);
		}

		private void AddAlert(string alertStyle, string message, bool dismissable)
		{
			var alerts = TempData.ContainsKey(Alert.TempDataKey)
					? (List<Alert>)TempData[Alert.TempDataKey]
					: new List<Alert>();

			alerts.Add(new Alert
			{
				AlertStyle = alertStyle,
				Message = message,
				Dismissable = dismissable
			});

			TempData[Alert.TempDataKey] = alerts;
		}

	}
}
