using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectVisualFerre
{
    class ConexionBD
    {
        //Funcion para conectar la base de datos
        public static SqlConnection Conectar()
        {
            //Hacemos el llamado a la conexion de la base de datos
            SqlConnection con = new SqlConnection("Data Source=LoginMovilCB.mssql.somee.com;Initial Catalog=LoginMovilCB;Persist Security Info=True;User ID=joseruiz_SQLLogin_1;Password=v31usdbjx1");
            con.Open();
            return con;
        }
    }
}
