using System;
using Xamarin.Forms;



namespace AndHow.SharedComponents
{
	public class CustomDatePicker : CustomFontLabel
	{


		public delegate void dateChangedEventHandler(DateTime selectedDate);

		public event dateChangedEventHandler dateChanged;
		public DateTime newDate;
		public CustomDatePicker ()
		{
			
		}



		public void dateSet(DateTime dt) 
		{
			if (dateChanged != null)
				dateChanged (dt);
		}
	}
}

