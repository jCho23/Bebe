using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

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
			app.Tap("SALE");
			app.Tap("productImage");

			app.Tap("sizeTitle");
			app.Tap("item_product_attribute_container");

			app.Tap("bag_size");
			app.Screenshot("We Tapped on the Shopping Cart");


		}
}
