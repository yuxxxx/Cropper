using System;
using System.Linq;
using CoreGraphics;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Cropper.CropperPage), typeof(Cropper.iOS.CropperPageRenderer))]

namespace Cropper.iOS
{
	public class CropperPageRenderer : PageRenderer
	{
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			var vc = UIStoryboard.FromName("Main", null).InstantiateViewController("CropperPage");
			AddChildViewController(vc);
			NativeView.AddSubviews(vc.View.Subviews);
		}

		protected override void OnElementChanged(VisualElementChangedEventArgs e)
		{
			base.OnElementChanged(e);

			var page = e.NewElement as CropperPage;
			var view = NativeView;

			var label = new UILabel(new CGRect(20, 40, view.Frame.Width - 40, 40));
			label.AdjustsFontSizeToFitWidth = true;
			label.TextColor = UIColor.White;

			if (page != null)
			{
				label.Text = page.Text;
			}

			view.Add(label);
		}
	}
}

