using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

using AndHow.SharedComponents;
using Android.Content;
using Shared.Core;

[assembly: ExportRenderer(typeof(CurvedStackLayout), typeof(CurvedStackRenderer))]
namespace Shared.Core
{
    public class CurvedStackRenderer : Xamarin.Forms.Platform.Android.VisualElementRenderer<StackLayout>
    {


        public static void Init()
        {

           

        }

        public CurvedStackRenderer(Context context)
            : base(context)
        {


        }


        protected override void OnElementChanged(ElementChangedEventArgs<StackLayout> e)
        {

            base.OnElementChanged(e);




            if (e.OldElement == null)
            {

                var csl =  (CurvedStackLayout)this.Element;
               
                this.ViewGroup.SetLayerType(global::Android.Views.LayerType.Software, null);
                this.ViewGroup.SetBackgroundResource(Shared.Core.Resource.Drawable.roundrectshape);


            }

        }



    }
}

