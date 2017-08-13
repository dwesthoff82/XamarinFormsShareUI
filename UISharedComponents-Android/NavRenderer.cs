using System;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using AndHow.SharedComponents;
using AndHow.SharedComponents.Android;


[assembly:ExportRenderer(typeof(CustomNav), typeof(NavRenderer))]
namespace AndHow.SharedComponents.Android
{
	public class NavRenderer : NavigationRenderer
	{
		protected override void OnElementChanged (ElementChangedEventArgs<NavigationPage> e)
		{
			base.OnElementChanged (e);
		}
		protected override void AttachViewToParent (global::Android.Views.View child, int index, LayoutParams @params)
		{
			base.AttachViewToParent (child, index, @params);
		
		}
		
	}
}

