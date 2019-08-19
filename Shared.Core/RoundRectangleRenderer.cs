using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using AndHow.SharedComponents;
using AndHow.SharedComponents.Android;
using Android.Content;

[assembly: ExportRenderer(typeof(RoundedRectangle),typeof(RoundRectangleRenderer))]
namespace AndHow.SharedComponents.Android
{
	public class RoundRectangleRenderer : ViewRenderer
    {
        public async static void Init()

        {

            var temp = DateTime.Now;

        }
        public RoundRectangleRenderer(Context context) : base(context)
        { }
        protected override void OnElementChanged (ElementChangedEventArgs<View> e)
		{
			base.OnElementChanged (e);

			if (e.OldElement == null) {
				RoundedRectangle roundRect = (RoundedRectangle)Element;
                var cn = new Shared.Core.Rectangle(this.Context) { Color = roundRect.Color.ToAndroid() };

				SetNativeControl (cn);

			}


		}

	}

}

