using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using mejoras.Models;
using mejoras.ViewModels;
using System.ComponentModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace mejoras.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class vistagastos : ContentPage
    {
        public vistagastos()
        {
            InitializeComponent();
        }
        DateTime ultima;
        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            ultima = e.NewDate;
            var fechamostrar = e.NewDate.ToString("D");
            DisplayAlert("FECHA", fechamostrar, "ACEPTAR");
        }

        private void generarreporte(object sender, EventArgs e)
        {
            Navigation.PushAsync(new gastos());
        }

        
    }
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }

    
}
