using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Sec
{
    class Conexion
    {
        public static MySqlConnection obtenerconexion()
        {
            MySqlConnection conectar = new MySqlConnection("server=localhost;database=opticav2mod;Uid=root;pwd=;");
            try
            {
                conectar.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar" + ex.ToString());
            }
            return conectar;
        }
    }
}
