using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

namespace mejoras.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        string Cadena = "data source = 192.168.100.8,1433; initial catalog = PRUEBACONEXION; user id = sa; password = txp25ab95";
        public SqlConnection Conectarbd;
        private void Boton_inicio(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page1());

            Console.WriteLine("INICIO DE SESION ");
            Conectarbd = new SqlConnection(Cadena);
          
          




        }

        private void Boton_registro(object sender, EventArgs e)
        {
            Navigation.PushAsync(new registro());
        }
    }
}