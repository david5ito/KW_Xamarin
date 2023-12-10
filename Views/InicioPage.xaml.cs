using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KW_Xamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InicioPage : ContentPage
    {
        public InicioPage()
        {
            InitializeComponent();
        }
        private async void btnSuscripciopn_Clicked(object sender, EventArgs e)
        {
            // Navegar a la nueva página
            await Navigation.PushAsync(new SuscripcionPage());
        }

    }
}