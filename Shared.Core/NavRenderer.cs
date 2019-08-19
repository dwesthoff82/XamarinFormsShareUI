using System;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using AndHow.SharedComponents;
using Android.Content;
using Shared.Core;

[assembly:ExportRenderer(typeof(CustomNav), typeof(NavRenderer))]
namespace Shared.Core
{
	public class NavRenderer : NavigationRenderer
	{
        public NavRenderer(Context context) 
            : base(context)
        { }
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

