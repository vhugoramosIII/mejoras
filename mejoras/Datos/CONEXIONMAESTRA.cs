using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace mejoras.Datos
{
    class CONEXIONMAESTRA
    {
        public static string conexion = ("Data source = 192.168.100.1; serever= DESKTOP-2UQ10TK; Initial Catalog = PRUEBACONEXION; Integrated Security=False; User Id= sa; Password= txp25ab95");
        public static SqlConnection conectar = new SqlConnection(conexion); 
        public static void Abrir()
        {
            if (conectar.State == System.Data.ConnectionState.Closed )
            {
                conectar.Open();
                Console.WriteLine("*******************CONECTO**************");
            }
        }

        public static void Cerrar()
        {
            if (conectar.State == System.Data.ConnectionState.Open)
            {
                conectar.Close();

                Console.WriteLine("*******************NO************CONECTO**************");
            }
        }
    }
}
