using System;
using System.ComponentModel;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xamls.Models;

namespace Xamls.ViewModels
{
    public class WeatherPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string station;
        public string StationName
        {
            get { return station; }
            set {
                station = value;
                OnPropertyChanged();
            }
        }

        private int elevation;
        public int Elevation
        {
            get { return elevation; }
            set
            {
                elevation = value;
                OnPropertyChanged();
            }
        }

        private long temperature;
        public long Temperature
        {
            get { return temperature; }
            set
            {
                temperature = value;
                OnPropertyChanged();
            }
        }

        private long humidity;
        public long Humidity
        {
            get { return humidity; }
            set
            {
                humidity = value;
                OnPropertyChanged();
            }
        }

        public async Task GetWeatherAsync(string url)
        {

            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(url);

            var response = await httpClient.GetAsync(httpClient.BaseAddress);
            response.EnsureSuccessStatusCode();
            var jsonResult = response.Content.ReadAsStringAsync().Result;

            var weather = JsonConvert.DeserializeObject<WeatherResult>(jsonResult);
            SetValues(weather);

        }

        private void SetValues(WeatherResult weather)
        {
            var stationName = weather.weatherObservation.stationName;
            var elevation = weather.weatherObservation.elevation;
            var temperature = weather.weatherObservation.temperature;
            var humidity =  weather.weatherObservation.humidity;

            StationName = stationName;
            Elevation = elevation;
            Temperature = temperature;
            Humidity = humidity;



        }

        private void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            if (propertyName != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));

            throw new NotImplementedException();
        }
    }
}
