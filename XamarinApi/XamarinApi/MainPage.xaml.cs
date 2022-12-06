using XamarinApi.Views;
using Xamarin.Forms;

namespace XamarinApi
{
    public partial class MainPage : Shell
    {
        public MainPage()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(CountrysPage), typeof(CountrysPage));
        }

        
    }
}
