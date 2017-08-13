using System;
using Xamarin.Forms.Platform.Android;

using Xamarin.Forms;
using Android.Graphics;
using AndHow.SharedComponents.Android;
using AndHow.SharedComponents;


[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
namespace AndHow.SharedComponents.Android
{
	public class CustomEntryRenderer : EntryRenderer
	{

	
		protected override void OnElementChanged (ElementChangedEventArgs<Xamarin.Forms.Entry> e)
		{
			base.OnElementChanged (e);

			if (e.OldElement == null && Control != null) {
			
				var label = Element as CustomEntry;
				if(!string.IsNullOrEmpty(label.FontName))
					Control.Typeface = Typeface.CreateFromAsset (Forms.Context.Assets, label.FontName + ".ttf");
				if(label.FontSize != 0)
					Control.TextSize = (float)label.FontSize;

				Control.SetTextColor (label.TextColor.ToAndroid());
				Control.SetBackgroundResource (UISharedComponentsAndroid.Resource.Drawable.Border);
			
			
			}
		}


	}
}

