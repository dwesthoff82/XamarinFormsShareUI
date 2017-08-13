using System;
using Xamarin.Forms;

using Xamarin.Forms.Platform.Android;

using Android.App;
using AndHow.SharedComponents.Android;
using AndHow.SharedComponents;



[assembly: ExportRenderer(typeof(CustomDatePicker), typeof(CustomDatePickerRenderer))]
namespace AndHow.SharedComponents.Android
{
	public class CustomDatePickerRenderer : CustomFontLabelRenderer
	{
		
		protected override void OnElementChanged (ElementChangedEventArgs<Label> e)
		{
			base.OnElementChanged (e);

			var label = (CustomDatePicker)Element;
		


			if (label != null && Control != null) {
				Control.Click += delegate {
					new DatePickerDialog (this.Context, OnDateSet, label.newDate.Year, label.newDate.Month-1, label.newDate.Day).Show();
				};
			 }
		}


		//added this comment to check build in jenkins

		public void OnDateSet(object sender, DatePickerDialog.DateSetEventArgs ed)
		{

			var picker = ((CustomDatePicker)Element);
			if(picker !=null )
				picker.dateSet(ed.Date);

			//EmpowerOneBaseContentPage.setDatePickerDate (ed.Date);
		}
	}
}

