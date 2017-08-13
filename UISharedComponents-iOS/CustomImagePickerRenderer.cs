using System;
using Xamarin.Forms.Platform.iOS;
using UIKit;
using Xamarin.Forms;
using Foundation;
using AndHow.SharedComponents.iOS;
using AndHow.SharedComponents;


[assembly: ExportRenderer(typeof(CustomImagePicker), typeof(CustomImagePickerRenderer))]
namespace AndHow.SharedComponents.iOS
{


	public class CustomImagePickerRenderer : CustomFontLabelRenderer//, IUIImagePickerControllerDelegate
	{
		protected override void OnElementChanged (ElementChangedEventArgs<Label> e)
		{
			base.OnElementChanged (e);

			var label = (CustomImagePicker)Element;



			if (label != null && Control != null) {
				var tgrLabel = new UITapGestureRecognizer (() => {

					var window= UIApplication.SharedApplication.KeyWindow;
					var vc = window.RootViewController;
				

					var lastObject= window.Subviews[window.Subviews.Length-1];



					while (vc.PresentedViewController != null && vc.PresentedViewController.PresentedViewController != null)
					{

						vc = vc.PresentedViewController;
					}


				/*UINavigationBar.Appearance.SetTitleTextAttributes(new UITextAttributes()
					{
							Font = UIFont.FromName("Oswald-Regular",18.5f),
							TextColor =UIKit.UIColor.Black// Color.White

						});*/
					var _imagePicker  = new UIImagePickerController();
					//_imagePicker.ImagePickerControllerDelegate = this;

				//	UINavigationBar.Appearance.TintColor = UIColor.Blue;
				//	UINavigationBar.Appearance.BarTintColor = UIColor.Blue;

					//NavigationController.NavigationBar.Translucent = true;
					//UINavigationBar.Appearance.TintColor = UIColor.White;
					// set our source to the photo library
					_imagePicker.SourceType = UIImagePickerControllerSourceType.PhotoLibrary | UIImagePickerControllerSourceType.Camera;

					// set what media types
					_imagePicker.MediaTypes = UIImagePickerController.AvailableMediaTypes(UIImagePickerControllerSourceType.PhotoLibrary);

					_imagePicker.FinishedPickingMedia += (object sender, UIImagePickerMediaPickedEventArgs eee) => {

						bool isImage = false;
						switch(eee.Info[UIImagePickerController.MediaType].ToString()) {
						case "public.image":
							Console.WriteLine("Image selected");
							isImage = true;
							break;
						case "public.video":
							Console.WriteLine("Video selected");
							break;
						}

						// get common info (shared between images and video)
						NSUrl referenceURL = eee.Info[new NSString("UIImagePickerControllerReferenceUrl")] as NSUrl;
						if (referenceURL != null)
							Console.WriteLine("Url:"+referenceURL.ToString ());
						if(isImage) {
							// get the original image
							UIImage originalImage = eee.Info[UIImagePickerController.OriginalImage] as UIImage;

							if(originalImage != null) {
								// do something with the image
								Console.WriteLine ("got the original image");
						
								using (NSData imageData = originalImage.AsPNG()) {
									Byte[] myByteArray = new Byte[imageData.Length];
									System.Runtime.InteropServices.Marshal.Copy(imageData.Bytes, myByteArray, 0, Convert.ToInt32(imageData.Length));

									System.IO.MemoryStream ms = new System.IO.MemoryStream (myByteArray);
									((CustomImagePicker)Element).ImagePicked (ms);
									_imagePicker.DismissViewController(true,null);
								}

							}
						}


					};

					_imagePicker.Canceled += (sender, evt) =>
					{
						

						Console.WriteLine("picker cancelled");


						BeginInvokeOnMainThread(()=>{
							//_imagePicker.View.RemoveFromSuperview();
							_imagePicker.DismissViewController(true,null);
						});
						//_imagePicker.DismissViewController(true,null);//DismissViewController(false,null);//DismissModalViewControllerAnimated(true);
						//_imagePicker.ParentViewController.DismissViewController(false,null);
					
					};
					//_imagePicker.Delegate = this;

					//PresentModalViewController is depreciated in iOS6 so we use PresentViewController
					//this.PresentViewController(_imagePicker, true, null);
					//var ip = _imagePicker.NavigationBar.Items;

					//lastObject.AddSubview(_imagePicker.View);
					//_imagePicker.ViewWillAppear( true);
					//_imagePicker.ViewDidAppear(true);
					vc.PresentViewController(_imagePicker,true,null);

				});
				Control.AddGestureRecognizer (tgrLabel);
				Control.UserInteractionEnabled = true;
			}
		}

		/*
		protected void Handle_FinishedPickingMedia (object sender, UIImagePickerMediaPickedEventArgs e)
		{
			// determine what was selected, video or image
			bool isImage = false;
			switch(e.Info[UIImagePickerController.MediaType].ToString()) {
			case "public.image":
				Console.WriteLine("Image selected");
				isImage = true;
				break;
			case "public.video":
				Console.WriteLine("Video selected");
				break;
			}

			// get common info (shared between images and video)
			NSUrl referenceURL = e.Info[new NSString("UIImagePickerControllerReferenceUrl")] as NSUrl;
			if (referenceURL != null)
				Console.WriteLine("Url:"+referenceURL.ToString ());

			// if it was an image, get the other image info
			if(isImage) {
				// get the original image
				UIImage originalImage = e.Info[UIImagePickerController.OriginalImage] as UIImage;
				if(originalImage != null) {
					// do something with the image
					Console.WriteLine ("got the original image");

					using (NSData imageData = originalImage.AsPNG()) {
						Byte[] myByteArray = new Byte[imageData.Length];
						System.Runtime.InteropServices.Marshal.Copy(imageData.Bytes, myByteArray, 0, Convert.ToInt32(imageData.Length));

						System.IO.MemoryStream ms = new System.IO.MemoryStream (myByteArray);
						((CustomImagePicker)Element).imagePicked (ms);
					}

				}
			} else { // if it's a video
				// get video url
				NSUrl mediaURL = e.Info[UIImagePickerController.MediaURL] as NSUrl;
				if(mediaURL != null) {
					Console.WriteLine(mediaURL.ToString());
				}
			}
			// dismiss the picker
			imagePicker.DismissModalViewControllerAnimated (true);
		}*/


	}

}

