using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using AlKompass.Resources;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;
using System.IO.IsolatedStorage;
using Microsoft.Phone.Tasks;
using System.Windows.Threading;


namespace AlKompass
{
    public partial class MainPage : PhoneApplicationPage
    {
        public static readonly DependencyProperty AngleProperty = DependencyProperty.Register("Angle", typeof(double), typeof(MainPage), new PropertyMetadata(default(double)));

        CompassHelper compassHelper = null;
        DispatcherTimer timer;
        int counter = 0;
        CSVfy.Alko lahinAlko;
        public double ArrowAngle
        {
            get { return (double)GetValue(AngleProperty); }
            set { SetValue(AngleProperty, value); }
        }

        internal void UpdateLahinAlko()
        {
            if (lahinAlko != null && lahinAlko.Nimi != null)
            {
                // rude hack to get rid of unnecessary characters
                LahinAlko.Text = lahinAlko.Nimi.Replace("[", "").Replace("]", "").Replace('�', 'ä').Replace('�', 'ö');
                // format the distance to more human readable form
                Etaisyys.Text = (distance / 1000).ToString("0.00") + " km";
            }
        }

        async void timer_Tick(object sender, EventArgs e)
        {
            lahinAlko = await GetNearestAlko();
            if (counter % 100 == 0) // calculate nearest alko only every 100:th timer tick. 
            {
                UpdateLahinAlko();
            }
            counter++;
            UpdateArrowRotation(); // spin the arrow need to the direction of nearest Alko.
        }

        // Constructor
        public MainPage()
        {
            ArrowAngle = 45;
            InitializeComponent();
            compassHelper = new CompassHelper(this);
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(120);
            timer.Tick += new EventHandler(timer_Tick);
            // Sample code to localize the ApplicationBar.. not yet implemented

            //BuildLocalizedApplicationBar();
        }

        // Sample code for building a localized ApplicationBar.. not yet implemented
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
        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            if (IsolatedStorageSettings.ApplicationSettings.Contains("LocationConsent"))
            {
                // User has opted in or out of Location
                return;
            }
            else
            {
                MessageBoxResult result =
                    MessageBox.Show("Tämä ohjelma haluaa tietää sijaintisi, onko tämä ok?",
                    "GPS",
                    MessageBoxButton.OKCancel);
                // store the result to settings. this is currently bit stupid, because this app has no meaningful use without GPS data
                if (result == MessageBoxResult.OK)
                {
                    IsolatedStorageSettings.ApplicationSettings["LocationConsent"] = true;
                }
                else
                {
                    IsolatedStorageSettings.ApplicationSettings["LocationConsent"] = false;
                }

                IsolatedStorageSettings.ApplicationSettings.Save();
            }
        }
        private double distance = double
            .MaxValue;
        private async Task<CSVfy.Alko> GetNearestAlko()
        {
            var currentCoordinate = await LocationHelper.CurrentLocation();
            if (currentCoordinate.latitude == LocationHelper.VIRHEKOORDINAATTI.latitude)
            {
                return null;
            }
            distance = double.MaxValue;
            CSVfy.Alko lahinAlko = null;
            foreach (var alko in CSVfy.Myymalat.alkot)
            {
                var distanceToThisAlko = LocationHelper.CountDistance(currentCoordinate.latitude, currentCoordinate.longitude, alko.Latitude, alko.Longitude);
                if (distanceToThisAlko < distance)
                {
                    distance = distanceToThisAlko;
                    lahinAlko = alko;
                }

            }
            return lahinAlko;
        }
        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            if (!compassHelper.SupportsCompass())
            {
                // The device on which the application is running does not support
                // the compass sensor. Alert the user and hide the
                // application bar.
                ApplicationBar.IsVisible = false;
                nuoli.Visibility = Visibility.Collapsed;
            }
            else
            {
                compassHelper.StartCompass();
                _compassRunning = true;
                System.Threading.Thread.Sleep(50);
            }
            timer.Start();

        }

        private async void UpdateArrowRotation()
        {
            if (lahinAlko == null)
            {
                return;
            }
            var currentCoordinate = await LocationHelper.CurrentLocation();
            var bearing = CompassHelper.DegreeBearing(currentCoordinate.latitude, currentCoordinate.longitude, lahinAlko.Latitude, lahinAlko.Longitude);
            var compassHeading = compassHelper.GetHeading();
            var rotation = (bearing - compassHeading);
            if (rotation < 0)
            {
                rotation += 360;
            }
            //Debuggi.Text = string.Format("Bearing:{0},Compass{1}", bearing, compassHeading);
            RotaattiTransform.Angle = rotation;

        }
        // handler for button that shows the directions to nearest Alko on Google maps
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var currentCoordinate = await LocationHelper.CurrentLocation();
            if (currentCoordinate.latitude == LocationHelper.VIRHEKOORDINAATTI.latitude || lahinAlko == null)
            {
                return;
            }
            // google maps route url template: @"http://maps.google.com/?saddr=%1.6f,%1.6f&daddr=%1.6f,%1.6f";'
            var linkUrl = string.Concat
                (@"http://maps.google.com/?saddr=", currentCoordinate.latitude.ToString().Replace(',', '.'), ",", currentCoordinate.longitude.ToString().Replace(',', '.'),
                "&daddr=", lahinAlko.Latitude.ToString().Replace(',', '.'), ",", lahinAlko.Longitude.ToString().Replace(',', '.'), "");
            
            WebBrowserTask webBrowserTask = new WebBrowserTask();
            webBrowserTask.Uri = new System.Uri(linkUrl); 
            webBrowserTask.Show();
        }

        private bool _compassRunning = false;

        private void ToggleCompassAppBarButton_Click(object sender, EventArgs e)
        {
            if (_compassRunning)
            {
                _compassRunning = false;
                compassHelper.StopCompass();
            }
            else
            {
                _compassRunning = true;
                compassHelper.StartCompass();
            }

        }

        private void calibrationButton_Click(object sender, RoutedEventArgs e)
        {
            calibrationStackPanel.Visibility = Visibility.Collapsed;
            compassHelper.calibrating = false;
        }

        internal void StartCalibration()
        {
            Dispatcher.BeginInvoke(() => { this.calibrationStackPanel.Visibility = Visibility.Visible; });
        }
    }

}

