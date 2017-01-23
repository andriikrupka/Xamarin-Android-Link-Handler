using Android.App;
using Android.Widget;
using Android.OS;
using Android.Text;
using System;

namespace Xamarin.Droid.LinkHandler
{
    [Activity(Label = "Xamarin.Droid.LinkHandler", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

            var textView = FindViewById<TextView>(Resource.Id.myTextView);
            textView.TextFormatted = Html.FromHtml(
                    "<b>Url:</b>  Text with a " +
                    "<a href=\"http://www.xamarin.com\">link</a> " +
                "created in the Java source code using HTML.");

            var extendedLinkMovementMethod = new ExtendedLinkMovementMethod(new string[] { "www", "http" });
            extendedLinkMovementMethod.LinkClicked += OnLinkClicked;
            textView.MovementMethod = extendedLinkMovementMethod;
        }

        private void OnLinkClicked(object sender, string e)
        {
            var alertBuilder = new AlertDialog.Builder(this);
            alertBuilder.SetMessage(e)
                        .SetPositiveButton("ok", (s, args) => { })
                        .Show();
        }
    }
}

