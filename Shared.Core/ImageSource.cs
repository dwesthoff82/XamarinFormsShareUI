using System;
using Xamarin.Forms.Platform.Android;
using Android;
using Android.Graphics;
using Android.Content;

namespace Shared.Core
{
	public class ImageSourceCustom : ImageRenderer
	{
        public ImageSourceCustom(Context context)
            : base(context)
        { }

		protected override void OnElementChanged (ElementChangedEventArgs<Xamarin.Forms.Image> e)
		{
			base.OnElementChanged (e);


			if (e.OldElement == null) {
			
				
			
			
			
			}



		}


	}
}

