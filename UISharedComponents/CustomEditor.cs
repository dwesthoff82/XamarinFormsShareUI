using System;
using Xamarin.Forms;

namespace AndHow.SharedComponents
{
	public class CustomEditor : Editor
	{
		double _border  = 0;
		Color _borderColor;
		double _fontSize;
		string _fontName = string.Empty;
		Color _textColor = Color.Black;
		string _hint = string.Empty;

		public event EventHandler Completed;
		public void DoneEditingProp(){





			
				this.Completed (null, null);
			
			


		}



		public double FontSize{ get{ return _fontSize;} set{ _fontSize = value;
				OnPropertyChanged ();


			}}

		public string FontName{ get{ return _fontName;}
			set{ _fontName = value;
				OnPropertyChanged ();

			}}

		public string Hint{ get{ return _hint;}
			set{ _hint = value;
				OnPropertyChanged ();

			}}

		public double Border{
			set{ 

				_border = value;
				OnPropertyChanged ();

			}

			get{ return _border;}

		}


		public Color BorderColor{

			set{ 

				_borderColor = value;
				OnPropertyChanged ();


			}
			get{ return _borderColor;}


		}


		public Color TextColor{

			set{ 

				_textColor = value;
				OnPropertyChanged ();


			}
			get{ return _textColor;}


		}

		public CustomEditor (string fontName,double fontSize)

		{

			this.FontSize = fontSize;
			this.FontName = fontName;


		}


		public CustomEditor ()
		{




		}
	}
}

