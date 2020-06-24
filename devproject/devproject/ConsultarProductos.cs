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
    public partial class ConsultarProductos : Form
    {
        public ConsultarProductos()
        {
            InitializeComponent();
            populateTable();
            if (Producto.Cart.Count == 0)
            {
                MessageBox.Show("Sin elementos para realize operaciones, regrese y agregue elementos al carrito");
                btnlimpiar.Enabled = false;
                btnremover.Enabled = false;
            }
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

        private void populateTable()
        {
            setHeaders();
            int id = 0;
            Producto.Cart.ForEach(delegate (Producto producto)
            {
                this.AddItem(id.ToString(), producto.Name, producto.Price.ToString());
                id++;

                Debug.WriteLine(producto.ToString());
            });
        }

        private void AddItem(string id, string name, string price)
        {
            //get a reference to the previous existent 
            RowStyle temp = this.dataTable.RowStyles[dataTable.RowCount - 1];
            //increase panel rows count by one
            dataTable.RowCount++;
            //add a new RowStyle as a copy of the previous one
            dataTable.RowStyles.Add(new RowStyle(temp.SizeType, temp.Height));
            //add your three controls
            dataTable.Controls.Add(new Label() { Text = id }, 0, dataTable.RowCount - 1);
            dataTable.Controls.Add(new Label() { Text = name }, 1, dataTable.RowCount - 1);
            dataTable.Controls.Add(new Label() { Text = "$" + price }, 2, dataTable.RowCount - 1);
        }

        private void setHeaders()
        {
            // tableLayoutPanel1 = new TableLayoutPanel();
            dataTable.ColumnCount = 3;
            dataTable.RowCount = 1;
            dataTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            dataTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            dataTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            dataTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            dataTable.Controls.Add(new Label() { Text = "ID" }, 1, 0);
            dataTable.Controls.Add(new Label() { Text = "Nombre" }, 2, 0);
            dataTable.Controls.Add(new Label() { Text = "Precio" }, 3, 0);
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            this.txtno.ResetText();
        }

        private void btnremover_Click(object sender, EventArgs e)
        {
            if (this.txtno.TextLength == 0)
            {
                MessageBox.Show("Ingresa el ID del producto");
            }
            else
            {
                int id = Int32.Parse(this.txtno.Text);
                try
                {
                    Producto.Cart.RemoveAt(id);
                    this.populateTable();
                }
                catch (System.ArgumentOutOfRangeException)
                {
                    MessageBox.Show("El ID " + id + " no es válido");
                }
            }
        }

        private void txtno_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.OnlyNums(sender, e);
        }
    }
}
