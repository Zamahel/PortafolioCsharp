using PruebaEmulador.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace PruebaEmulador.Views
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