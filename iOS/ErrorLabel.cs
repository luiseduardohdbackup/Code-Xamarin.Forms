using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using MonoTouch.UIKit;

public class ErrorLabelRenderer : LabelRenderer
{

	protected override void OnElementChanged (ElementChangedEventArgs<Label> e)
	{
		base.OnElementChanged(e);

		if (e.OldElement == null) {   // perform initial setup
			var nativeLabel = (UILabel)Control;
			nativeLabel.BackgroundColor = UIColor.Red;
			nativeLabel.TextColor = UIColor.White;
		}
	}
}

