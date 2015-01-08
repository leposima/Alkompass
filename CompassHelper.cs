
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Devices.Sensors;
using Microsoft.Xna.Framework;
using System.Windows.Threading;


namespace AlKompass
{
    class CompassHelper
    {
        Compass compass;
        DispatcherTimer timer;

        double magneticHeading;
        double trueHeading;
        double headingAccuracy;
        Vector3 rawMagnetometerReading;
        bool isDataValid;
        MainPage mainPage = null;
        public CompassHelper(MainPage mainPage)
        {
            this.mainPage = mainPage;
            // Initialize the timer and add Tick event handler, but don't start it yet.
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(30);
            timer.Tick += new EventHandler(timer_Tick);
        }

        public bool calibrating = false;


        public bool SupportsCompass()
        {
            return Compass.IsSupported;
        }

        public void StopCompass()
        {
            if (compass != null && compass.IsDataValid)
            {
                // Stop data acquisition from the compass.
                compass.Stop();
                timer.Stop();
            }
        }

        public void StartCompass()
        {
            if (compass == null)
            {
                // Instantiate the compass.
                compass = new Compass();

                // Specify the desired time between updates. The sensor accepts
                // intervals in multiples of 20 ms.
                compass.TimeBetweenUpdates = TimeSpan.FromMilliseconds(20);

                // The sensor may not support the requested time between updates.
                // The TimeBetweenUpdates property reflects the actual rate.
                //timeBetweenUpdatesTextBlock.Text = compass.TimeBetweenUpdates.TotalMilliseconds + " ms";


                compass.CurrentValueChanged +=
                    new EventHandler<SensorReadingEventArgs<CompassReading>>(compass_CurrentValueChanged);
                compass.Calibrate +=
                    new EventHandler<CalibrationEventArgs>(compass_Calibrate);


            }
            try
            {
                compass.Start();
                timer.Start();
            }
            catch (InvalidOperationException)
            {
            }
        }
        private void compass_CurrentValueChanged(object sender, SensorReadingEventArgs<CompassReading> e)
        {
            // Note that this event handler is called from a background thread
            // and therefore does not have access to the UI thread. To update 
            // the UI from this handler, use Dispatcher.BeginInvoke() as shown.
            // Dispatcher.BeginInvoke(() => { statusTextBlock.Text = "in CurrentValueChanged"; });

            isDataValid = compass.IsDataValid;

            trueHeading = e.SensorReading.TrueHeading;
            magneticHeading = e.SensorReading.MagneticHeading;
            headingAccuracy = Math.Abs(e.SensorReading.HeadingAccuracy);
            rawMagnetometerReading = e.SensorReading.MagnetometerReading;

        }

        public double GetHeading()
        {
            return trueHeading;
        }

        void timer_Tick(object sender, EventArgs e)
        {
            if (!calibrating)
            {
                if (isDataValid)
                {
                    //statusTextBlock.Text = "receiving data from compass.";
                }

                // Update the textblocks with numeric heading values
                //magneticTextBlock.Text = magneticHeading.ToString("0.0");
                //trueTextBlock.Text = trueHeading.ToString("0.0");
                //accuracyTextBlock.Text = headingAccuracy.ToString("0.0");

                //// Update the line objects to graphically display the headings
                //double centerX = headingGrid.ActualWidth / 2.0;
                //double centerY = headingGrid.ActualHeight / 2.0;
                //magneticLine.X2 = centerX - centerY * Math.Sin(MathHelper.ToRadians((float)magneticHeading));
                //magneticLine.Y2 = centerY - centerY * Math.Cos(MathHelper.ToRadians((float)magneticHeading));
                //trueLine.X2 = centerX - centerY * Math.Sin(MathHelper.ToRadians((float)trueHeading));
                //trueLine.Y2 = centerY - centerY * Math.Cos(MathHelper.ToRadians((float)trueHeading));

                //// Update the textblocks with numeric raw magnetometer readings
                //xTextBlock.Text = rawMagnetometerReading.X.ToString("0.00");
                //yTextBlock.Text = rawMagnetometerReading.Y.ToString("0.00");
                //zTextBlock.Text = rawMagnetometerReading.Z.ToString("0.00");

                //// Update the line objects to graphically display raw data
                //xLine.X2 = xLine.X1 + rawMagnetometerReading.X * 4;
                //yLine.X2 = yLine.X1 + rawMagnetometerReading.Y * 4;
                //zLine.X2 = zLine.X1 + rawMagnetometerReading.Z * 4;
            }
        }

        void compass_Calibrate(object sender, CalibrationEventArgs e)
        {

            mainPage.StartCalibration();
            calibrating = true;
        }


        // calculate heading from point a to point b
        public static double get_heading1(double lat1, double long1, double lat2, double long2)
        {
            double diff_lat, diff_long;
            double degree;

            diff_long = (double)(((long2 * 1000000) - (long1 * 1000000)) / 1000000) * ((22 / 7.0) / 180.0);
            diff_lat = (double)(((lat2 * 1000000) - (lat1 * 1000000)) / 1000000) * ((22 / 7.0) / 180.0);

            degree = (180.0 / (22 / 7.0)) * (Math.Atan2(Math.Sin(diff_long) * Math.Cos(((22 / 7.0) / 180.0) * lat2), Math.Cos(((22 / 7.0) / 180.0) * lat1) * Math.Sin(((22 / 7.0) / 180.0) * lat2) - Math.Sin(((22 / 7.0) / 180.0) * lat1) * Math.Cos(((22 / 7.0) / 180.0) * lat2) * Math.Cos(diff_long)));

            if (degree >= 0)
            {
                return degree;
            }
            else
            {
                return 360 + degree;
            }
        }
        // calculate bearing from point 1 to point 2
        internal static double DegreeBearing(
        double lat1, double lon1,
        double lat2, double lon2)
        {
            //const double R = 6371; //earth’s radius (mean radius = 6,371km)
            var dLon = ToRad(lon2 - lon1);
            var dPhi = Math.Log(
                Math.Tan(ToRad(lat2) / 2 + Math.PI / 4) / Math.Tan(ToRad(lat1) / 2 + Math.PI / 4));
            if (Math.Abs(dLon) > Math.PI)
                dLon = dLon > 0 ? -(2 * Math.PI - dLon) : (2 * Math.PI + dLon);
            return ToBearing(Math.Atan2(dLon, dPhi));
        }

        public static double ToRad(double degrees)
        {
            return degrees * (Math.PI / 180);
        }

        public static double ToDegrees(double radians)
        {
            return radians * 180 / Math.PI;
        }

        public static double ToBearing(double radians)
        {
            // convert radians to degrees (as bearing: 0...360)
            return (ToDegrees(radians) + 360) % 360;
        }
    }
}
