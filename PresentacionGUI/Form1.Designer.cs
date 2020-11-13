namespace PresentacionGUI
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.CbxTipoContrato = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtIdentificacionContratista = new System.Windows.Forms.TextBox();
            this.TxtNombreContratista = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DtFechaSuscripcion = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtValorContrato = new System.Windows.Forms.TextBox();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.DtContratos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DtContratos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo Contratos";
            // 
            // CbxTipoContrato
            // 
            this.CbxTipoContrato.FormattingEnabled = true;
            this.CbxTipoContrato.Items.AddRange(new object[] {
            "Prestación de servicio",
            "Licitación Pública",
            "Subasta Inversa"});
            this.CbxTipoContrato.Location = new System.Drawing.Point(199, 52);
            this.CbxTipoContrato.Name = "CbxTipoContrato";
            this.CbxTipoContrato.Size = new System.Drawing.Size(163, 21);
            this.CbxTipoContrato.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Idntificacion del contratista :";
            // 
            // TxtIdentificacionContratista
            // 
            this.TxtIdentificacionContratista.Location = new System.Drawing.Point(199, 87);
            this.TxtIdentificacionContratista.Name = "TxtIdentificacionContratista";
            this.TxtIdentificacionContratista.Size = new System.Drawing.Size(163, 20);
            this.TxtIdentificacionContratista.TabIndex = 3;
            // 
            // TxtNombreContratista
            // 
            this.TxtNombreContratista.Location = new System.Drawing.Point(506, 55);
            this.TxtNombreContratista.Name = "TxtNombreContratista";
            this.TxtNombreContratista.Size = new System.Drawing.Size(163, 20);
            this.TxtNombreContratista.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre del contratista :";
            // 
            // DtFechaSuscripcion
            // 
            this.DtFechaSuscripcion.Location = new System.Drawing.Point(506, 87);
            this.DtFechaSuscripcion.Name = "DtFechaSuscripcion";
            this.DtFechaSuscripcion.Size = new System.Drawing.Size(163, 20);
            this.DtFechaSuscripcion.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(373, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fecha de suscripcion :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Valor del contrato :";
            // 
            // TxtValorContrato
            // 
            this.TxtValorContrato.Location = new System.Drawing.Point(199, 130);
            this.TxtValorContrato.Name = "TxtValorContrato";
            this.TxtValorContrato.Size = new System.Drawing.Size(163, 20);
            this.TxtValorContrato.TabIndex = 11;
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.BackColor = System.Drawing.Color.YellowGreen;
            this.BtnRegistrar.FlatAppearance.BorderSize = 0;
            this.BtnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnRegistrar.Location = new System.Drawing.Point(506, 130);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(133, 23);
            this.BtnRegistrar.TabIndex = 12;
            this.BtnRegistrar.Text = "REGISTRAR";
            this.BtnRegistrar.UseVisualStyleBackColor = false;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // DtContratos
            // 
            this.DtContratos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtContratos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DtContratos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DtContratos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtContratos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.DtContratos.GridColor = System.Drawing.SystemColors.Control;
            this.DtContratos.Location = new System.Drawing.Point(34, 192);
            this.DtContratos.Name = "DtContratos";
            this.DtContratos.Size = new System.Drawing.Size(716, 230);
            this.DtContratos.TabIndex = 13;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tipo de Contrato";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Identificacion Contratista";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nombre Contratista";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Fecha de Suscripcion";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Valor Contrato";
            this.Column5.Name = "Column5";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DtContratos);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.TxtValorContrato);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DtFechaSuscripcion);
            this.Controls.Add(this.TxtNombreContratista);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtIdentificacionContratista);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CbxTipoContrato);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DtContratos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbxTipoContrato;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtIdentificacionContratista;
        private System.Windows.Forms.TextBox TxtNombreContratista;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DtFechaSuscripcion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtValorContrato;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.DataGridView DtContratos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

