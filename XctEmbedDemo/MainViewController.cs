using System;
using CoreGraphics;
using UIKit;
using Xamarin.Forms;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.CommunityToolkit.Extensions;

namespace XctEmbedDemo
{
    public class MainViewController : UIViewController
    {
        private Popup popup;

        public MainViewController()
        {
            popup = new Popup
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Hello Xct World!"
                        }
                    }
                }
            };
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            View.BackgroundColor = UIColor.White;
            Title = "Popup Demo";

            var button = UIButton.FromType(UIButtonType.System);
            button.Frame = new CGRect(20, 200, 280, 44);
            button.SetTitle("Show Xct Popup", UIControlState.Normal);
            button.TouchUpInside += OnTouchUpInside;

            View.AddSubview(button);
        }

        private void OnTouchUpInside(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine("Tapped button!");
                Xamarin.Forms.Application.Current.MainPage.Navigation.ShowPopup(popup);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
