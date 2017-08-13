using System;
using Xamarin.Forms;

using Xamarin.Forms.Platform.iOS;
using UIKit;
using SharpMobileCode.ModalPicker;
using AndHow.SharedComponents;
using AndHow.SharedComponents.iOS;


[assembly: ExportRenderer(typeof(CustomTimePicker), typeof(CustomTimePickerRenderer))]
namespace AndHow.SharedComponents.iOS
{
	public class CustomTimePickerRenderer : CustomFontLabelRenderer
	{

		protected override void OnElementChanged (ElementChangedEventArgs<Label> e)
		{
			base.OnElementChanged (e);

			var label = (CustomTimePicker)Element;



			if (label != null && Control != null) {

				if(label.DisplayMode == CustomTimePicker.PickerDisplayMode.Time){
					Control.Layer.BorderWidth = 1.5f;
					Control.Layer.BorderColor = Color.FromHex ("a6a6a6").ToCGColor ();
				}



				var tgrLabel = new UITapGestureRecognizer (() => {

					var window= UIApplication.SharedApplication.KeyWindow;
					var vc = window.RootViewController;
					while (vc.PresentedViewController != null)
					{

						vc = vc.PresentedViewController;
					}
					var modalPicker = new ModalPickerViewController(ModalPickerType.Date, "Select Time",vc)
					{
						HeaderBackgroundColor = UIColor.LightGray,
						HeaderTextColor = UIColor.White,
						TransitioningDelegate = new ModalPickerTransitionDelegate(),
						ModalPresentationStyle = UIModalPresentationStyle.Custom

					};


					modalPicker.DatePicker.Mode = UIDatePickerMode.Time;
					modalPicker.DatePicker.SetDate(label.newDate.AddDays(1).ToNSDate(),false);
					modalPicker.OnModalPickerDismissed += (object sender, EventArgs ee) => {

						var comp = modalPicker.DatePicker.Calendar.Components(Foundation.NSCalendarUnit.Hour|Foundation.NSCalendarUnit.Minute,modalPicker.DatePicker.Date);
						//var ts = new TimeSpan(comp.Hour,comp.Minute,0);
						label.dateSet(modalPicker.DatePicker.Date.ToDateTime().Date.AddHours(comp.Hour).AddMinutes(comp.Minute));





					};

					vc.PresentViewController(modalPicker,true,null);

				});
				Control.AddGestureRecognizer (tgrLabel);
				Control.UserInteractionEnabled = true;
			}
		}


	}
}

