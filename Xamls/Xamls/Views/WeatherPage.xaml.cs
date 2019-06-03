using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamls.ViewModels;

namespace Xamls.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class WeatherPage : ContentPage
	{
        WeatherPageViewModel weatherPageViewModel;
		public WeatherPage ()
		{
            weatherPageViewModel = new WeatherPageViewModel();
            BindingContext = weatherPageViewModel;
			InitializeComponent ();
		}

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var Latitude = double.Parse(txtLat.Text);
            var Longitude = double.Parse(txtLong.Text);

            var url = string.Format("http://api.geonames.org/findNearByWeatherJSON?lat={0}&lng={1}&username=demo",Latitude,Longitude);

            await weatherPageViewModel.GetWeatherAsync(url);
        }
    }
}