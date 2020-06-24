namespace devproject
{
    partial class ConsultarProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarProductos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataTable = new System.Windows.Forms.TableLayoutPanel();
            this.lblintrucciones = new System.Windows.Forms.Label();
            this.btnremover = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtno = new System.Windows.Forms.TextBox();
            this.lbltitle2 = new System.Windows.Forms.Label();
            this.lbltitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(997, 44);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(921, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(963, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dataTable);
            this.panel2.Controls.Add(this.lblintrucciones);
            this.panel2.Controls.Add(this.btnremover);
            this.panel2.Controls.Add(this.btnlimpiar);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtno);
            this.panel2.Controls.Add(this.lbltitle2);
            this.panel2.Controls.Add(this.lbltitle);
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(997, 492);
            this.panel2.TabIndex = 1;
            // 
            // dataTable
            // 
            this.dataTable.ColumnCount = 3;
            this.dataTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.73345F));
            this.dataTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.dataTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 312F));
            this.dataTable.Location = new System.Drawing.Point(96, 187);
            this.dataTable.Name = "dataTable";
            this.dataTable.RowCount = 3;
            this.dataTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.dataTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.dataTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.dataTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.dataTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.dataTable.Size = new System.Drawing.Size(821, 133);
            this.dataTable.TabIndex = 3;
            // 
            // lblintrucciones
            // 
            this.lblintrucciones.AutoSize = true;
            this.lblintrucciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblintrucciones.Location = new System.Drawing.Point(258, 146);
            this.lblintrucciones.Name = "lblintrucciones";
            this.lblintrucciones.Size = new System.Drawing.Size(506, 15);
            this.lblintrucciones.TabIndex = 6;
            this.lblintrucciones.Text = "Para remover el producto, Ingrese el numero del producto y seleccione la opción \"" +
    "Remover\"";
            // 
            // btnremover
            // 
            this.btnremover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(132)))), ((int)(((byte)(209)))));
            this.btnremover.FlatAppearance.BorderSize = 0;
            this.btnremover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnremover.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremover.ForeColor = System.Drawing.Color.White;
            this.btnremover.Location = new System.Drawing.Point(593, 97);
            this.btnremover.Name = "btnremover";
            this.btnremover.Size = new System.Drawing.Size(101, 30);
            this.btnremover.TabIndex = 5;
            this.btnremover.Text = "Remover";
            this.btnremover.UseVisualStyleBackColor = false;
            this.btnremover.Click += new System.EventHandler(this.btnremover_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(185)))), ((int)(((byte)(109)))));
            this.btnlimpiar.FlatAppearance.BorderSize = 0;
            this.btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.ForeColor = System.Drawing.Color.White;
            this.btnlimpiar.Location = new System.Drawing.Point(392, 97);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(101, 30);
            this.btnlimpiar.TabIndex = 4;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(366, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "*";
            // 
            // txtno
            // 
            this.txtno.Location = new System.Drawing.Point(411, 55);
            this.txtno.Name = "txtno";
            this.txtno.Size = new System.Drawing.Size(325, 20);
            this.txtno.TabIndex = 2;
            this.txtno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtno_KeyPress);
            // 
            // lbltitle2
            // 
            this.lbltitle2.AutoSize = true;
            this.lbltitle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle2.Location = new System.Drawing.Point(201, 57);
            this.lbltitle2.Name = "lbltitle2";
            this.lbltitle2.Size = new System.Drawing.Size(159, 13);
            this.lbltitle2.TabIndex = 1;
            this.lbltitle2.Text = "Ingresa el numero del producto: ";
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(380, 18);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(293, 16);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "Consulta el Productos Que Acabas de Registrar";
            // 
            // ConsultarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 535);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultarProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Productos";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel dataTable;
        private System.Windows.Forms.Label lblintrucciones;
        private System.Windows.Forms.Button btnremover;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtno;
        private System.Windows.Forms.Label lbltitle2;
        private System.Windows.Forms.Label lbltitle;
    }
}