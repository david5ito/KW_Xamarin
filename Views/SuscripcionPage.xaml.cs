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
    public partial class SuscripcionPage : ContentPage
    {
        public SuscripcionPage()
        {
            InitializeComponent();
        }

        private void btnSuscripcionPre_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InicioPage());
        }
    }
}