using KW_Xamarin.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace KW_Xamarin.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}