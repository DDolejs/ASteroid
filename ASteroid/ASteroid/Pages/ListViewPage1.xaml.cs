using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using ASteroid.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Net.Http;
using System.Net.Http.Json;
using System.Collections.Generic;

namespace ASteroid.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage1 : ContentPage
    {
        const String API_URL = "https://api.nasa.gov/neo/rest/v1/neo/browse?api_key=kTlB1068LXF3IZeIHqWRPhMeFSNgvZVKyPOCRoRd&fbclid=IwAR1AajND0QfAHggvOj60oLoRVcQ5BWZnL3amceYZyQmulvz2DiJrFZ4Ii8Q";

        public ListViewPage1()
        {
            InitializeComponent();            
            HttpClient client = new HttpClient();
            ConvertedObject x = client.GetFromJsonAsync<ConvertedObject>(API_URL).Result;
            List<string> namelist = new List<string>();
            foreach (Asteroidy item in x.near_earth_objects)
            {
                namelist.Add(item.name);
            }

            MyListView.ItemsSource = namelist;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
