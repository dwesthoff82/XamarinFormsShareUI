using System;
using System.Drawing;
using Xamarin.Forms.Platform.iOS;

using Xamarin.Forms;
using EmpowerOne;
using EmpowerOne.iOS;
// This ExportRenderer command tells Xamarin.Forms to use this renderer
// instead of the built-in one for this page
using UIKit;


[assembly:ExportRenderer(typeof(CustomNav), typeof(CustomNavRenderer))]

namespace EmpowerOne.iOS
{
	public class CustomNavRenderer : NavigationRenderer
	{


		public override void ViewDidLoad ()
		{               
			base.ViewDidLoad();

		//	var page = this.Element as CustomNav;
		////	var view = NativeView;

		//	var viewController = ViewController;
			//this.NavigationBar.ShadowImage = new UIKit.UIImage ();
			this.NavigationBar.Translucent = true;
	
			UIApplication.SharedApplication.SetStatusBarHidden (false, false);
			UIApplication.SharedApplication.SetStatusBarStyle(UIStatusBarStyle.LightContent, false);

			this.NavigationItem.LeftItemsSupplementBackButton = true;


			this.View.BackgroundColor = Color.Black.ToUIColor ();

		}


	}
}