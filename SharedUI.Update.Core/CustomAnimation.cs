using System;
using Xamarin.Forms;

namespace AndHow.SharedComponents
{
	/// <summary>
	/// Custom animation this is a place holder the custom animation does all the work...
	/// </summary>
	public class CustomAnimation : View
	{
		public static BindableProperty isAnimatingProperty = BindableProperty.Create<CustomAnimation,bool>((g)=>g.isAnimating,false);
		public static BindableProperty startAnimatingProperty = BindableProperty.Create<CustomAnimation,bool>((g)=>g.startAnimating,false);
		public static BindableProperty doneProperty = BindableProperty.Create<CustomAnimation,bool>((g)=>g.Done,false);
		bool _startAnimating = false;


		public bool Done{

			get{ 
			
				return (bool)GetValue (doneProperty);
			}
			set{ 
				SetValue (doneProperty, value);
				OnPropertyChanged ();
			}


		}

		public bool isAnimating{

			get{ return (bool)GetValue (isAnimatingProperty);}
			set{ SetValue (isAnimatingProperty, value);
				OnPropertyChanged ();
			}

		}

		public bool startAnimating {

			get{ return (bool)GetValue(startAnimatingProperty);}
			set{ 
			
				SetValue (startAnimatingProperty, value);
				isAnimating = true;
				OnPropertyChanged ();
			
			
			}

		}



	}
}

