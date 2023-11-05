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
            // txtMarca
            // 
            txtMarca.Location = new Point(232, 112);
            // 
            // txtCantRuedas
            // 
            txtCantRuedas.Location = new Point(232, 324);
            // 
            // txtChasis
            // 
            txtChasis.Location = new Point(232, 246);
            // 
            // cmbColor
            // 
            cmbColor.Items.AddRange(new object[] { Colores.Rojo, Colores.Blanco, Colores.Azul, Colores.Gris, Colores.Negro, Colores.Rojo, Colores.Blanco, Colores.Azul, Colores.Gris, Colores.Negro, Colores.Rojo, Colores.Blanco, Colores.Azul, Colores.Gris, Colores.Negro, Colores.Rojo, Colores.Blanco, Colores.Azul, Colores.Gris, Colores.Negro, Colores.Rojo, Colores.Blanco, Colores.Azul, Colores.Gris, Colores.Negro, Colores.Rojo, Colores.Blanco, Colores.Azul, Colores.Gris, Colores.Negro, Colores.Rojo, Colores.Blanco, Colores.Azul, Colores.Gris, Colores.Negro });
            cmbColor.Location = new Point(232, 171);
            cmbColor.Size = new Size(122, 25);
            // 
            // txtMarchas
            // 
            txtMarchas.Location = new Point(232, 384);
            // 
            // lblMarca
            // 
            lblMarca.Location = new Point(73, 118);
            // 
            // btnCancelar
            // 
            btnCancelar.FlatAppearance.BorderColor = Color.Gray;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnCancelar.Location = new Point(257, 607);
            btnCancelar.Size = new Size(75, 29);
            // 
            // lblCilindrada
            // 
            lblCilindrada.AutoSize = true;
            lblCilindrada.Location = new Point(73, 455);
            lblCilindrada.Name = "lblCilindrada";
            lblCilindrada.Size = new Size(77, 19);
            lblCilindrada.TabIndex = 11;
            lblCilindrada.Text = "Cilindrada :";
            // 
            // lblUsoUrbano
            // 
            lblUsoUrbano.AutoSize = true;
            lblUsoUrbano.Location = new Point(73, 509);
            lblUsoUrbano.Name = "lblUsoUrbano";
            lblUsoUrbano.Size = new Size(90, 19);
            lblUsoUrbano.TabIndex = 12;
            lblUsoUrbano.Text = "Uso Urbano :";
            // 
            // txtCilindrada
            // 
            txtCilindrada.Location = new Point(232, 449);
            txtCilindrada.Name = "txtCilindrada";
            txtCilindrada.Size = new Size(122, 25);
            txtCilindrada.TabIndex = 13;
            txtCilindrada.KeyPress += txtCilindrada_KeyPress;
            // 
            // btnGuardar
            // 
            btnGuardar.FlatAppearance.BorderColor = Color.Gray;
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Location = new Point(75, 607);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 26);
            btnGuardar.TabIndex = 15;
            btnGuardar.Text = "Acepar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cmbUsoUrbano
            // 
            cmbUsoUrbano.FormattingEnabled = true;
            cmbUsoUrbano.Location = new Point(232, 509);
            cmbUsoUrbano.Name = "cmbUsoUrbano";
            cmbUsoUrbano.Size = new Size(119, 25);
            cmbUsoUrbano.TabIndex = 16;
            // 
            // FormMoto
            // 
            AcceptButton = btnGuardar;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(429, 685);
            Controls.Add(cmbUsoUrbano);
            Controls.Add(btnGuardar);
            Controls.Add(txtCilindrada);
            Controls.Add(lblUsoUrbano);
            Controls.Add(lblCilindrada);
            Name = "FormMoto";
            Text = "Motocicleta";
            Load += FormMoto_Load;
            Controls.SetChildIndex(btnCancelar, 0);
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