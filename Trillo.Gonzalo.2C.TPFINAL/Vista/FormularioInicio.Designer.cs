namespace Vista
{
    partial class FormularioInicio
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
            this.lblBienvenidos = new System.Windows.Forms.Label();
            this.btnClientes = new System.Windows.Forms.Button();
            this.bntPersonal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBienvenidos
            // 
            this.lblBienvenidos.AutoSize = true;
            this.lblBienvenidos.BackColor = System.Drawing.Color.Transparent;
            this.lblBienvenidos.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBienvenidos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBienvenidos.Location = new System.Drawing.Point(199, 41);
            this.lblBienvenidos.Name = "lblBienvenidos";
            this.lblBienvenidos.Size = new System.Drawing.Size(378, 45);
            this.lblBienvenidos.TabIndex = 0;
            this.lblBienvenidos.Text = "BIENVENIDO A AL LADIN";
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(557, 172);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(200, 64);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // bntPersonal
            // 
            this.bntPersonal.Location = new System.Drawing.Point(557, 295);
            this.bntPersonal.Name = "bntPersonal";
            this.bntPersonal.Size = new System.Drawing.Size(200, 68);
            this.bntPersonal.TabIndex = 2;
            this.bntPersonal.Text = "Personal";
            this.bntPersonal.UseVisualStyleBackColor = true;
            this.bntPersonal.Click += new System.EventHandler(this.bntPersonal_Click);
            // 
            // FormularioInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bntPersonal);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.lblBienvenidos);
            this.Name = "FormularioInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AL LADIN";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenidos;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button bntPersonal;
    }
}