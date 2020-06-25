using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace devproject
{
    public partial class RealizarCobro : Form
    {
        public RealizarCobro()
        {
            InitializeComponent();
            if (Producto.Cart.Count == 0)
            {
                MessageBox.Show("Sin elementos para realizar el cobro, regrese y agregue elementos al carrito");
                btncobrar.Enabled = false;
            }
            else
            {
                this.txttotal.Text = Producto.GetTotal().ToString();
            }

            loadData();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form incio = new Fashion();
            incio.Show();
        }

        private void btncobrar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("¿Seguro que quiere cobrar?", "Cobro", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {

                writeTicket();
                Producto.Cart = new List<Producto>();
                MessageBox.Show("Se ha guardado la compra", "Exito");

                pictureBox1_Click(sender, e);
            }
            else
            {
                pictureBox1_Click(sender, e);
            }
        }

        private void writeTicket()
        {
            StringBuilder sb = new StringBuilder();
            int id = 0;
            foreach (Producto producto in Producto.Cart)
            {
                sb.Append(id).Append("\t ").Append(producto.Ticket()).Append("\n");
                id++;
            }

            File.AppendAllLines("Ticket.txt", new String[] {
                        "#	Tienda Mint Company",
                        "\t\n\t====TICKET DE COMPRA====",
                        DateTime.Now.ToString("dd/MM/yyyy") + "\t\n\t",
                        "\tNo. \t Artículos \t Precio \t\n",
                        sb.ToString(),
                        "\t\nTotal a pagar: " + this.txttotal.Text +"\t\t\t"});
        }

        private void loadData()
        {
            String[] lines = File.ReadAllLines("Ticket.txt");
            foreach (String line in lines)
            {
                this.txtCompras.AppendText(line + "\n" + "\t");
            }
        }

        private void txtCompras_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
