using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Sec
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\Img\Op.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            lblfecha.Text = DateTime.Now.ToLongDateString();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form inic = new Inicio();
            inic.Close();

            Form new_pac = new Historial();
            new_pac.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form inic = new Inicio();
            inic.Close();

            Form new_pac = new nuevo_pacien();
            new_pac.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form inic = new Inicio();
            inic.Close();

            Form pac_recu = new paciente_recurrente();
            pac_recu.Show();

            this.Hide();
        }

        private void fehcatimer_Tick(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process proceso = new Process();
            proceso.StartInfo.FileName = @"C:\Users\NIKMO\Documents\UNACH\S8\Interacción Humano - Computadora\Óptica\SEC\Manual de Usuario SEC.pdf";
            proceso.Start();
        }
    }
}
