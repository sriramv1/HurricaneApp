using Plugin.Geolocator;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace HApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LocationPage : ContentPage
    {
        public LocationPage()
        {
            InitializeComponent();
            GetCurrentLocation();
            
        }
        private async void GetCurrentLocation()
        {
            var locator = CrossGeolocator.Current;
            locator.DesiredAccuracy = 50;
            var pos = await locator.GetPositionAsync(TimeSpan.FromMilliseconds(10000));
            
            var position1 = new Position(pos.Latitude, pos.Longitude);
            var pin1 = new Pin
            {
                Type = PinType.Place,
                Position = position1,
                Label = "current location",
                Address = "Custom"
            };
            

            var position2 = new Position(28.058308, -82.40996);
            //var pin2 = new Pin
            //{
            //    Type = PinType.Place,
            //    Position = position2,
            //    Label = "ISDS",
            //    Address = "USF-ISDS"
            //};
            
            var map = new Map(MapSpan.FromCenterAndRadius(
               new Position(pos.Latitude,pos.Longitude),
               Distance.FromMiles(0.3)))
            {
                IsShowingUser = true,
                HeightRequest = 100,
                WidthRequest = 960,
                MapType = MapType.Street,
                VerticalOptions = LayoutOptions.FillAndExpand
            };
            var stack = new StackLayout { Spacing = 0 };
            stack.Children.Add(map);
            Content = stack; 

            map.Pins.Add(pin1);
            //map.Pins.Add(pin2);

            var slider = new Slider(1, 18, 1);
            slider.ValueChanged += (sender, e) =>
            {
                var zoomLevel = e.NewValue; //between 1 and 18
                var latlongdegrees = 360 / (Math.Pow(2, zoomLevel));
                map.MoveToRegion(new MapSpan(map.VisibleRegion.Center, latlongdegrees, latlongdegrees));
            };
            stack.Children.Add(slider);
        }

        private void SetMap(double latitude, double longitude)
        {
            //MyLocationMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(latitude,longitude),Distance.FromMiles(0.5)));
            
        }
    }
}