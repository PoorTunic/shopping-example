using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace devproject
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form incio = new Fashion();
            incio.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (this.txtproducto.TextLength == 0 || this.txtnombre.TextLength == 0)
            {
                MessageBox.Show("Ingresa toda la información");
            }
            else
            {
                Producto newProducto = new Producto();
                newProducto.Name = this.txtnombre.Text;
                newProducto.Price = Double.Parse(this.txtproducto.Text);
                Producto.Cart.Add(newProducto);
                pictureBox1_Click(sender, e);
            }
        }

        private void txtproducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.OnlyNums(sender, e);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtnombre.ResetText();
            this.txtproducto.ResetText();
        }
    }
}
