using System;
using Xamarin.Forms;

namespace AndHow.SharedComponents
{
	public class CustomEntry : Entry
	{

		string _fontName = string.Empty;
		double _fontSize = 12;
		public string FontName
        {
            get
            {
                return _fontName;
            }
			set
            {
                _fontName = value;
				OnPropertyChanged ();

			}
        }



		public double FontSize
        {
            get
            {
                return _fontSize;
            }
            set
            {
                _fontSize = value;
				OnPropertyChanged ();


			}
        }
	}
}

