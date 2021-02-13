using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using ColorTrouble.Resources;

namespace ColorTrouble
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public double score;
        Random rand;

        public MainPage()
        {
            InitializeComponent();

            score = 0;
            Score.Text = DateTime.Now.TimeOfDay.ToString();

            rand = new Random();//(DateTime.Today.Millisecond);
            glow_color(0);

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void Red_Glow_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (Red_Glow.Visibility == System.Windows.Visibility.Visible)
            {
                Red_Glow.Visibility = System.Windows.Visibility.Collapsed;
                score++;
                Score.Text = "Score : " + score;
                glow_color(1);
                //Yellow_Glow.Visibility = System.Windows.Visibility.Visible;
            }
        }

        private void Yellow_Glow_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (Yellow_Glow.Visibility == System.Windows.Visibility.Visible)
            {
                Yellow_Glow.Visibility = System.Windows.Visibility.Collapsed;
                score++;
                Score.Text = "Score : " + score;
                glow_color(2);
                //Green_Glow.Visibility = System.Windows.Visibility.Visible;
            }
        }

        private void Green_Glow_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (Green_Glow.Visibility == System.Windows.Visibility.Visible)
            {
                Green_Glow.Visibility = System.Windows.Visibility.Collapsed;
                score++;
                Score.Text = "Score : " + score;
                glow_color(3);
                //Blue_Glow.Visibility = System.Windows.Visibility.Visible;
            }
        }

        private void Blue_Glow_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (Blue_Glow.Visibility == System.Windows.Visibility.Visible)
            {
                Blue_Glow.Visibility = System.Windows.Visibility.Collapsed;
                score++;
                Score.Text = "Score : " + score;
                glow_color(4);
                //Red_Glow.Visibility = System.Windows.Visibility.Visible;
            }
        }

        void glow_color(int type)
        {
            int num = rand.Next(100);

            switch (type)
            {
                case 0:
                    if (num <= 25)
                    {
                        Red_Glow.Visibility = System.Windows.Visibility.Visible;
                    }
                    else if (num <= 50)
                    {
                        Yellow_Glow.Visibility = System.Windows.Visibility.Visible;
                    }
                    else if (num <= 75)
                    {
                        Green_Glow.Visibility = System.Windows.Visibility.Visible;
                    }
                    else
                    {
                        Blue_Glow.Visibility = System.Windows.Visibility.Visible;
                    }
                    break;
                case 1:
                    if (num <= 33)
                    {
                        Yellow_Glow.Visibility = System.Windows.Visibility.Visible;
                    }
                    else if (num <= 66)
                    {
                        Green_Glow.Visibility = System.Windows.Visibility.Visible;
                    }
                    else
                    {
                        Blue_Glow.Visibility = System.Windows.Visibility.Visible;
                    }
                    break;
                case 2:
                    if (num <= 33)
                    {
                        Red_Glow.Visibility = System.Windows.Visibility.Visible;
                    }
                    else if (num <= 66)
                    {
                        Green_Glow.Visibility = System.Windows.Visibility.Visible;
                    }
                    else
                    {
                        Blue_Glow.Visibility = System.Windows.Visibility.Visible;
                    }
                    break;
                case 3:
                    if (num <= 33)
                    {
                        Red_Glow.Visibility = System.Windows.Visibility.Visible;
                    }
                    else if (num <= 66)
                    {
                        Yellow_Glow.Visibility = System.Windows.Visibility.Visible;
                    }
                    else
                    {
                        Blue_Glow.Visibility = System.Windows.Visibility.Visible;
                    }
                    break;
                case 4:
                    if (num <= 33)
                    {
                        Red_Glow.Visibility = System.Windows.Visibility.Visible;
                    }
                    else if (num <= 66)
                    {
                        Yellow_Glow.Visibility = System.Windows.Visibility.Visible;
                    }
                    else
                    {
                        Green_Glow.Visibility = System.Windows.Visibility.Visible;
                    }
                    break;
            }
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