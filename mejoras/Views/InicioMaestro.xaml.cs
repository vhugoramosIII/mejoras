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
    public partial class InicioMaestro : ContentPage
    {
        public InicioMaestro()
        {
            InitializeComponent();
        }

        private void INICIO_MAESTRO(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(usrs.Text)&&
                !String.IsNullOrEmpty(passwords.Text))
            {
                var DATO = usrs.Text;
                DisplayAlert("BIENVENIDO", DATO, "LISTO");
                Navigation.PushAsync(new vistarevision());
            }
            else
            {
                DisplayAlert("ERROR", "DATOS ERRORNEOS", "REVISAR");
            }
        }


    }
}