﻿namespace Facturacion1
{
    partial class FrmClientes
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
            this.DgvClientes = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnReporte = new System.Windows.Forms.Button();
            this.Criterio = new System.Windows.Forms.Label();
            this.CbxCriterio = new System.Windows.Forms.ComboBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtBuscador = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.DgvClientes);
            this.panel2.Location = new System.Drawing.Point(20, 132);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(761, 292);
            this.panel2.TabIndex = 3;
            // 
            // DgvClientes
            // 
            this.DgvClientes.AllowUserToAddRows = false;
            this.DgvClientes.AllowUserToDeleteRows = false;
            this.DgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvClientes.Location = new System.Drawing.Point(3, 3);
            this.DgvClientes.Name = "DgvClientes";
            this.DgvClientes.ReadOnly = true;
            this.DgvClientes.RowHeadersWidth = 51;
            this.DgvClientes.RowTemplate.Height = 24;
            this.DgvClientes.Size = new System.Drawing.Size(753, 284);
            this.DgvClientes.TabIndex = 0;
            this.DgvClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvClientes_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtnReporte);
            this.panel1.Controls.Add(this.Criterio);
            this.panel1.Controls.Add(this.CbxCriterio);
            this.panel1.Controls.Add(this.BtnAgregar);
            this.panel1.Controls.Add(this.BtnBuscar);
            this.panel1.Controls.Add(this.TxtBuscador);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(20, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 100);
            this.panel1.TabIndex = 2;
            // 
            // BtnReporte
            // 
            this.BtnReporte.BackColor = System.Drawing.Color.Transparent;
            this.BtnReporte.BackgroundImage = global::Facturacion1.Properties.Resources.Excel_ico;
            this.BtnReporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReporte.ForeColor = System.Drawing.Color.Transparent;
            this.BtnReporte.Location = new System.Drawing.Point(653, 13);
            this.BtnReporte.Name = "BtnReporte";
            this.BtnReporte.Size = new System.Drawing.Size(87, 78);
            this.BtnReporte.TabIndex = 13;
            this.BtnReporte.UseVisualStyleBackColor = false;
            this.BtnReporte.Click += new System.EventHandler(this.BtnReporte_Click);
            // 
            // Criterio
            // 
            this.Criterio.AutoSize = true;
            this.Criterio.Location = new System.Drawing.Point(9, 13);
            this.Criterio.Name = "Criterio";
            this.Criterio.Size = new System.Drawing.Size(53, 17);
            this.Criterio.TabIndex = 12;
            this.Criterio.Text = "Criterio";
            // 
            // CbxCriterio
            // 
            this.CbxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxCriterio.FormattingEnabled = true;
            this.CbxCriterio.Items.AddRange(new object[] {
            "NombreComercial",
            "Cédula",
            "Estado"});
            this.CbxCriterio.Location = new System.Drawing.Point(12, 41);
            this.CbxCriterio.Name = "CbxCriterio";
            this.CbxCriterio.Size = new System.Drawing.Size(168, 24);
            this.CbxCriterio.TabIndex = 11;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.BtnAgregar.BackgroundImage = global::Facturacion1.Properties.Resources.Agregar;
            this.BtnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.ForeColor = System.Drawing.Color.Transparent;
            this.BtnAgregar.Location = new System.Drawing.Point(549, 13);
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
            this.BtnBuscar.Location = new System.Drawing.Point(450, 13);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(93, 78);
            this.BtnBuscar.TabIndex = 2;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtBuscador
            // 
            this.TxtBuscador.Location = new System.Drawing.Point(186, 44);
            this.TxtBuscador.Name = "TxtBuscador";
            this.TxtBuscador.Size = new System.Drawing.Size(258, 22);
            this.TxtBuscador.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar";
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmClientes";
            this.Text = "FrmClientes";
            this.Activated += new System.EventHandler(this.FrmClientes_Activated);
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DgvClientes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtBuscador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Criterio;
        private System.Windows.Forms.ComboBox CbxCriterio;
        private System.Windows.Forms.Button BtnReporte;
    }
}