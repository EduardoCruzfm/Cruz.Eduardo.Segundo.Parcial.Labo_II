namespace WinFormsAppLoginUser
{
    partial class FormVehiculo
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
            btnCancelar = new Button();
            txtMarca = new TextBox();
            txtCantRuedas = new TextBox();
            txtChasis = new TextBox();
            cmbColor = new ComboBox();
            txtMarchas = new TextBox();
            lblMarca = new Label();
            lblColor = new Label();
            lblNChasis = new Label();
            lblCantRuedas = new Label();
            lblMarchas = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.FlatAppearance.BorderColor = Color.Gray;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Location = new Point(248, 570);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 26);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(235, 95);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(122, 25);
            txtMarca.TabIndex = 1;
            // 
            // txtCantRuedas
            // 
            txtCantRuedas.Location = new Point(235, 321);
            txtCantRuedas.Name = "txtCantRuedas";
            txtCantRuedas.Size = new Size(122, 25);
            txtCantRuedas.TabIndex = 2;
            txtCantRuedas.KeyPress += txtCantRuedas_KeyPress;
            // 
            // txtChasis
            // 
            txtChasis.Location = new Point(235, 243);
            txtChasis.Name = "txtChasis";
            txtChasis.Size = new Size(122, 25);
            txtChasis.TabIndex = 3;
            txtChasis.KeyPress += txtChasis_KeyPress;
            // 
            // cmbColor
            // 
            cmbColor.FormattingEnabled = true;
            cmbColor.Location = new Point(235, 168);
            cmbColor.Name = "cmbColor";
            cmbColor.Size = new Size(122, 25);
            cmbColor.TabIndex = 4;
            // 
            // txtMarchas
            // 
            txtMarchas.Location = new Point(235, 381);
            txtMarchas.Name = "txtMarchas";
            txtMarchas.Size = new Size(122, 25);
            txtMarchas.TabIndex = 5;
            txtMarchas.KeyPress += txtMarchas_KeyPress;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblMarca.Location = new Point(73, 104);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(54, 19);
            lblMarca.TabIndex = 6;
            lblMarca.Text = "Marca :";
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Location = new Point(73, 177);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(49, 19);
            lblColor.TabIndex = 7;
            lblColor.Text = "Color :";
            // 
            // lblNChasis
            // 
            lblNChasis.AutoSize = true;
            lblNChasis.Location = new Point(73, 252);
            lblNChasis.Name = "lblNChasis";
            lblNChasis.Size = new Size(74, 19);
            lblNChasis.TabIndex = 8;
            lblNChasis.Text = "N° Chasis :";
            // 
            // lblCantRuedas
            // 
            lblCantRuedas.AutoSize = true;
            lblCantRuedas.Location = new Point(73, 330);
            lblCantRuedas.Name = "lblCantRuedas";
            lblCantRuedas.Size = new Size(96, 19);
            lblCantRuedas.TabIndex = 9;
            lblCantRuedas.Text = "Cant. Ruedas :";
            // 
            // lblMarchas
            // 
            lblMarchas.AutoSize = true;
            lblMarchas.Location = new Point(73, 390);
            lblMarchas.Name = "lblMarchas";
            lblMarchas.Size = new Size(101, 19);
            lblMarchas.TabIndex = 10;
            lblMarchas.Text = "Cant Marchas :";
            // 
            // FormVehiculo
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(412, 630);
            Controls.Add(lblMarchas);
            Controls.Add(lblCantRuedas);
            Controls.Add(lblNChasis);
            Controls.Add(lblColor);
            Controls.Add(lblMarca);
            Controls.Add(txtMarchas);
            Controls.Add(cmbColor);
            Controls.Add(txtChasis);
            Controls.Add(txtCantRuedas);
            Controls.Add(txtMarca);
            Controls.Add(btnCancelar);
            Cursor = Cursors.Hand;
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormVehiculo";
            Text = "Vehiculo";
            Load += FormVehuiculo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblColor;
        private Label lblNChasis;
        private Label lblCantRuedas;
        private Label lblMarchas;
        protected TextBox txtMarca;
        protected TextBox txtCantRuedas;
        protected TextBox txtChasis;
        protected ComboBox cmbColor;
        protected TextBox txtMarchas;
        protected Label lblMarca;
        public Button btnCancelar;
    }
}