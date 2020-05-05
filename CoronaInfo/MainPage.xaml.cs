using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using CoronaInfo.ViewModel;
using Newtonsoft.Json;
using QuickType;
using Xamarin.Forms;

namespace CoronaInfo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = this;
            GetCountries();
            BindingContext = new CountryViewModel();

        }

        private async void GetCountries()
        {
            HttpClient client = new HttpClient();

            var response = await client.GetStringAsync("https://bing.com/covid/data");


            var countries = Countries.FromJson(response);


            StateListView.ItemsSource = countries.Areas;

        }



    }
}

//#if __IOS__            //Content
//#endif
//#if __ANDROID__           //Content
//#endif

