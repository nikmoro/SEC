using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sec
{
    public partial class Historial : Form
    {
        MySqlCommand cmd;
        MySqlDataAdapter ad;
        public Historial()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\Img\moon.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Historial_Load(object sender, EventArgs e)
        {
            cmd = new MySqlCommand("Select nombre from paciente", Conexion.obtenerconexion());
            MySqlDataReader registro = cmd.ExecuteReader();
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            while (registro.Read())
            {
                comboBox1.Items.Add(registro["nombre"].ToString());
                coleccion.Add(Convert.ToString(registro["nombre"]));
            }
            comboBox1.AutoCompleteCustomSource = coleccion;
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form atras = new Inicio();
            atras.Show();

            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valor = comboBox1.Text;
            DataTable dtdatos = new DataTable();
            ad = new MySqlDataAdapter("Select p.idpaciente as 'No. de Paciente', e.idexpediente as 'No. Expediente' from paciente p, expediente e where e.fk_idpaciente =p.idpaciente and p.nombre='" + valor + "';", Conexion.obtenerconexion());
            ad.Fill(dtdatos);
            dataGridView1.DataSource = dtdatos;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form atras = new Inicio();
            atras.Show();

            this.Hide();
        }
    }
}
