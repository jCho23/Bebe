using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using System.Threading;

namespace Bebe
{
	[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]
	public class Tests
	{
		IApp app;
		Platform platform;

		public Tests(Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest()
		{
			app = AppInitializer.StartApp(platform);
			app.Screenshot("App Launched");
		}

		[Test]
		public void Repl()
		{
			app.Repl();
		}

		[Test]
		public void GuestCheckoutTest()
		{
			Thread.Sleep(8000);
			app.Tap("home_banner1");
			app.Screenshot("Let's start by Tapping on the 'Sale' Button");
			app.Tap("productImage");
			app.Screenshot("Then we Tapped on the first item");

			app.Tap("sizeTitle");
			app.Screenshot("Next we Tapped on the 'Size' Button");
			Thread.Sleep(4000);
			app.Tap("item_product_attribute_container");
			app.Screenshot("We Tapped on the first size");

			app.Tap("bag_size");
			app.Screenshot("Then we Tapped on the Shopping Cart");

			app.ScrollDown();
			app.Screenshot("Next we Scrolled Down to see more information");
			Thread.Sleep(4000);
			app.Tap(x => x.Css("#guestCheckout"));
			app.Screenshot("We Tapped on the 'Guest Checkout' Button");

			app.Tap(x => x.Css("#guestEmailAddress_entry"));
			app.Screenshot("Then we Tapped on the Email Text Field");

			app.EnterText("MannyMashouf@bebe.com");
			app.Screenshot("Then we entered our Email, 'MannyMashouf@bebe.com'");

			app.PressEnter();
			app.Screenshot("We Tapped on the 'Enter' Button");
		}
	}
	
}
