using System;
using Xamarin.Forms.Platform.Android;
using Xamarin;
using Xamarin.Forms;

using AndHow.SharedComponents;
using Android.Content;
using Shared.Core;

[assembly: ExportRenderer(typeof(CustomListView), typeof(CustomListViewRenderer))]
namespace Shared.Core
{
	public class CustomListViewRenderer : ListViewRenderer
	{
        public CustomListViewRenderer(Context context)
            : base(context)
        { }

		protected override void OnElementChanged (ElementChangedEventArgs<Xamarin.Forms.ListView> e)
		{
			base.OnElementChanged (e);
		
			if (e.OldElement == null && Control != null) {
		
				Control.ChoiceMode = global::Android.Widget.ChoiceMode.None;
				Control.Clickable = false;
				Control.HorizontalScrollBarEnabled = false;
				Control.VerticalScrollBarEnabled = false;

			}

		}

		protected override void OnElementPropertyChanged (object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{

			if (e.PropertyName == "Changed") {
			

				Control.DeferNotifyDataSetChanged ();
			
			
			}

			base.OnElementPropertyChanged (sender, e);
		}
	}
}

