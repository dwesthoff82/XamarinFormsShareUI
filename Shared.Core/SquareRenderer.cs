using System;
using Xamarin.Forms.Platform.Android;
using Android.Views;
using Xamarin.Forms;
using AndHow.SharedComponents;

using Android.Content;
using Shared.Core;

[assembly: ExportRenderer(typeof(Square), typeof(SquareRenderer))]
namespace Shared.Core
{
    public class SquareRenderer : ViewRenderer
    {

        public SquareRenderer(Context context)
            : base(context)
        {




        }
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.View> e)
        {
            base.OnElementChanged(e);


            if (e.OldElement == null)
            {

                var uiv = new global::Android.Views.View(this.Context);
                uiv.SetBackgroundResource(Shared.Core.Resource.Drawable.border);

                this.SetNativeControl(uiv);


                if (((Square)Element).DisplayActivityIndicator)
                {





                }


                //this.NativeView.Layer.BorderColor = Color.Gray.ToCGColor();
                //this.NativeView.Layer.BorderWidth = 1;

            }
        }
    }
}

