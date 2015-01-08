using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;
using System.IO.IsolatedStorage;

namespace AlKompass
{
    public struct Koordinaatti
    {
        public double latitude;
        public double longitude;
        public Koordinaatti(double lat, double longi)
        {
            this.latitude = lat;
            this.longitude = longi;
        }
    }


    static class LocationHelper
    {
        // this coordinate states that something went wrong while retrieving the GPS coordinates
        public static Koordinaatti VIRHEKOORDINAATTI = new Koordinaatti(-10000, -10000);
        // converts angles to radians
        private static double radify(double x)
        {
            return x * Math.PI / 180;
        }
        // counts the distance between two coordinates
        internal static double CountDistance(double currentLatitude, double currentLongitude, double targetLatitude, double targetLongitude)
        {
            var R = 6378137; // Earth’s mean radius in meter
            var dLat = radify(currentLatitude - targetLatitude);
            var dLong = radify(currentLongitude - targetLongitude);
            var a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
              Math.Cos(radify(currentLatitude)) * Math.Cos(radify(targetLatitude)) *
              Math.Sin(dLong / 2) * Math.Sin(dLong / 2);
            var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            var d = R * c;
            return d; // returns the distance in meter
        }

        // returns current location or VIRHEKOORDINATTI if it fails. 
        internal static async Task<Koordinaatti> CurrentLocation()
        {
            if ((bool)IsolatedStorageSettings.ApplicationSettings["LocationConsent"] != true)
            {
                // The user has opted out of Location.
                return VIRHEKOORDINAATTI;
            }
            Geolocator geolocator = new Geolocator();
            geolocator.DesiredAccuracyInMeters = 50;

            try
            {
                Geoposition geoposition = await geolocator.GetGeopositionAsync(
                    maximumAge: TimeSpan.FromMinutes(5),
                    timeout: TimeSpan.FromSeconds(10)
                    );

                var currLatitude = geoposition.Coordinate.Latitude;
                var currLongitude = geoposition.Coordinate.Longitude;
                var currentCoordinate = new Koordinaatti(currLatitude, currLongitude);
                return currentCoordinate;

            }
            catch (Exception ex)
            {
                if ((uint)ex.HResult == 0x80004004)
                {
                    // the application does not have the right capability or the location master switch is off


                }
                //else
                {
                    // something else happened acquring the location
                }
                return VIRHEKOORDINAATTI;
            }
        }
    }
}

