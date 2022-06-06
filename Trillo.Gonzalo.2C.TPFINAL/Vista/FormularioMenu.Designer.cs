namespace Vista
{
    partial class FormularioMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.cmbTipoTela = new System.Windows.Forms.ComboBox();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.lblTipoTela = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblAltaProducto = new System.Windows.Forms.Label();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.lblCodigoProducto = new System.Windows.Forms.Label();
            this.cmbTipoProducto = new System.Windows.Forms.ComboBox();
            this.lblTipoProducto = new System.Windows.Forms.Label();
            this.txtLargo = new System.Windows.Forms.TextBox();
            this.txtAncho = new System.Windows.Forms.TextBox();
            this.lblLargo = new System.Windows.Forms.Label();
            this.lblAncho = new System.Windows.Forms.Label();
            this.rtbMostrar = new System.Windows.Forms.RichTextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(808, 133);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(230, 67);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(808, 32);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(230, 73);
            this.btnQuitar.TabIndex = 1;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // cmbTipoTela
            // 
            this.cmbTipoTela.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoTela.FormattingEnabled = true;
            this.cmbTipoTela.Location = new System.Drawing.Point(197, 167);
            this.cmbTipoTela.Name = "cmbTipoTela";
            this.cmbTipoTela.Size = new System.Drawing.Size(182, 33);
            this.cmbTipoTela.TabIndex = 3;
            this.cmbTipoTela.SelectedIndexChanged += new System.EventHandler(this.cmbTipoTela_SelectedIndexChanged);
            // 
            // cmbColor
            // 
            this.cmbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(197, 206);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(182, 33);
            this.cmbColor.TabIndex = 4;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(197, 130);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(182, 31);
            this.txtNombreProducto.TabIndex = 6;
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Location = new System.Drawing.Point(12, 130);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(157, 25);
            this.lblNombreProducto.TabIndex = 7;
            this.lblNombreProducto.Text = "Nombre producto";
            // 
            // lblTipoTela
            // 
            this.lblTipoTela.AutoSize = true;
            this.lblTipoTela.Location = new System.Drawing.Point(12, 167);
            this.lblTipoTela.Name = "lblTipoTela";
            this.lblTipoTela.Size = new System.Drawing.Size(105, 25);
            this.lblTipoTela.TabIndex = 8;
            this.lblTipoTela.Text = "Tipo de tela";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(12, 206);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(55, 25);
            this.lblColor.TabIndex = 9;
            this.lblColor.Text = "Color";
            // 
            // lblAltaProducto
            // 
            this.lblAltaProducto.AutoSize = true;
            this.lblAltaProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblAltaProducto.Location = new System.Drawing.Point(358, 9);
            this.lblAltaProducto.Name = "lblAltaProducto";
            this.lblAltaProducto.Size = new System.Drawing.Size(176, 25);
            this.lblAltaProducto.TabIndex = 11;
            this.lblAltaProducto.Text = "ALTA DE PRODUCTO";
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Location = new System.Drawing.Point(197, 53);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(182, 31);
            this.txtCodigoProducto.TabIndex = 12;
            // 
            // lblCodigoProducto
            // 
            this.lblCodigoProducto.AutoSize = true;
            this.lblCodigoProducto.Location = new System.Drawing.Point(12, 53);
            this.lblCodigoProducto.Name = "lblCodigoProducto";
            this.lblCodigoProducto.Size = new System.Drawing.Size(179, 25);
            this.lblCodigoProducto.TabIndex = 13;
            this.lblCodigoProducto.Text = "Codigo del producto";
            // 
            // cmbTipoProducto
            // 
            this.cmbTipoProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoProducto.FormattingEnabled = true;
            this.cmbTipoProducto.Location = new System.Drawing.Point(197, 91);
            this.cmbTipoProducto.Name = "cmbTipoProducto";
            this.cmbTipoProducto.Size = new System.Drawing.Size(182, 33);
            this.cmbTipoProducto.TabIndex = 14;
            // 
            // lblTipoProducto
            // 
            this.lblTipoProducto.AutoSize = true;
            this.lblTipoProducto.Location = new System.Drawing.Point(12, 91);
            this.lblTipoProducto.Name = "lblTipoProducto";
            this.lblTipoProducto.Size = new System.Drawing.Size(151, 25);
            this.lblTipoProducto.TabIndex = 15;
            this.lblTipoProducto.Text = "Tipo de producto";
            // 
            // txtLargo
            // 
            this.txtLargo.Location = new System.Drawing.Point(584, 53);
            this.txtLargo.Name = "txtLargo";
            this.txtLargo.Size = new System.Drawing.Size(150, 31);
            this.txtLargo.TabIndex = 16;
            // 
            // txtAncho
            // 
            this.txtAncho.Location = new System.Drawing.Point(584, 90);
            this.txtAncho.Name = "txtAncho";
            this.txtAncho.Size = new System.Drawing.Size(150, 31);
            this.txtAncho.TabIndex = 17;
            // 
            // lblLargo
            // 
            this.lblLargo.AutoSize = true;
            this.lblLargo.Location = new System.Drawing.Point(498, 50);
            this.lblLargo.Name = "lblLargo";
            this.lblLargo.Size = new System.Drawing.Size(57, 25);
            this.lblLargo.TabIndex = 18;
            this.lblLargo.Text = "Largo";
            // 
            // lblAncho
            // 
            this.lblAncho.AutoSize = true;
            this.lblAncho.Location = new System.Drawing.Point(498, 90);
            this.lblAncho.Name = "lblAncho";
            this.lblAncho.Size = new System.Drawing.Size(63, 25);
            this.lblAncho.TabIndex = 19;
            this.lblAncho.Text = "Ancho";
            // 
            // rtbMostrar
            // 
            this.rtbMostrar.Location = new System.Drawing.Point(12, 257);
            this.rtbMostrar.Name = "rtbMostrar";
            this.rtbMostrar.Size = new System.Drawing.Size(1026, 279);
            this.rtbMostrar.TabIndex = 20;
            this.rtbMostrar.Text = "";
            this.rtbMostrar.TextChanged += new System.EventHandler(this.rtbMostrar_TextChanged);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(498, 130);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(60, 25);
            this.lblPrecio.TabIndex = 21;
            this.lblPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(584, 127);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(150, 31);
            this.txtPrecio.TabIndex = 22;
            this.txtPrecio.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FormularioMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1050, 548);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.rtbMostrar);
            this.Controls.Add(this.lblAncho);
            this.Controls.Add(this.lblLargo);
            this.Controls.Add(this.txtAncho);
            this.Controls.Add(this.txtLargo);
            this.Controls.Add(this.lblTipoProducto);
            this.Controls.Add(this.cmbTipoProducto);
            this.Controls.Add(this.lblCodigoProducto);
            this.Controls.Add(this.txtCodigoProducto);
            this.Controls.Add(this.lblAltaProducto);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblTipoTela);
            this.Controls.Add(this.lblNombreProducto);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.cmbTipoTela);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAgregar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormularioMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Al Ladin";
            this.Load += new System.EventHandler(this.FormularioMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.ComboBox cmbTipoTela;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.Label lblTipoTela;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblAltaProducto;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.Label lblCodigoProducto;
        private System.Windows.Forms.ComboBox cmbTipoProducto;
        private System.Windows.Forms.Label lblTipoProducto;
        private System.Windows.Forms.TextBox txtLargo;
        private System.Windows.Forms.TextBox txtAncho;
        private System.Windows.Forms.Label lblLargo;
        private System.Windows.Forms.Label lblAncho;
        private System.Windows.Forms.RichTextBox rtbMostrar;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
    }
}
