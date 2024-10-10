using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Supermarket_mvp._Repositories
{
    public class Conexion
    {
        public SqlConnection LeerCadena()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString);

            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            } 
            else
            {
                cn.Open();
            }
            return cn;
        }
    }
}
