using System;
using Xamarin.Forms;

namespace AndHow.SharedComponents
{
	public class CustomPicker : Picker
	{

		double _border  = 0;
		Color _borderColor;
		double _fontSize;
		string _fontName = string.Empty;

		Color _textColor = Color.Black;
//		string _hint = string.Empty;
//
		public Color TextColor{

			get{ return _textColor;}set{ _textColor = value; OnPropertyChanged ();}



		}
		public double FontSize{ get{ return _fontSize;} set{ _fontSize = value;
				OnPropertyChanged ();


			}}
		
		public double Border{ get{ return _border;} set{ _border = value;
				OnPropertyChanged ();


			}}

		public Color BorderColor{ get{ return _borderColor;} set{ _borderColor = value;
				OnPropertyChanged ();


			}}

		public string FontName{ get{ return _fontName;} set{ _fontName = value;
				OnPropertyChanged ();


			}}
//
//		public double FontSize{ get{ return _fontSize;} set{ _fontSize = value;
//				OnPropertyChanged ();
//
//
//			}}
		public CustomPicker ()
		{
		}
	}
}

