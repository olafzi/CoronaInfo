using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }

        public List<County> Counties
        {
            get => CountyData();
        }

        private List<County> CountyData()
        {
            var tempList = new List<County>();
            tempList.Add(new County { CountyName = "Los Angeles", CountyCases = 1214, CountyDeaths = 44});
            tempList.Add(new County { CountyName = "Santa Clara", CountyCases = 848, CountyDeaths = 28 });
            tempList.Add(new County { CountyName = "Orange", CountyCases = 464, CountyDeaths = 4 });
            tempList.Add(new County { CountyName = "San Francisco", CountyCases = 374, CountyDeaths = 6 });
            tempList.Add(new County { CountyName = "San mateo", CountyCases = 309, CountyDeaths = 6 });
            tempList.Add(new County { CountyName = "Riverside", CountyCases = 291, CountyDeaths = 9 });
            tempList.Add(new County { CountyName = "Alameda", CountyCases = 283, CountyDeaths = 7 });
            tempList.Add(new County { CountyName = "Sacramento", CountyCases = 224, CountyDeaths = 7 });
            tempList.Add(new County { CountyName = "Contra Costa", CountyCases = 187, CountyDeaths = 3 });
            tempList.Add(new County { CountyName = "San Joaquin", CountyCases = 136, CountyDeaths = 6 });
            tempList.Add(new County { CountyName = "Ventura", CountyCases = 126, CountyDeaths = 4 });
            tempList.Add(new County { CountyName = "San Bernardino", CountyCases = 111, CountyDeaths = 3 });



            return tempList;
        }
    }

    public class County
    {
        public string CountyName { get; set; }
        public int CountyCases { get; set; }
        public int CountyDeaths { get; set; }
    }

}
