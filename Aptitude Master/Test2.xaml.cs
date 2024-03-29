﻿using Aptitude_Master.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace Aptitude_Master
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class Test2 : Page
    {

        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();

        /// <summary>
        /// This can be changed to a strongly typed view model.
        /// </summary>
        public ObservableDictionary DefaultViewModel
        {
            get { return this.defaultViewModel; }
        }

        /// <summary>
        /// NavigationHelper is used on each page to aid in navigation and 
        /// process lifetime management
        /// </summary>
        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }


        public Test2()
        {
            this.InitializeComponent();
            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += navigationHelper_LoadState;
            this.navigationHelper.SaveState += navigationHelper_SaveState;
        }

        /// <summary>
        /// Populates the page with content passed during navigation. Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="sender">
        /// The source of the event; typically <see cref="NavigationHelper"/>
        /// </param>
        /// <param name="e">Event data that provides both the navigation parameter passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested and
        /// a dictionary of state preserved by this page during an earlier
        /// session. The state will be null the first time a page is visited.</param>
        private void navigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="sender">The source of the event; typically <see cref="NavigationHelper"/></param>
        /// <param name="e">Event data that provides an empty dictionary to be populated with
        /// serializable state.</param>
        private void navigationHelper_SaveState(object sender, SaveStateEventArgs e)
        {
        }

        #region NavigationHelper registration

        /// The methods provided in this section are simply used to allow
        /// NavigationHelper to respond to the page's navigation methods.
        /// 
        /// Page specific logic should be placed in event handlers for the  
        /// <see cref="GridCS.Common.NavigationHelper.LoadState"/>
        /// and <see cref="GridCS.Common.NavigationHelper.SaveState"/>.
        /// The navigation parameter is available in the LoadState method 
        /// in addition to page state preserved during an earlier session.

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedFrom(e);
        }

        #endregion

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int count = 0;
            if (q1o2.IsChecked == true)
            {
                count++;
            }
            if (q2o3.IsChecked == true)
            {
                count++;
            }
            if (q3o1.IsChecked == true)
            {
                count++;
            }
            if (q4o1.IsChecked == true)
            {
                count++;
            }
            if (q5o3.IsChecked == true)
            {
                count++;
            }
            if (q6o2.IsChecked == true)
            {
                count++;
            }
            if (q7o1.IsChecked == true)
            {
                count++;
            }
            if (q8o2.IsChecked == true)
            {
                count++;
            }
            if (q9o2.IsChecked == true)
            {
                count++;
            }
            score.Text = "Score : " + count.ToString();
            if (count >= 6)
            {
                new Windows.UI.Popups.MessageDialog("You are qualified the second round!! You have succesfully completed our tests!! Have good aptitude skills").ShowAsync();
                this.Frame.Navigate(typeof(ItemsPage));
            }
            else
            {
                new Windows.UI.Popups.MessageDialog("You are not qualified in the second round!! Please take the test again").ShowAsync();
                this.Frame.Navigate(typeof(Test2));
            }

        }

        private void q1o1_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            switch (rb.GroupName)
            {
                case "q1":
                    q1o1.Background = new SolidColorBrush();
                    q1o2.Background = new SolidColorBrush();
                    q1o3.Background = new SolidColorBrush();
                    q1o4.Background = new SolidColorBrush();
                    if (rb.Name == q1o2.Name)
                    {
                        rb.Background = new SolidColorBrush(Colors.DarkGreen);
                    }
                    else
                    {
                        rb.Background = new SolidColorBrush(Colors.Red);
                    }
                    break;
                case "q2":
                    q2o1.Background = new SolidColorBrush();
                    q2o2.Background = new SolidColorBrush();
                    q2o3.Background = new SolidColorBrush();
                    q2o4.Background = new SolidColorBrush();
                    if (rb.Name == q2o3.Name)
                    {
                        rb.Background = new SolidColorBrush(Colors.DarkGreen);
                    }
                    else
                    {
                        rb.Background = new SolidColorBrush(Colors.Red);
                    }
                    break;
                case "q3":
                    q3o1.Background = new SolidColorBrush();
                    q3o2.Background = new SolidColorBrush();
                    q3o3.Background = new SolidColorBrush();
                    q3o4.Background = new SolidColorBrush();
                    if (rb.Name == q3o1.Name)
                    {
                        rb.Background = new SolidColorBrush(Colors.DarkGreen);
                    }
                    else
                    {
                        rb.Background = new SolidColorBrush(Colors.Red);
                    }
                    break;
                case "q4":
                    q4o1.Background = new SolidColorBrush();
                    q4o2.Background = new SolidColorBrush();
                    q4o3.Background = new SolidColorBrush();
                    q4o4.Background = new SolidColorBrush();
                    if (rb.Name == q4o1.Name)
                    {
                        rb.Background = new SolidColorBrush(Colors.DarkGreen);
                    }
                    else
                    {
                        rb.Background = new SolidColorBrush(Colors.Red);
                    }
                    break;
                case "q5":
                    q5o1.Background = new SolidColorBrush();
                    q5o2.Background = new SolidColorBrush();
                    q5o3.Background = new SolidColorBrush();
                    q5o4.Background = new SolidColorBrush();
                    if (rb.Name == q5o3.Name)
                    {
                        rb.Background = new SolidColorBrush(Colors.DarkGreen);
                    }
                    else
                    {
                        rb.Background = new SolidColorBrush(Colors.Red);
                    }
                    break;
                case "q6":
                    q6o1.Background = new SolidColorBrush();
                    q6o2.Background = new SolidColorBrush();
                    q6o3.Background = new SolidColorBrush();
                    q6o4.Background = new SolidColorBrush();
                    if (rb.Name == q6o2.Name)
                    {
                        rb.Background = new SolidColorBrush(Colors.DarkGreen);
                    }
                    else
                    {
                        rb.Background = new SolidColorBrush(Colors.Red);
                    }
                    break;
                case "q7":
                    q7o1.Background = new SolidColorBrush();
                    q7o2.Background = new SolidColorBrush();
                    q7o3.Background = new SolidColorBrush();
                    q7o4.Background = new SolidColorBrush();
                    if (rb.Name == q7o1.Name)
                    {
                        rb.Background = new SolidColorBrush(Colors.DarkGreen);
                    }
                    else
                    {
                        rb.Background = new SolidColorBrush(Colors.Red);
                    }
                    break;
                case "q8":
                    q8o1.Background = new SolidColorBrush();
                    q8o2.Background = new SolidColorBrush();
                    q8o3.Background = new SolidColorBrush();
                    q8o4.Background = new SolidColorBrush();
                    if (rb.Name == q8o2.Name)
                    {
                        rb.Background = new SolidColorBrush(Colors.DarkGreen);
                    }
                    else
                    {
                        rb.Background = new SolidColorBrush(Colors.Red);
                    }
                    break;
                case "q9":
                    q9o1.Background = new SolidColorBrush();
                    q9o2.Background = new SolidColorBrush();
                    q9o3.Background = new SolidColorBrush();
                    q9o4.Background = new SolidColorBrush();
                    if (rb.Name == q9o2.Name)
                    {
                        rb.Background = new SolidColorBrush(Colors.DarkGreen);
                    }
                    else
                    {
                        rb.Background = new SolidColorBrush(Colors.Red);
                    }
                    break;

            }

        }

    }
}
