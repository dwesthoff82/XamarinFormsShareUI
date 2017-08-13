using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using AndHow.SharedComponents.Android;
using AndHow.SharedComponents;


[assembly: ExportRenderer(typeof(CurvedStackLayout), typeof(CurvedStackRenderer))]
namespace AndHow.SharedComponents.Android
{
	public class CurvedStackRenderer : Xamarin.Forms.Platform.Android.VisualElementRenderer<StackLayout>
	{
		protected override void OnElementChanged (ElementChangedEventArgs<StackLayout> e)
		{
			
			base.OnElementChanged (e);

			if (e.OldElement == null) {
				this.ViewGroup.SetLayerType (global::Android.Views.LayerType.Software,null);
				this.ViewGroup.SetBackgroundResource (UISharedComponentsAndroid.Resource.Drawable.RoundedRectShape);


			}

		}



	}
}

