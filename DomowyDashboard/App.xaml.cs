using DomowyDashboard.View.Glowna_strona;
using Xamarin.Forms;

namespace DomowyDashboard
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new StronaGlowna_View();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
