namespace Facturacion1
{
    partial class FrmCondicionPago
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
            this.DgvCondicionPago = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtBuscador = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCondicionPago)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.DgvCondicionPago);
            this.panel2.Location = new System.Drawing.Point(25, 132);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(761, 292);
            this.panel2.TabIndex = 7;
            // 
            // DgvCondicionPago
            // 
            this.DgvCondicionPago.AllowUserToAddRows = false;
            this.DgvCondicionPago.AllowUserToDeleteRows = false;
            this.DgvCondicionPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCondicionPago.Location = new System.Drawing.Point(3, 2);
            this.DgvCondicionPago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvCondicionPago.Name = "DgvCondicionPago";
            this.DgvCondicionPago.ReadOnly = true;
            this.DgvCondicionPago.RowHeadersWidth = 51;
            this.DgvCondicionPago.RowTemplate.Height = 24;
            this.DgvCondicionPago.Size = new System.Drawing.Size(753, 284);
            this.DgvCondicionPago.TabIndex = 0;
            this.DgvCondicionPago.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCondicionPago_CellContentClick);
            this.DgvCondicionPago.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCondicionPago_CellContentDoubleClick);
            this.DgvCondicionPago.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCondicionPago_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtnAgregar);
            this.panel1.Controls.Add(this.BtnBuscar);
            this.panel1.Controls.Add(this.TxtBuscador);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(25, 26);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 100);
            this.panel1.TabIndex = 6;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.BtnAgregar.BackgroundImage = global::Facturacion1.Properties.Resources.Agregar;
            this.BtnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.ForeColor = System.Drawing.Color.Transparent;
            this.BtnAgregar.Location = new System.Drawing.Point(659, 14);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(87, 78);
            this.BtnAgregar.TabIndex = 3;
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click_1);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.BtnBuscar.BackgroundImage = global::Facturacion1.Properties.Resources.Buscar;
            this.BtnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.ForeColor = System.Drawing.Color.Transparent;
            this.BtnBuscar.Location = new System.Drawing.Point(559, 14);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(93, 78);
            this.BtnBuscar.TabIndex = 2;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click_1);
            // 
            // TxtBuscador
            // 
            this.TxtBuscador.Location = new System.Drawing.Point(152, 44);
            this.TxtBuscador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtBuscador.Name = "TxtBuscador";
            this.TxtBuscador.Size = new System.Drawing.Size(361, 22);
            this.TxtBuscador.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar";
            // 
            // FrmCondicionPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmCondicionPago";
            this.Text = "FrmCondicionPago";
            this.Activated += new System.EventHandler(this.FrmCondicionPago_Activated);
            this.Load += new System.EventHandler(this.FrmCondicionPago_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCondicionPago)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DgvCondicionPago;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtBuscador;
        private System.Windows.Forms.Label label1;
    }
}