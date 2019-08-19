using System;
using Xamarin.Forms;

using Xamarin.Forms.Platform.Android;

using Android.App;

using AndHow.SharedComponents;
using Android.Content;
using Shared.Core;

[assembly: ExportRenderer(typeof(CustomTimePicker), typeof(CustomTimePickerRenderer))]
namespace Shared.Core
{
	public class CustomTimePickerRenderer : CustomFontLabelRenderer
	{
        public CustomTimePickerRenderer(Context context)
            : base(context)
        { }


		protected override void OnElementChanged (ElementChangedEventArgs<Label> e)
		{
			base.OnElementChanged (e);

			var label = (CustomTimePicker)Element;



			if (label != null && Control != null) {

				if(label.DisplayMode == CustomTimePicker.PickerDisplayMode.Time)
					Control.SetBackgroundResource (Shared.Core.Resource.Drawable.border);
				Control.Click += delegate {

					var now = label.newDate;

					new  TimePickerDialog(this.Context, OnDateSet,now.Hour, now.Minute, false).Show();
				};
			}
		}


		protected override void OnElementPropertyChanged (object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{

			if (e.PropertyName == "IsVisible") {

                global::Android.Views.ViewStates state;
                if (((CustomTimePicker)sender).IsVisible) {
				
				
					state = global::Android.Views.ViewStates.Visible;
				} else
					state = global::Android.Views.ViewStates.Invisible;

				Control.Visibility = state;//((CustomTimePicker)sender).IsVisible  ? global::Android.Views.ViewStates.Visible : global::Android.Views.ViewStates.Invisible);

			}else
			base.OnElementPropertyChanged (sender, e);
		}

		public void OnDateSet(object sender, TimePickerDialog.TimeSetEventArgs ed)
		{

			var picker = ((CustomTimePicker)Element);
			if (picker != null) {
				var now = picker.newDate;

				picker.dateSet (now.Date.AddHours (ed.HourOfDay).AddMinutes (ed.Minute));
			}
			
		}
	}
}

