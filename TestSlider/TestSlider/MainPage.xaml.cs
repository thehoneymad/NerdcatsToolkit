using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using TestSlider.Resources;
using System.Windows.Media.Animation;

namespace TestSlider
{
    public partial class MainPage : PhoneApplicationPage
    {
        public int lastIndex = 0;
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void ImageBar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var multiplier = this.ImageBar.SelectedIndex;
            var ItemWidth = this.ImageBar.ActualWidth / this.ImageBar.Items.Count;

            DoubleAnimationUsingKeyFrames SlidingAnimation = this.MenuBorderSlidingStoryboard.Children.First() as DoubleAnimationUsingKeyFrames;
            var from = SlidingAnimation.KeyFrames.First() as EasingDoubleKeyFrame;
            var to = SlidingAnimation.KeyFrames.Last() as EasingDoubleKeyFrame;

            from.Value = (double)lastIndex * (double)ItemWidth;
            to.Value = (double)multiplier *(double)ItemWidth;

            lastIndex = multiplier;

            this.MenuBorderSlidingStoryboard.Begin();

        }

        

        

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}