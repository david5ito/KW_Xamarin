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
    public partial class ComidaPage : TabbedPage
    {
        public ComidaPage()
        {
            InitializeComponent();
        }

        // Ejemplo de un evento en ComidaPage.xaml.cs
        private void OnEnviarClicked(object sender, EventArgs e)
        {
            // Lógica del evento
        }
    }
}