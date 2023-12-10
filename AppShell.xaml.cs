using KW_Xamarin.ViewModels;
using KW_Xamarin.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace KW_Xamarin
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {// Navegar a la nueva página
            await Navigation.PushAsync(new LoginX());
        }
    }
}
