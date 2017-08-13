using System;
using Xamarin.Forms;

using Xamarin.Forms.Platform.iOS;

using UIKit;
using SharpMobileCode.ModalPicker;
using AndHow.SharedComponents.iOS;
using AndHow.SharedComponents;




[assembly: ExportRenderer(typeof(CustomDatePicker), typeof(CustomDatePickerRenderer))]
namespace AndHow.SharedComponents.iOS
{
	public class CustomDatePickerRenderer : CustomFontLabelRenderer
	{

		protected override void OnElementChanged (ElementChangedEventArgs<Label> e)
		{
			base.OnElementChanged (e);

			var label = (CustomDatePicker)Element;



			if (label != null && Control != null) {
				var tgrLabel = new UITapGestureRecognizer (() => {
				
					var window= UIApplication.SharedApplication.KeyWindow;
					var vc = window.RootViewController;
					while (vc.PresentedViewController != null)
					{
						
						vc = vc.PresentedViewController;
					}
					var modalPicker = new ModalPickerViewController(ModalPickerType.Date, "Select A Date",vc)
					{
						HeaderBackgroundColor = UIColor.LightGray,
						HeaderTextColor = UIColor.White,
						TransitioningDelegate = new ModalPickerTransitionDelegate(),
						ModalPresentationStyle = UIModalPresentationStyle.Custom
							
					};

				
					//modalPicker.DatePicker.Mode = UIDatePickerMode.DateAndTime;
					modalPicker.DatePicker.SetDate(label.newDate.AddDays(1).ToNSDate(),false);
					modalPicker.DatePicker.Mode = UIDatePickerMode.Date;
					modalPicker.OnModalPickerDismissed += (object sender, EventArgs ee) => {

						label.dateSet(modalPicker.DatePicker.Date.ToDateTime());

					};
				
					vc.PresentViewController(modalPicker,true,null);
				
				});
				Control.AddGestureRecognizer (tgrLabel);
				Control.UserInteractionEnabled = true;
			}
		}

	/*	public void OnDateSet(object sender, DatePickerDialog.DateSetEventArgs ed)
		{

			var picker = ((CustomDatePicker)Element);
			if(picker !=null )
				picker.dateSet(ed.Date);

			//EmpowerOneBaseContentPage.setDatePickerDate (ed.Date);
		}*/
	}
}

