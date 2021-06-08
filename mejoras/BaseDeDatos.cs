using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Input;



namespace mejoras
{
    class BaseDatos
    {   
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
         
        public BaseDatos()
        {
            try
            {
                cn = new SqlConnection("data source = 192.168.100.8,1433; initial catalog = PRUEBACONEXION; user id = sa; password = txp25ab95");
                cn.Open();
                
            }
            catch(Exception )
            {
                
            }
        }

        public string Insertar(int id, string tipousuario)
        {
            string salida = "se inserto";
            try
            {

                cmd = new SqlCommand("insert into TIPODEGASTO(idusu,tipo) values ("+id+",'"+tipousuario+"')",cn);
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                salida = "No se coneto: " + ex.ToString();
            }
            return salida; 
        }
        public int Gastoregistrado(int id)
        {
            int contador = 0;
            try
            {

                cmd = new SqlCommand("select * from TIPODEGASTO WHERE idusu=" + id + "", cn);
                dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    contador++;
                }
                dr.Close();

            }
            catch (Exception )
            {
              
            }
            return contador;
        }

    }
}