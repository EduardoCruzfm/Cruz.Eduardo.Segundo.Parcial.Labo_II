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
            // txtMarca
            // 
            txtMarca.Location = new Point(235, 108);
            // 
            // txtCantRuedas
            // 
            txtCantRuedas.Location = new Point(236, 324);
            // 
            // txtChasis
            // 
            txtChasis.Location = new Point(235, 246);
            // 
            // cmbColor
            // 
            cmbColor.Items.AddRange(new object[] { Colores.Rojo, Colores.Blanco, Colores.Azul, Colores.Gris, Colores.Negro, Colores.Rojo, Colores.Blanco, Colores.Azul, Colores.Gris, Colores.Negro, Colores.Rojo, Colores.Blanco, Colores.Azul, Colores.Gris, Colores.Negro, Colores.Rojo, Colores.Blanco, Colores.Azul, Colores.Gris, Colores.Negro, Colores.Rojo, Colores.Blanco, Colores.Azul, Colores.Gris, Colores.Negro, Colores.Rojo, Colores.Blanco, Colores.Azul, Colores.Gris, Colores.Negro });
            cmbColor.Location = new Point(235, 171);
            cmbColor.Size = new Size(122, 25);
            // 
            // txtMarchas
            // 
            txtMarchas.Location = new Point(235, 384);
            // 
            // lblMarca
            // 
            lblMarca.Location = new Point(73, 118);
            // 
            // btnCancelar
            // 
            btnCancelar.FlatAppearance.BorderColor = Color.Gray;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnCancelar.Location = new Point(247, 627);
            btnCancelar.Size = new Size(75, 29);
            // 
            // btnAceptar
            // 
            btnAceptar.FlatAppearance.BorderColor = Color.Gray;
            btnAceptar.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Location = new Point(90, 630);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 26);
            btnAceptar.TabIndex = 11;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAcepatar_Click;
            // 
            // lblTIpoCombustible
            // 
            lblTIpoCombustible.AutoSize = true;
            lblTIpoCombustible.Location = new Point(73, 460);
            lblTIpoCombustible.Name = "lblTIpoCombustible";
            lblTIpoCombustible.Size = new Size(139, 19);
            lblTIpoCombustible.TabIndex = 12;
            lblTIpoCombustible.Text = "Tipo de combustible :";
            // 
            // lblCnatPuertas
            // 
            lblCnatPuertas.AutoSize = true;
            lblCnatPuertas.Location = new Point(73, 524);
            lblCnatPuertas.Name = "lblCnatPuertas";
            lblCnatPuertas.Size = new Size(140, 19);
            lblCnatPuertas.TabIndex = 13;
            lblCnatPuertas.Text = "Cantidad de puertas :";
            // 
            // txtTipoCombustible
            // 
            txtTipoCombustible.Location = new Point(236, 454);
            txtTipoCombustible.Name = "txtTipoCombustible";
            txtTipoCombustible.Size = new Size(122, 25);
            txtTipoCombustible.TabIndex = 14;
            // 
            // txtCantPuertas
            // 
            txtCantPuertas.Location = new Point(236, 518);
            txtCantPuertas.Name = "txtCantPuertas";
            txtCantPuertas.Size = new Size(122, 25);
            txtCantPuertas.TabIndex = 15;
            txtCantPuertas.KeyPress += txtCantPuertas_KeyPress;
            // 
            // FormAuto
            // 
            AcceptButton = btnAceptar;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 699);
            Controls.Add(txtCantPuertas);
            Controls.Add(txtTipoCombustible);
            Controls.Add(lblCnatPuertas);
            Controls.Add(lblTIpoCombustible);
            Controls.Add(btnAceptar);
            Name = "FormAuto";
            Text = "Automovil";
            Controls.SetChildIndex(btnCancelar, 0);
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