using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Weather
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();
        }

        private void ContentPage_Appearing(object sender, EventArgs e)
        {
            List<string> types = Enum.GetNames(typeof(CityType)).ToList();
            pickerType.ItemsSource = types;
        }

        private void buttonAdd_Clicked(object sender, EventArgs e)
        {
            if (data.Cities == null)
                data.Cities = new List<City>();
            Dictionary<string, double> temperatures = new Dictionary<string, double>();
            temperatures.Add("Январь", Convert.ToDouble(entry1Month.Text)); // таким образом все месяцы добавляешь в список
            temperatures.Add("Февраль", Convert.ToDouble(entry2Month.Text)); // таким образом все месяцы добавляешь в список
            temperatures.Add("Март", Convert.ToDouble(entry3Month.Text)); // таким образом все месяцы добавляешь в список
            temperatures.Add("Апрель", Convert.ToDouble(entry4Month.Text)); // таким образом все месяцы добавляешь в список
            temperatures.Add("Май", Convert.ToDouble(entry5Month.Text)); // таким образом все месяцы добавляешь в список
            temperatures.Add("Июнь", Convert.ToDouble(entry6Month.Text)); // таким образом все месяцы добавляешь в список
            temperatures.Add("Июль", Convert.ToDouble(entry7Month.Text)); // таким образом все месяцы добавляешь в список
            temperatures.Add("Август", Convert.ToDouble(entry8Month.Text)); // таким образом все месяцы добавляешь в список
            temperatures.Add("Сентябрь", Convert.ToDouble(entry9Month.Text)); // таким образом все месяцы добавляешь в список
            temperatures.Add("Октябрь", Convert.ToDouble(entry10Month.Text)); // таким образом все месяцы добавляешь в список
            temperatures.Add("Ноябрь", Convert.ToDouble(entry11Month.Text)); // таким образом все месяцы добавляешь в список
            temperatures.Add("Декабрь", Convert.ToDouble(entry12Month.Text)); // таким образом все месяцы добавляешь в список
            data.Cities.Add(new City(entryName.Text, (CityType)pickerType.SelectedIndex, temperatures));

            Navigation.PopModalAsync();
        }
    }
}