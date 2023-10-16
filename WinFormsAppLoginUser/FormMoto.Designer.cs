namespace WinFormsAppLoginUser
{
    partial class FormMoto
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
            lblCilindrada = new Label();
            lblUsoUrbano = new Label();
            txtCilindrada = new TextBox();
            btnGuardar = new Button();
            cmbUsoUrbano = new ComboBox();
            SuspendLayout();
            // 
            // cmbColor
            // 
            cmbColor.Items.AddRange(new object[] { Colores.Rojo, Colores.Blanco, Colores.Azul, Colores.Gris, Colores.Negro, Colores.Rojo, Colores.Blanco, Colores.Azul, Colores.Gris, Colores.Negro });
            // 
            // lblCilindrada
            // 
            lblCilindrada.AutoSize = true;
            lblCilindrada.Location = new Point(73, 406);
            lblCilindrada.Name = "lblCilindrada";
            lblCilindrada.Size = new Size(67, 15);
            lblCilindrada.TabIndex = 11;
            lblCilindrada.Text = "Cilindrada :";
            // 
            // lblUsoUrbano
            // 
            lblUsoUrbano.AutoSize = true;
            lblUsoUrbano.Location = new Point(73, 463);
            lblUsoUrbano.Name = "lblUsoUrbano";
            lblUsoUrbano.Size = new Size(75, 15);
            lblUsoUrbano.TabIndex = 12;
            lblUsoUrbano.Text = "Uso Urbano :";
            // 
            // txtCilindrada
            // 
            txtCilindrada.Location = new Point(235, 398);
            txtCilindrada.Name = "txtCilindrada";
            txtCilindrada.Size = new Size(122, 23);
            txtCilindrada.TabIndex = 13;
            txtCilindrada.KeyPress += txtCilindrada_KeyPress;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(84, 505);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 15;
            btnGuardar.Text = "Acepar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cmbUsoUrbano
            // 
            cmbUsoUrbano.FormattingEnabled = true;
            cmbUsoUrbano.Location = new Point(238, 457);
            cmbUsoUrbano.Name = "cmbUsoUrbano";
            cmbUsoUrbano.Size = new Size(119, 23);
            cmbUsoUrbano.TabIndex = 16;
            // 
            // FormMoto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 604);
            Controls.Add(cmbUsoUrbano);
            Controls.Add(btnGuardar);
            Controls.Add(txtCilindrada);
            Controls.Add(lblUsoUrbano);
            Controls.Add(lblCilindrada);
            Name = "FormMoto";
            Text = "FormMoto";
            Load += FormMoto_Load;
            Controls.SetChildIndex(txtMarca, 0);
            Controls.SetChildIndex(txtCantRuedas, 0);
            Controls.SetChildIndex(txtChasis, 0);
            Controls.SetChildIndex(cmbColor, 0);
            Controls.SetChildIndex(txtMarchas, 0);
            Controls.SetChildIndex(lblMarca, 0);
            Controls.SetChildIndex(lblCilindrada, 0);
            Controls.SetChildIndex(lblUsoUrbano, 0);
            Controls.SetChildIndex(txtCilindrada, 0);
            Controls.SetChildIndex(btnGuardar, 0);
            Controls.SetChildIndex(cmbUsoUrbano, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCilindrada;
        private Label lblUsoUrbano;
        private TextBox txtCilindrada;
        private Button btnGuardar;
        protected ComboBox cmbUsoUrbano;
    }
}