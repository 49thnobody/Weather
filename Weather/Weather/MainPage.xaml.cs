using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Weather
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void buttonSettings_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new SettingsPage());
        }

        City currentCity;
        private void picerCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentCity = data.Cities[pickerCities.SelectedIndex];

            labelCityType.Text = currentCity.Type.ToString();
            GetAvegare();
        }

        private void GetAvegare()
        {
            switch (pickerSeason.SelectedIndex)
            {
                case 0:
                    // winter
                    double dec = currentCity.TemperaturePerMonths["Декабрь"];
                    double jan = currentCity.TemperaturePerMonths["Январь"];
                    double feb = currentCity.TemperaturePerMonths["Февраль"];

                    labelTemperature.Text = ((dec + jan + feb) / 3).ToString();
                    break;
                case 1:
                    // spring
                    break;
                case 2:
                    // summer
                    break;
                case 3:
                    // autumn
                    break;
                default:
                    break;
            }
        }

        private void pickerSeason_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetAvegare();
        }

        private void ContentPage_Appearing(object sender, EventArgs e)
        {
            if (data.Cities == null)
            {
                // тестовые данные
                data.Cities = new List<City>();
                data.Cities.Add(new City("Рязань", CityType.Little, new Dictionary<string, double>
                {   {"Январь", -21},
                    {"Февраль", -5 },
                    {"Март", 5 },
                    {"Апрель", 15},
                    {"Май", 20 },
                    {"Июнь", 25 },
                    {"Июль", 30 },
                    {"Август", 15 },
                    {"Сентябрь", 10 },
                    {"Октябрь", -5 },
                    {"Ноябрь", -10 },
                    {"Декабрь", -16 },
                }));
            }

            pickerCities.ItemsSource = data.Cities.ConvertAll(p => p.Name);
            currentCity = data.Cities[0];
            List<string> seasons = Enum.GetNames(typeof(Season)).ToList();
            pickerSeason.ItemsSource = seasons;
        }
    }
}
