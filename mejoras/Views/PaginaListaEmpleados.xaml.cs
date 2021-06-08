using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace mejoras.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaListaEmpleados : ContentPage
    {
        public PaginaListaEmpleados()
        {
            InitializeComponent();
        }

        private void BtnNuevo_Clicked(object sender, EventArgs e)
        {
            
            Navigation.PushAsync(new vistagastos());
        }

        private void lsvEmpleados_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
                Navigation.PushAsync(new vistagastos());
        }
    }
}