using System;
using System.IO;


namespace AndHow.SharedComponents
{
	public class CustomImagePicker : CustomFontLabel
	{


		public delegate void imagePickedEventHandler(Stream image);

		public event imagePickedEventHandler imagePicked;
		public void ImagePicked(Stream s){
		
			if(imagePicked != null)
				imagePicked (s);
		
		}
		public CustomImagePicker ()
		{

		}


	}
}

