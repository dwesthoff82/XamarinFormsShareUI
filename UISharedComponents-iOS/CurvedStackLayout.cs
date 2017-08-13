using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using UIKit;
using AndHow.SharedComponents.iOS;
using AndHow.SharedComponents;


[assembly: ExportRenderer(typeof(CurvedStackLayout), typeof(CurvedStackLayoutRenderer))]
namespace AndHow.SharedComponents.iOS
{
	public class CurvedStackLayoutRenderer : Xamarin.Forms.Platform.iOS.VisualElementRenderer<StackLayout>
	{
		protected override void OnElementChanged (ElementChangedEventArgs<StackLayout> e)
		{
			base.OnElementChanged (e);

			if (e.OldElement == null) {
			
			
				this.NativeView.Layer.CornerRadius = 9.5f;

			
			
			}

		}


		
	}
}

