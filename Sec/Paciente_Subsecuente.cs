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
    public partial class paciente_recurrente : Form
    {
        MySqlCommand cmd;
        MySqlDataAdapter ad;
        public string nombre, envio, idp, sano, pte, simple, comp, conj, glau, hiper, pres, sos, cata, reti, mixto, hipers, hiperc;
        public string diabet, hipert, alergi, cirugi, trauma, gotas, lentes, glucoma, od, oi;


        public string diabetano, hipertano, alergicual, cirugicual, traumacuando, gotascuales, lentesgx;
        public string diabettrata, hfdiabe, hfdiabequien, hipertrata, hfhiper, hfhiperquien, hfglau, hfglauquien, observa;

        public paciente_recurrente()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\Img\moon.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        //private void button2_Click(object sender, EventArgs e)
        //{
        //    Application.Exit();
        //}

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void lblreloj_Click(object sender, EventArgs e)
        {

        }

        private void horatimer_Tick(object sender, EventArgs e)
        {
            lblreloj.Text = DateTime.Now.ToLongTimeString();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) //Metodo que muestra los datos del paciente seleccionado en el combobox
        {
            string valor = comboBox1.Text;

            DataTable dtdatos = new DataTable();
            ad = new MySqlDataAdapter("Select idpaciente as 'ID',(edad) as 'Edad',Sexo,Lee,Tel as 'Telefono',ocupa as 'Ocupacion' from paciente where nombre ='" + valor + "';", Conexion.obtenerconexion());
            ad.Fill(dtdatos);
            dataGridView1.DataSource = dtdatos;

            cmd = new MySqlCommand("Select app_diabetes as 'diabete',dia_anios,dia_tratamiento,app_hiper,hiper_anios,hiper_tratamiento,alergia,alergia_cual,cirugia,cirugia_cual,trauma,cuando,gotas,gotas_cual,lente,gx_act,od,oi,app_glau,hf_diabetes,hf_dia_quien,hf_hiper,hf_hiper_quien,hf_glau,hf_glau_quien,observa from paciente where nombre ='" + valor + "';", Conexion.obtenerconexion());
            MySqlDataReader registro2 = cmd.ExecuteReader();
            while (registro2.Read())
            {
                diabet = Convert.ToString(registro2["diabete"]);
                diabetano = Convert.ToString(registro2["dia_anios"]);
                diabettrata = Convert.ToString(registro2["dia_tratamiento"]);
                hipert = Convert.ToString(registro2["app_hiper"]);
                hipertano = Convert.ToString(registro2["hiper_anios"]);
                hipertrata = Convert.ToString(registro2["hiper_tratamiento"]);
                alergi = Convert.ToString(registro2["alergia"]);
                alergicual = Convert.ToString(registro2["alergia_cual"]);
                cirugi = Convert.ToString(registro2["cirugia"]);
                cirugicual = Convert.ToString(registro2["cirugia_cual"]);
                trauma = Convert.ToString(registro2["trauma"]);
                traumacuando = Convert.ToString(registro2["cuando"]);
                gotas = Convert.ToString(registro2["gotas"]);
                gotascuales = Convert.ToString(registro2["gotas_cual"]);
                lentes = Convert.ToString(registro2["lente"]);
                lentesgx = Convert.ToString(registro2["gx_act"]);
                od = Convert.ToString(registro2["od"]);
                oi = Convert.ToString(registro2["oi"]);
                glucoma = Convert.ToString(registro2["app_glau"]);
                hfdiabe = Convert.ToString(registro2["hf_diabetes"]);
                hfdiabequien = Convert.ToString(registro2["hf_dia_quien"]);
                hfhiper = Convert.ToString(registro2["hf_hiper"]);
                hfhiperquien = Convert.ToString(registro2["hf_hiper_quien"]);
                hfglau = Convert.ToString(registro2["hf_glau"]);
                hfglauquien = Convert.ToString(registro2["hf_glau_quien"]);
                observa = Convert.ToString(registro2["observa"]);

            }
            if (diabet == "si")
            {
                Si1.Checked = true;
                No1.Checked = false;
            }
            else
            {
                No1.Checked = true;
                Si1.Checked = false;
            }
            if (hipert == "si")
            {
                Si2.Checked = true;
                No2.Checked = false;
            }
            else
            {
                No2.Checked = true;
                Si2.Checked = false;
            }
            if (alergi == "si")
            {
                Si3.Checked = true;
                No3.Checked = false;
            }
            else
            {
                No3.Checked = true;
                Si3.Checked = false;
            }
            if (cirugi == "si")
            {
                Si4.Checked = true;
                No4.Checked = false;
            }
            else
            {
                No4.Checked = true;
                Si4.Checked = false;
            }
            if (trauma == "si")
            {
                Si5.Checked = true;
                No5.Checked = false;
            }
            else
            {
                No5.Checked = true;
                Si5.Checked = false;
            }
            if (gotas == "si")
            {
                Si6.Checked = true;
                No6.Checked = false;
            }
            else
            {
                No6.Checked = true;
                Si6.Checked = false;
            }
            if (lentes == "si")
            {
                Si7.Checked = true;
                No7.Checked = false;
            }
            else
            {
                No7.Checked = true;
                Si7.Checked = false;
            }
            if (glucoma == "si")
            {
                Si8.Checked = true;
                No8.Checked = false;
            }
            else
            {
                No8.Checked = true;
                Si8.Checked = false;
            }
            if (hfdiabe == "si")
            {
                Sidia.Checked = true;
                Nodia.Checked = false;
            }
            else
            {
                Nodia.Checked = true;
                Sidia.Checked = false;
            }
            if (hfhiper == "si")
            {
                Sihip.Checked = true;
                Nohip.Checked = false;
            }
            else
            {
                Nohip.Checked = true;
                Sihip.Checked = false;
            }
            if (hfglau == "si")
            {
                Siglau.Checked = true;
                Noglau.Checked = false;
            }
            else
            {
                Noglau.Checked = true;
                Siglau.Checked = false;
            }

            textBox1.Text = diabetano;
            textBox2.Text = diabettrata;
            textBox3.Text = hipertano;
            textBox4.Text = hipertrata;
            textBox5.Text = alergicual;
            textBox6.Text = cirugicual;
            textBox7.Text = traumacuando;
            textBox8.Text = gotascuales;
            textBox9.Text = lentesgx;
            textBox10.Text = od;
            textBox12.Text = oi;
            txtquien1.Text = hfdiabequien;
            txtquien2.Text = hfhiperquien;
            txtquien3.Text = hfglauquien;
            richTextBox1.Text = observa;


            ////label9.Text = idp;
            nombre = valor;

        }
        private void btnguardar_Click(object sender, EventArgs e) //Guardar antecedentes
        {
            cmd = new MySqlCommand("Select idpaciente as 'Id' from paciente where nombre ='" + nombre + "';", Conexion.obtenerconexion());
            MySqlDataReader registro = cmd.ExecuteReader();
            while (registro.Read())
            {
                idp = Convert.ToString(registro["Id"]);
            }

            try
            {
                if (checksano.Checked == true)
                {
                    sano = "Sano";
                }
                if (checkpte.Checked == true)
                {
                    pte = "Pterigion";
                }
                if (checksimple.Checked == true)
                {
                    simple = "Ast. Miopico simple";
                }
                if (checkcomp.Checked == true)
                {
                    comp = "Ast. Miopico compuesto";
                }

                if (checkconjun.Checked == true)
                {
                    conj = "Conjuntivitis";
                }
                if (checkglau.Checked == true)
                {
                    glau = "Glaucoma";
                }
                if (checkhiper.Checked == true)
                {
                    hiper = "Hipertensión ocular";
                }
                if (checkpresb.Checked == true)
                {
                    pres = "Presbicia";
                }
                if (checksos.Checked == true)
                {
                    sos = "SOS";
                }
                if (checkcata.Checked == true)
                {
                    cata = "Catarata";
                }
                if (checkreti.Checked == true)
                {
                    reti = "Retinopatía D";
                }
                if (checkBox34.Checked == true)
                {
                    mixto = "Ast. Mixto";
                }
                if (checkBox35.Checked == true)
                {
                    hipers = "Ast. Hipermetropio simple";
                }
                if (checkBox36.Checked == true)
                {
                    hiperc = "Ast. Hipermetropico compuesto";
                }




                cmd = new MySqlCommand("insert into expediente(fk_idpaciente,motivo,od_lej,od_ad,od_cer,oi_lej,oi_ad,oi_cer,lej1,cer1,lej2,cer2,rs_od_esf,rs_od_cil,rs_od_ej,rs_od_lej,rs_od_ad,rs_od_cer,rs_oi_esf,rs_oi_cil,rs_oi_ej,rs_oi_lej,rs_oi_ad,rs_oi_cer,sc_od_esf,sc_od_cil,sc_od_ej,sc_od_lej,sc_od_auto,sc_oi_esf,sc_oi_cil,sc_oi_ej,sc_oi_lej,sc_oi_auto,reti_l11,reti_l13,reti_l21,reti_l23,mo_od,mo_io,rp_od,rp_oi,pre_od_pp,pre_oi_pp,pre_od_dip,pre_oi_dip,pre_od_dnp,pre_oi_dnp,pre_od_dt,pre_oi_dt,ar_od_k,ar_oi_k,ar_od_dk,ar_oi_dk,ar_od_ac,ar_oi_ac,ar_od_aj,ar_oi_aj,opl_od_esf,opl_od_cil,opl_od_ej,opl_od_ad,opl_od_dnp,opl_od_dip,opl_alt,opl_od_aco,opl_oi_esf,opl_oi_cil,opl_oi_ej,opl_oi_ad,opl_oi_dnp,opl_oi_aco,p,v,h,d,observa,bio_od_anex,bio_oi_anex,bio_od_conj,bio_oi_conj,bio_od_cor,bio_oi_cor,bio_od_cam,bio_oi_cam,bio_od_cri,bio_oi_cri,fond_od_ret,fond_oi_ret,fond_od_mac,fond_oi_mac,fond_od_ner,fond_oi_ner,plan,ciclo1,cliclo2,clico3,hora,diag,otro,ame) values ('" + idp + "','" + richTextBox5.Text + "','" + txtodlejos1.Text + "','" + txtadicion.Text + "','" + txtodcerca1.Text + "','" + txtoilejos2.Text + "','" + txtadicion2.Text + "','" + txtoicerca1.Text + "','" + txtodlejos2.Text + "','" + txtodcerca2.Text + "','" + txtlejos2.Text + "','" + txtoicerca2.Text + "','" + txtodesf1.Text + "','" + txtodcil1.Text + "','" + txtodeje1.Text + "','" + txtodavl1.Text + "','" + txtodadi.Text + "','" + txtodavc1.Text + "','" + txtoiesf1.Text + "','" + txtoicil1.Text + "','" + txtoieje1.Text + "','" + txtoiavl1.Text + "','" + txtoiadi.Text + "','" + txtoiavc1.Text + "','" + txtodesf2.Text + "','" + txtodcil2.Text + "','" + txtodeje2.Text + "','" + txtodavl2.Text + "','" + txtodauto.Text + "','" + txtoiesf2.Text + "','" + txtoicil2.Text + "','" + txtoieje2.Text + "','" + txtoiavl2.Text + "','" + txtoiauto.Text + "','" + txtodre1.Text + "','" + txtodre2.Text + "','" + txtoire1.Text + "','" + txtoire2.Text + "','" + txtodmoti.Text + "','" + txtoimoti.Text + "','" + txtodrefle.Text + "','" + txtoirefle.Text + "','" + txtodpp.Text + "','" + txtoipp.Text + "','" + txtoddip.Text + "','" + txtoidip.Text + "','" + txtoddnp.Text + "','" + txtoidnp.Text + "','" + txtoddt.Text + "','" + txtoidt.Text + "','" + txtodk.Text + "','" + txtoik.Text + "','" + txtoddifk.Text + "','" + txtoidifk.Text + "','" + txtodcorn.Text + "','" + txtoicorn.Text + "','" + txtodjav.Text + "','" + txtoijav.Text + "','" + txtodesfera.Text + "','" + txtodcilindro.Text + "','" + txtodeje.Text + "','" + txtodadd.Text + "','" + txtodanp.Text + "','" + txtdip.Text + "','" + txtaltura.Text + "','" + txtodaco.Text + "','" + txtoiesfera.Text + "','" + txtoicilindro.Text + "','" + txtoieje.Text + "','" + txtoiadd.Text + "','" + txtoianp.Text + "','" + txtoiaco.Text + "','" + txtp.Text + "','" + txtv.Text + "','" + txth.Text + "','" + txtd.Text + "','" + richTextBox3.Text + "','" + txtodane.Text + "','" + txtoiane.Text + "','" + txtodconj.Text + "','" + txtoiconj.Text + "','" + txtodcornea.Text + "','" + txtoicornea.Text + "','" + txtodcam.Text + "','" + txtoicam.Text + "','" + txtodcrista.Text + "','" + txtoicrista.Text + "','" + txtodretina.Text + "','" + txtoiretina.Text + "','" + txtodmacu.Text + "','" + txtoimacu.Text + "','" + txtodnervio.Text + "','" + txtoinervio.Text + "','" + richTextBox2.Text + "','" + txtciclo.Text + "','" + txtciclo2.Text + "','" + txtciclo3.Text + "','" + txthoratp.Text + "','" + sano + "," + pte + "," + conj + "," + glau + "," + hiper + "," + pres + "," + sos + "," + cata + "," + reti + "','" + txtotro.Text + "','" + simple + "," + comp + "," + mixto + "," + hipers + "," + hiperc + "');", Conexion.obtenerconexion());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se guardo correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de insercion" + ex.ToString());
            }


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

        private void actualizar_Click(object sender, EventArgs e)   //Metodo para actualizar datos del paciente
        {


            if (comboBox1.Text != "")
            {
                nuevo_pacien a = new nuevo_pacien();
                a.txtnombre.Text = nombre;

                a.Show();

                this.Hide();
            }
            else
                MessageBox.Show("No hay un paciente seleccionado");
        }

        private void paciente_recurrente_Load(object sender, EventArgs e)  //Cargar el combobox
        {


            cmd = new MySqlCommand("Select nombre from paciente", Conexion.obtenerconexion());
            MySqlDataReader registro = cmd.ExecuteReader();
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            while (registro.Read())
            {
                comboBox1.Items.Add(registro["nombre"].ToString());
                coleccion.Add(Convert.ToString(registro["nombre"]));
            }

            //Autocompletar el combobox
            comboBox1.AutoCompleteCustomSource = coleccion;
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void tableLayoutPanel9_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}