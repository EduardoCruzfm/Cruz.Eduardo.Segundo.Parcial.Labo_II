namespace WinFormsAppLoginUser
{
    partial class FormAuto
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
            btnAceptar = new Button();
            lblTIpoCombustible = new Label();
            lblCnatPuertas = new Label();
            txtTipoCombustible = new TextBox();
            txtCantPuertas = new TextBox();
            SuspendLayout();
            // 
            // cmbColor
            // 
            cmbColor.Items.AddRange(new object[] { Colores.Rojo, Colores.Blanco, Colores.Azul, Colores.Gris, Colores.Negro, Colores.Rojo, Colores.Blanco, Colores.Azul, Colores.Gris, Colores.Negro });
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(84, 505);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 11;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAcepatar_Click;
            // 
            // lblTIpoCombustible
            // 
            lblTIpoCombustible.AutoSize = true;
            lblTIpoCombustible.Location = new Point(75, 402);
            lblTIpoCombustible.Name = "lblTIpoCombustible";
            lblTIpoCombustible.Size = new Size(121, 15);
            lblTIpoCombustible.TabIndex = 12;
            lblTIpoCombustible.Text = "Tipo de combustible :";
            // 
            // lblCnatPuertas
            // 
            lblCnatPuertas.AutoSize = true;
            lblCnatPuertas.Location = new Point(73, 451);
            lblCnatPuertas.Name = "lblCnatPuertas";
            lblCnatPuertas.Size = new Size(119, 15);
            lblCnatPuertas.TabIndex = 13;
            lblCnatPuertas.Text = "Cantidad de puertas :";
            // 
            // txtTipoCombustible
            // 
            txtTipoCombustible.Location = new Point(235, 399);
            txtTipoCombustible.Name = "txtTipoCombustible";
            txtTipoCombustible.Size = new Size(122, 23);
            txtTipoCombustible.TabIndex = 14;
            // 
            // txtCantPuertas
            // 
            txtCantPuertas.Location = new Point(235, 448);
            txtCantPuertas.Name = "txtCantPuertas";
            txtCantPuertas.Size = new Size(122, 23);
            txtCantPuertas.TabIndex = 15;
            // 
            // FormAuto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 576);
            Controls.Add(txtCantPuertas);
            Controls.Add(txtTipoCombustible);
            Controls.Add(lblCnatPuertas);
            Controls.Add(lblTIpoCombustible);
            Controls.Add(btnAceptar);
            Name = "FormAuto";
            Text = "FormAuto";
            Controls.SetChildIndex(txtMarca, 0);
            Controls.SetChildIndex(txtCantRuedas, 0);
            Controls.SetChildIndex(txtChasis, 0);
            Controls.SetChildIndex(cmbColor, 0);
            Controls.SetChildIndex(txtMarchas, 0);
            Controls.SetChildIndex(lblMarca, 0);
            Controls.SetChildIndex(btnAceptar, 0);
            Controls.SetChildIndex(lblTIpoCombustible, 0);
            Controls.SetChildIndex(lblCnatPuertas, 0);
            Controls.SetChildIndex(txtTipoCombustible, 0);
            Controls.SetChildIndex(txtCantPuertas, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private Label lblTIpoCombustible;
        private Label lblCnatPuertas;
        private TextBox txtTipoCombustible;
        private TextBox txtCantPuertas;
    }
}