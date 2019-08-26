using System;
using Xamarin.Forms.Platform.Android;

using Xamarin.Forms;
using Android.Graphics;

using AndHow.SharedComponents;
using Android.Content;
using Shared.Core;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
namespace Shared.Core
{
    public class CustomEntryRenderer : EntryRenderer
    {

    
        public CustomEntryRenderer(Context context)
            :base(context)
            {}
	
		protected override void OnElementChanged (ElementChangedEventArgs<Xamarin.Forms.Entry> e)
		{
			base.OnElementChanged (e);

			if (e.OldElement == null && Control != null) {
			
				var label = Element as CustomEntry;
				if(!string.IsNullOrEmpty(label.FontName))
					Control.Typeface = Typeface.CreateFromAsset (this.Context.Assets, label.FontName + ".ttf");
				if(label.FontSize != 0)
					Control.TextSize = (float)label.FontSize;

				Control.SetTextColor (label.TextColor.ToAndroid());
				Control.SetBackgroundResource (Shared.Core.Resource.Drawable.border);
			
			
			}
		}


	}
}

