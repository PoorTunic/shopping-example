using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace devproject
{
    public partial class Fashion : Form
    {

        public Fashion()
        {
            InitializeComponent();
            using (StreamWriter w = File.AppendText("Ticket.txt")) ;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            Form registro = new Registro();
            this.Hide();
            registro.Show();
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            Form consultar = new ConsultarProductos();
            this.Hide();
            consultar.Show();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btncobrar_Click(object sender, EventArgs e)
        {
            Form cobrar = new RealizarCobro();
            this.Hide();
            cobrar.Show();
        }
    }
}
