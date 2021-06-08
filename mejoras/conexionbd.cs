using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

namespace mejoras
{
    class conexionbd
    {
        string Cadena = "data source = 192.168.100.8,1433; initial catalog = PRUEBACONEXION; user id = sa; password = txp25ab95";
        public SqlConnection Conectarbd = new SqlConnection();
        public conexionbd()
        {
            Conectarbd.ConnectionString = Cadena;
        }


        public void Abrir()
        {
            try
            {
                if (Conectarbd.State == System.Data.ConnectionState.Closed)
                {
                    Conectarbd.Open();
                    Console.WriteLine("Conexion Abierta");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir la Base de Datos " + ex.Message);
            }

        }

        public void Cerrar()
        {
            if (Conectarbd.State == System.Data.ConnectionState.Open)
            {
                Conectarbd.Close();
            }
        }

        

    }
}
