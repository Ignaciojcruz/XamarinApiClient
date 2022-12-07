using XamarinApi.Data;
using XamarinApi.Models;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System;

namespace XamarinApi.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CountrysPage : ContentPage        
    {

        RestServiceCountry _restService;

        public CountrysPage()
        {
            InitializeComponent();
            _restService = new RestServiceCountry();
        }

        async void OnButtonClicked(object sender, EventArgs e)
        {
            List<Country> list = await _restService.GetCountrysAsync();
            collectionView.ItemsSource = list;

        }
    }
}