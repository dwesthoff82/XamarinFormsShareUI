using System;
using Xamarin.Forms;

namespace AndHow.SharedComponents
{
	public class CustomFontLabel : Label
	{
		string _fontName = string.Empty;
		double _fontSize= 12;
		double _MarginLeft =0;
		double _MarginRight =0;
		double _border  = 0;
		double _borderRadius =0;
		Color _borderColor;

		public double MarginLeft{

			set{ _MarginLeft = value; 
				OnPropertyChanged ();
			}

			get{ return _MarginLeft;}

		}

		public double MarginRight{

			set{ _MarginRight = value; 
				OnPropertyChanged ();
			}

			get{ return _MarginRight;}

		}

		public double BorderRadius{

			get{ return _borderRadius;}
			set{ 
				_borderRadius = value;
				OnPropertyChanged ();
			}

		}


		public Color BorderColor{

			set{ 
			
				_borderColor = value;
				OnPropertyChanged ();
			
			
			}
			get{ return _borderColor;}


		}

		public double Border{
			set{ 
			
				_border = value;
				OnPropertyChanged ();
			
			}

			get{ return _border;}

		}
		public string FontName{ get{ return _fontName;}
			set{ _fontName = value;
				OnPropertyChanged ();

			}}



		public double FontSize{ get{ return _fontSize;} set{ _fontSize = value;
				OnPropertyChanged ();

			
			}}

		public CustomFontLabel (string fontName,double fontSize)

		{

			this.FontSize = fontSize;
			this.FontName = fontName;


		}

		public CustomFontLabel ()
		{




		}
	}
}

