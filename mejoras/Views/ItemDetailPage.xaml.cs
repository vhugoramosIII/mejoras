using mejoras.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace mejoras.Views
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