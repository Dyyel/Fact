namespace Facturacion1
{
    partial class FrmVendedores
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.DgvVendedores = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtBuscador = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVendedores)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.DgvVendedores);
            this.panel2.Location = new System.Drawing.Point(25, 132);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(761, 292);
            this.panel2.TabIndex = 5;
            // 
            // DgvVendedores
            // 
            this.DgvVendedores.AllowUserToAddRows = false;
            this.DgvVendedores.AllowUserToDeleteRows = false;
            this.DgvVendedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvVendedores.Location = new System.Drawing.Point(3, 3);
            this.DgvVendedores.Name = "DgvVendedores";
            this.DgvVendedores.ReadOnly = true;
            this.DgvVendedores.RowHeadersWidth = 51;
            this.DgvVendedores.RowTemplate.Height = 24;
            this.DgvVendedores.Size = new System.Drawing.Size(753, 284);
            this.DgvVendedores.TabIndex = 0;
            this.DgvVendedores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvVendedores_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtnAgregar);
            this.panel1.Controls.Add(this.BtnBuscar);
            this.panel1.Controls.Add(this.TxtBuscador);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(25, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 100);
            this.panel1.TabIndex = 4;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.BtnAgregar.BackgroundImage = global::Facturacion1.Properties.Resources.Agregar;
            this.BtnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.ForeColor = System.Drawing.Color.Transparent;
            this.BtnAgregar.Location = new System.Drawing.Point(658, 13);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(87, 78);
            this.BtnAgregar.TabIndex = 3;
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.BtnBuscar.BackgroundImage = global::Facturacion1.Properties.Resources.Buscar;
            this.BtnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.ForeColor = System.Drawing.Color.Transparent;
            this.BtnBuscar.Location = new System.Drawing.Point(559, 13);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(93, 78);
            this.BtnBuscar.TabIndex = 2;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtBuscador
            // 
            this.TxtBuscador.Location = new System.Drawing.Point(152, 44);
            this.TxtBuscador.Name = "TxtBuscador";
            this.TxtBuscador.Size = new System.Drawing.Size(361, 22);
            this.TxtBuscador.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar";
            // 
            // FrmVendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmVendedores";
            this.Text = "FrmVendedores";
            this.Activated += new System.EventHandler(this.FrmVendedores_Activated);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvVendedores)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DgvVendedores;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtBuscador;
        private System.Windows.Forms.Label label1;
    }
}