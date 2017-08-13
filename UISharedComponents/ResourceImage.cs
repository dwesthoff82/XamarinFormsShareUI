using System;
using Xamarin.Forms;
using System.IO;

namespace AndHow.SharedComponents
{
	public class ResourceImage :Image
	{
		public enum SourceTypes{

			Database,
			File,
			Function,


		}
		private bool _LoadAct = false;
		public bool LoadAct { get{
				return _LoadAct;
			}

			set{ _LoadAct = value; OnPropertyChanged ("LoadAct");
			
			}
		}
		public Func<Stream> Func{ get; set; }
		public SourceTypes SourceType{ get; set;}
		public string ResName{ get; set;}
		public ResourceImage ()
		{
		}

		public ResourceImage (string name)
		{
			ResName = name;

		}

		public ResourceImage(Func<Stream> func){
		
			SourceType = SourceTypes.Function;
			Func = func;
		
		
		}
	}
}

