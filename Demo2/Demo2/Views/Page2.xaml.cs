using Microsoft.AppCenter.Analytics;
using Xamarin.Forms;

namespace Demo2.Views
{
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();

            Analytics.TrackEvent("PAGE2 Viewed");
        }
    }
}