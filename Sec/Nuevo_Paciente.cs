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
    public partial class nuevo_pacien : Form
    {
        MySqlCommand cmd;
        public int bandera;
        string genero,lee,id;
        public nuevo_pacien()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\Img\moon.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form atras = new Inicio();
            atras.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form atras = new Inicio();
            atras.Show();

            this.Hide();
        }

        private void nuevo_pacien_Load(object sender, EventArgs e) //Metodo para mostrar datos cuando se actualiza
        {
            if (txtnombre.Text != "")
            {
                btnguardar.Visible = false;
                btnactu.Visible = true;
                //    btneli.Visible = true;
                DataTable dtdatos = new DataTable();
                cmd = new MySqlCommand("Select idpaciente as 'ID',Sexo,(edad) as 'Edad',lee,Tel,ocupa from paciente where nombre ='" + txtnombre.Text + "';", Conexion.obtenerconexion());
                MySqlDataReader registro = cmd.ExecuteReader();
                while (registro.Read())
                {
                    txtedad.Text = Convert.ToString(registro["Edad"]);
                    lee = Convert.ToString(registro["lee"]);
                     txtocu.Text = Convert.ToString(registro["ocupa"]);
                    txttel.Text = Convert.ToString(registro["Tel"]);
                    genero = Convert.ToString(registro["Sexo"]);
                    id = Convert.ToString(registro["ID"]);

                }
                if (genero == "H")
                {
                    checkBox1.Checked = true;
                }
                else
                    checkBox2.Checked = true;
                if (lee == "si")
                {
                    leersi.Checked = true;
                }
                else
                    leerno.Checked = true;

            }
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)  //Metodo para agregar nuevo paciente
        {
            if (txtnombre.Text == "" || txtedad.Text == "" || txtocu.Text == "" || txttel.Text == "")
            {
                MessageBox.Show("Faltan campos por rellenar");
            }
            else
            {
                string sexo,leer,diabe,hiper,aler,ciru,trauma,gota,lente,glauco,hfdiabe,hfhiper,hfglauco;

                if (checkBox1.Checked == true)
                {
                    sexo = "H";
                }
                else
                {
                    sexo = "M";
                }if (checkBox1.Checked == false && checkBox2.Checked == false)
                {
                    MessageBox.Show("Falto establecer el sexo");
                }
                else
                {
                    if (leersi.Checked == true)
                    {
                        leer = "Si";
                    }
                    else
                    {
                        leer = "No";
                    }
                    if (diabetesSi.Checked == true)
                    {
                        diabe = "Si";
                    }
                    else
                    {
                        diabe = "No";
                    }
                    if (hiperSi.Checked == true)
                    {
                        hiper = "Si";
                    }
                    else
                    {
                        hiper = "No";
                    }
                    if (alerSi.Checked == true)
                    {
                        aler = "Si";
                    }
                    else
                    {
                        aler = "No";
                    }
                    if (ciruSi.Checked == true)
                    {
                        ciru = "Si";
                    }
                    else
                    {
                        ciru = "No";
                    }
                    if (traumaSi.Checked == true)
                    {
                        trauma = "Si";
                    }
                    else
                    {
                        trauma = "No";
                    }
                    if (gotaSi.Checked == true)
                    {
                        gota = "Si";
                    }
                    else
                    {
                        gota = "No";
                    }
                    if (lenteSi.Checked == true)
                    {
                        lente = "Si";
                    }
                    else
                    {
                        lente = "No";
                    }
                    if (glaucoSi.Checked == true)
                    {
                        glauco = "Si";
                    }
                    else
                    {
                        glauco = "No";
                    }
                    if (hfdiabeSi.Checked == true)
                    {
                        hfdiabe = "Si";
                    }
                    else
                    {
                        hfdiabe = "No";
                    }
                    if (hfhiperSi.Checked == true)
                    {
                        hfhiper = "Si";
                    }
                    else
                    {
                        hfhiper = "No";
                    }
                    if (hfglaucoSi.Checked == true)
                    {
                        hfglauco = "Si";
                    }
                    else
                    {
                        hfglauco = "No";
                    }



                    try
                    {
                        cmd = new MySqlCommand(" insert into paciente(nombre,edad,sexo,lee,tel,ocupa,app_diabetes,dia_anios,dia_tratamiento,app_hiper,hiper_anios,hiper_tratamiento,alergia,alergia_cual,cirugia,cirugia_cual,trauma,cuando,gotas,gotas_cual,lente,gx_act,od,oi,app_glau,hf_diabetes,hf_dia_quien,hf_hiper,hf_hiper_quien,hf_glau,hf_glau_quien,observa) values ('" + txtnombre.Text + "','" + txtedad.Text + "','" + sexo + "','" + leer + "','" + txttel.Text + "','" + txtocu.Text + "','" + diabe + "','" + txtanos1.Text + "','" + txttrata1.Text + "','" + hiper + "','" + txtanos2.Text + "','" + txttrata2.Text + "','" + aler + "','" + txtalergias.Text + "','" + ciru + "','" + txtciru.Text + "','" + trauma + "','" + txttrauma.Text + "','" + gota + "','" + txtgotas.Text + "','" + lente + "','" + txtgx.Text + "','" + txtod.Text + "','" + txtoi.Text + "','" + glauco + "','" + hfdiabe + "','" + txtdiabe.Text + "','" + hfhiper + "','" + txthiper.Text + "','" + hfglauco + "','" + txtglauco.Text + "','" + richTextBox5.Text + "');", Conexion.obtenerconexion());
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Se guardo correctamente");
                        //        txtnombre.Text = "";
                        //        txtdireccion.Text = "";
                        //        txtedad.Text = "";
                        //        txtenti.Text = "";
                        //        txtloca.Text = "";
                        //        txtmuni.Text = "";
                        //        txttel.Text = "";
                        //        richtxtheredados.Text = "";
                        //        richtxtnopato.Text = "";
                        //        richtxtpato.Text = "";
                        //        txtgineco.Text = "";
                        //        checkBox1.Checked = false;
                        //        checkBox2.Checked = false;
                        //        checkadicto.Checked = false;
                        //        checkalcoholico.Checked = false;
                        //        checkalcoholico.Checked = false;
                        Form volver = new Inicio();
                        volver.Show();
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error de insercion" + ex.ToString());
                    }
                }
            }
        }

        private void btnactu_Click(object sender, EventArgs e)
        {
            if (txtnombre.Text == "" || txtedad.Text == "" || txtocu.Text == ""|| txttel.Text == "")
            {
                MessageBox.Show("Faltan campos por rellenar");
            }
            else
            {
                try
                {
                    cmd = new MySqlCommand(" update paciente set edad = '" + txtedad.Text + "', ocupa ='" + txtocu.Text + "', tel='" + txttel.Text + "',nombre='" + txtnombre.Text +"' where idpaciente ='" + id + "';", Conexion.obtenerconexion());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Se modifico correctamente"+id);
                    Form volver = new Inicio();
                    volver.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de modificacion" + ex.ToString());
                }

            }
        }

        private void txtdiabe_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
