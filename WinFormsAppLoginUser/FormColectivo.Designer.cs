namespace WinFormsAppLoginUser
{
    partial class FormColectivo
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
            btnGuardar = new Button();
            label1 = new Label();
            lblCantPasajeros = new Label();
            txtCantPasajeros = new TextBox();
            cmbTransAutomatica = new ComboBox();
            SuspendLayout();
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(239, 112);
            // 
            // txtCantRuedas
            // 
            txtCantRuedas.Location = new Point(238, 324);
            // 
            // txtChasis
            // 
            txtChasis.Location = new Point(238, 246);
            // 
            // cmbColor
            // 
            cmbColor.Items.AddRange(new object[] { Colores.Rojo, Colores.Blanco, Colores.Azul, Colores.Gris, Colores.Negro, Colores.Rojo, Colores.Blanco, Colores.Azul, Colores.Gris, Colores.Negro, Colores.Rojo, Colores.Blanco, Colores.Azul, Colores.Gris, Colores.Negro, Colores.Rojo, Colores.Blanco, Colores.Azul, Colores.Gris, Colores.Negro, Colores.Rojo, Colores.Blanco, Colores.Azul, Colores.Gris, Colores.Negro, Colores.Rojo, Colores.Blanco, Colores.Azul, Colores.Gris, Colores.Negro });
            cmbColor.Location = new Point(239, 171);
            cmbColor.Size = new Size(122, 25);
            // 
            // txtMarchas
            // 
            txtMarchas.Location = new Point(238, 384);
            // 
            // lblMarca
            // 
            lblMarca.Location = new Point(73, 118);
            // 
            // btnCancelar
            // 
            btnCancelar.FlatAppearance.BorderColor = Color.Gray;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnCancelar.Location = new Point(261, 632);
            btnCancelar.Size = new Size(75, 29);
            // 
            // btnGuardar
            // 
            btnGuardar.FlatAppearance.BorderColor = Color.Gray;
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Location = new Point(94, 632);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 26);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 461);
            label1.Name = "label1";
            label1.Size = new Size(160, 19);
            label1.TabIndex = 12;
            label1.Text = "Transmicion automatica :";
            // 
            // lblCantPasajeros
            // 
            lblCantPasajeros.AutoSize = true;
            lblCantPasajeros.Location = new Point(72, 518);
            lblCantPasajeros.Name = "lblCantPasajeros";
            lblCantPasajeros.Size = new Size(132, 19);
            lblCantPasajeros.TabIndex = 13;
            lblCantPasajeros.Text = "Cantidad Pasajeros :";
            // 
            // txtCantPasajeros
            // 
            txtCantPasajeros.Location = new Point(238, 515);
            txtCantPasajeros.Name = "txtCantPasajeros";
            txtCantPasajeros.Size = new Size(122, 25);
            txtCantPasajeros.TabIndex = 15;
            txtCantPasajeros.KeyPress += txtCantPasajeros_KeyPress;
            // 
            // cmbTransAutomatica
            // 
            cmbTransAutomatica.FormattingEnabled = true;
            cmbTransAutomatica.Location = new Point(238, 455);
            cmbTransAutomatica.Name = "cmbTransAutomatica";
            cmbTransAutomatica.Size = new Size(121, 25);
            cmbTransAutomatica.TabIndex = 16;
            // 
            // FormColectivo
            // 
            AcceptButton = btnGuardar;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 700);
            Controls.Add(cmbTransAutomatica);
            Controls.Add(txtCantPasajeros);
            Controls.Add(lblCantPasajeros);
            Controls.Add(label1);
            Controls.Add(btnGuardar);
            Name = "FormColectivo";
            Text = "Colectivo";
            Load += FormColectivo_Load;
            Controls.SetChildIndex(btnCancelar, 0);
            Controls.SetChildIndex(txtMarca, 0);
            Controls.SetChildIndex(txtCantRuedas, 0);
            Controls.SetChildIndex(txtChasis, 0);
            Controls.SetChildIndex(cmbColor, 0);
            Controls.SetChildIndex(txtMarchas, 0);
            Controls.SetChildIndex(lblMarca, 0);
            Controls.SetChildIndex(btnGuardar, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(lblCantPasajeros, 0);
            Controls.SetChildIndex(txtCantPasajeros, 0);
            Controls.SetChildIndex(cmbTransAutomatica, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private Label label1;
        private Label lblCantPasajeros;
        private TextBox txtCantPasajeros;
        private ComboBox cmbTransAutomatica;
    }
}