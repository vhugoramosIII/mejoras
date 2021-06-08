using mejoras.ViewModels;
using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace mejoras.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class gastos : ContentPage
    {

        public gastos()
        {
            //lista tipos de gasto
            InitializeComponent();
            tipdegas.Items.Add("Agua embotellada");
            tipdegas.Items.Add("Coffee Break");
            tipdegas.Items.Add("Consumo de alimentos");
            tipdegas.Items.Add("Copias, Impresiones, Internet");
            tipdegas.Items.Add("Estacionamiento");
            tipdegas.Items.Add("Hospedaje");
            tipdegas.Items.Add("Maniobras");
            tipdegas.Items.Add("Mensajeria");
            tipdegas.Items.Add("Muestras");
            tipdegas.Items.Add("Peajes");
            tipdegas.Items.Add("Reparaciones en instalciones");
            tipdegas.Items.Add("Servicio a Unidades");
            tipdegas.Items.Add("Servicio de Transporte");
            tipdegas.Items.Add("Suministro agua potable");
            tipdegas.Items.Add("Talacheria");
            tipdegas.Items.Add("Tranmites diversos");
            tipdegas.Items.Add("Verificacion vehicular");
            tipdegas.Items.Add("Gastos varios");

            //lista factura

            fact.Items.Add("Si");
            fact.Items.Add("No");



        }

        string page = "data source = 192.168.100.8,1433; initial catalog = PRUEBACONEXION; user id = sa; password = txp25ab95";
        public SqlConnection Conectarbd;

        DateTime Ultima;
        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            Ultima = e.NewDate;
            var fechamostrar = e.NewDate.ToString("D");
            DisplayAlert("FECHA", fechamostrar, "ACEPTAR");
        }

        

        private void tipdegas_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        

        Double totl = 0.0;
        Double sbtotl = 0.16;
      

        private void fact_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(subtotal.Text);

            if (fact.Title == "Si")
            {

              //  totl = subtotal.Text * 0.16;

               // total.Text = totl.ToString();
            }
            else
            {
                
            }

        }
        
        private void Button_Clicked(object sender, EventArgs e)
        {
            int gastoid = 0;
            Random alea = new Random();
            gastoid = alea.Next(0,999);

            idgasto.Text = Convert.ToString(gastoid);
            //
            
            
            

            string query = "INSERT INTO GASTOS ([idgas], [correousuario], [fecha], [tipogasto], [factura], [descripcion], [subtotal], [total]) VALUES " +
                " ('" + idgasto + "','" + imeil + "' , '" + fec.Date + "','" + tipdegas.Title + "','" + descr.Text + "','" + fact.Title + "','" + subtotal.Text + "','" + total.Text + "' )";
            Conectarbd = new SqlConnection(page);
            Conectarbd.Open();
            SqlCommand comando = new SqlCommand(query, Conectarbd);
            comando.ExecuteNonQuery();

          

            //esto sirve para limpiar los campos despues de usarlos 

            
            imeil.Text = " ";
            tipdegas.Title = " ";
            descr.Text = " ";
            descr.Text = " ";
            subtotal.Text = " ";
            total.Text = " "; 


        }
    }
}

