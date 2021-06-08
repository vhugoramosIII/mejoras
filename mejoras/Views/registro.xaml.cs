using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace mejoras.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class registro : ContentPage
    {
        public registro()
        {
            InitializeComponent();

        }

        string page = "data source = 192.168.100.8,1433; initial catalog = PRUEBACONEXION; user id = sa; password = txp25ab95";
        public SqlConnection Conectarbd;

        private void Button_Clicked(object sender, EventArgs e)
        {
            string query = "INSERT INTO USUARIOS ([correo], [nombre], [apellidop], [apellidom], [telefono], [contrasenia], [tipusu]) VALUES ('"+correo.Text +"','"+nom.Text+"' , '"+app.Text+"', '"+apm.Text+"','"+tele.Text+"', '"+contr.Text+"', '"+tipo.Text+"')";
            Conectarbd = new SqlConnection(page);
            Conectarbd.Open();
            SqlCommand comando = new SqlCommand(query, Conectarbd);
            comando.ExecuteNonQuery();

            correo.Text = " ";
            nom.Text = " ";
            app.Text = " ";
            apm.Text = " ";
            tele.Text = " ";
            contr.Text = " ";
            tipo.Text = " ";
             
            
          }

       
    }
}