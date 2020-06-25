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
            this.txtCompras.ReadOnly = true;
            ContextMenu blankContext = new ContextMenu();
            this.txtCompras.ContextMenu = blankContext;
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
                sb.Append(id).Append("\t").Append(producto.Ticket()).Append("\r\n");
                id++;
            }

            File.AppendAllLines("Ticket.txt", new String[] {
                        "#	Tienda Mint Company\n",
                        "====TICKET DE COMPRA====\n",
                        DateTime.Now.ToString("dd/MM/yyyy") + "\n",
                        "No. \t Artículos \t Precio \n",
                        sb.ToString()+"\n",
                        "\t\nTotal a pagar: " + this.txttotal.Text +"\n"});
        }

        private void loadData()
        {
            this.txtCompras.Text = File.ReadAllText("Ticket.txt");
        }

        private void txtCompras_TextChanged(object sender, EventArgs e)
        {
            this.txtCompras.ScrollBars = ScrollBars.Both;
        }
    }
}
