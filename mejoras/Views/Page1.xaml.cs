using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Data.Sql;
using System.Data.SqlClient;


namespace mejoras.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public ImageSource Image { get; private set; }

        public Page1()
        {
            InitializeComponent();
        }
        string page = "data source = 192.168.100.8,1433; initial catalog = PRUEBACONEXION; user id = sa; password = txp25ab95";
        public SqlConnection Conectarbd;
        private void Button_Clicked(object sender, EventArgs e)
        {
                     
            string query = ("SELECT [correo], [contrasenia] FROM USUARIOS WHERE [correo]= '" +  usr.Text + "'" +
                "AND [contrasenia]= '" + password.Text +"' ");           
            Conectarbd = new SqlConnection(page);
            Conectarbd.Open();
            SqlCommand comando = new SqlCommand(query, Conectarbd);
            SqlDataReader cons = comando.ExecuteReader();

            string iuser = " ";
            string imail = " ";

            while (cons.Read())
            {
                iuser = cons["correo"].ToString();
                imail = cons["contrasenia"].ToString();
            }


            if (iuser == usr.Text && imail == password.Text)
            {
                var DATO = usr.Text;
                DisplayAlert("BIENVENIDO", DATO, "LISTO");
                Navigation.PushAsync(new PaginaListaEmpleados());
               
            }
            else
            {
                DisplayAlert("ERROR", "DATOS ERRORNEOS", "REVISAR");
            }
           
        }
        
        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new registro());
        }

       
        
    }
}