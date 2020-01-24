using DomowyDashboard.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DomowyDashboard.View.Glowna_strona
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StronaGlowna_View : TabbedPage
    {
        private PomieszczeniaViewModel viewModel;


        public StronaGlowna_View()
        {

            InitializeComponent();


            viewModel = new PomieszczeniaViewModel();
            BindingContext = viewModel;

        }

        private void btnTempMinus_Clicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int iLp = Convert.ToInt32(button.AutomationId);

            int temp = Convert.ToInt32(viewModel.PomieszczenieLista[iLp].Temperatura);

            viewModel.PomieszczenieLista[iLp].Temperatura = Convert.ToString(temp - 1);
        }

        private void btnTempPlus_Clicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int iLp = Convert.ToInt32(button.AutomationId);

            int temp = Convert.ToInt32(viewModel.PomieszczenieLista[iLp].Temperatura);

            viewModel.PomieszczenieLista[iLp].Temperatura = Convert.ToString(temp + 1);
        }

        
    }
}