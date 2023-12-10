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
    public partial class RecetarioPage : ContentPage
    {
        public RecetarioPage()
        {
            InitializeComponent();
        }

        private async void btnReceta_Clicked(object sender, EventArgs e)
        {
            // Navegar a la nueva página
            await Navigation.PushAsync(new ComidaPage());
        }

    }
}