using System;


namespace AndHow.SharedComponents
{
	public class CustomTimePicker : CustomFontLabel
	{
		public delegate void timeChangedEventHandler(DateTime selectedDate);
		public enum PickerDisplayMode
		{

			Icon,
			Time,
		
		}



		public PickerDisplayMode DisplayMode{ get; set;}
		public event timeChangedEventHandler dateChanged;
		public DateTime newDate;
		public CustomTimePicker (DateTime dt)
		{

			newDate = dt;
		}



		public void dateSet(DateTime dt) 
		{
			if (DisplayMode == PickerDisplayMode.Time) {
				this.Text = dt.ToString ("t").ToLower ().Replace (" ", "");

			}

			newDate = dt;
			if (dateChanged != null)
				dateChanged (dt);
		}
	}
}


