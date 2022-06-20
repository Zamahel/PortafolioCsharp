using EmuladorPrueba.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace EmuladorPrueba.Views
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