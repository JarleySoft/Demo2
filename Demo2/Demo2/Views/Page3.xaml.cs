using Microsoft.AppCenter.Analytics;
using Xamarin.Forms;

namespace Demo2.Views
{
    public partial class Page3 : ContentPage
    {
        public Page3()
        {
            InitializeComponent();

            Analytics.TrackEvent("PAGE3 Viewed");
        }
    }
}