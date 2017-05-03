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
		public void SaleTest()
		{
			Thread.Sleep(4000);
			app.Tap("SALE");
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
		}
	}
	
}
