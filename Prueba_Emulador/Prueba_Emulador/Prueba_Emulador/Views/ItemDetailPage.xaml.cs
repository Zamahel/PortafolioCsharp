using Prueba_Emulador.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Prueba_Emulador.Views
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