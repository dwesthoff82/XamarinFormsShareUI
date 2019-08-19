using System;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using Android.Graphics;

using AndHow.SharedComponents;
using Android.Content;
using Shared.Core;

[assembly: ExportRenderer(typeof(CustomFontButton), typeof(CustomButtonRenderer))]
namespace Shared.Core
{
	public class CustomButtonRenderer : ButtonRenderer
	{
        public CustomButtonRenderer(Context context)
            : base(context)
        { }
		protected override void OnElementChanged (ElementChangedEventArgs<Button> e)
		{
			base.OnElementChanged (e);


			var bt = (CustomFontButton)Element;


			if (bt != null && Control != null) {

				var tf = Typeface.CreateFromAsset (this.Context.Assets, bt.FontName + ".ttf");

				Control.Typeface = tf;
				Control.TextSize =(float) bt.FontSize;

			}
		}
	}
}

