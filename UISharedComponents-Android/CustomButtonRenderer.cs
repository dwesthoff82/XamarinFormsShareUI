using System;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using Android.Graphics;
using AndHow.SharedComponents.Android;
using AndHow.SharedComponents;


[assembly: ExportRenderer(typeof(CustomFontButton), typeof(CustomButtonRenderer))]
namespace AndHow.SharedComponents.Android
{
	public class CustomButtonRenderer : ButtonRenderer
	{
		protected override void OnElementChanged (ElementChangedEventArgs<Button> e)
		{
			base.OnElementChanged (e);


			var bt = (CustomFontButton)Element;


			if (bt != null && Control != null) {

				var tf = Typeface.CreateFromAsset (Forms.Context.Assets, bt.FontName + ".ttf");

				Control.Typeface = tf;
				Control.TextSize =(float) bt.FontSize;

			}
		}
	}
}

