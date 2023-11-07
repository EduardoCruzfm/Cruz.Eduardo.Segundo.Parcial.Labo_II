namespace WinFormsAppLoginUser
{
    partial class FrmLogin
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
            btnCancelar = new Button();
            lblContraseña = new Label();
            lblUsuario = new Label();
            txtContraseña = new TextBox();
            txtUsuario = new TextBox();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.FlatAppearance.BorderColor = Color.Gray;
            btnAceptar.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(85, 320);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            btnAceptar.KeyPress += btnAceptar_KeyPress;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatAppearance.BorderColor = Color.Gray;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(246, 320);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblContraseña.ForeColor = Color.White;
            lblContraseña.Location = new Point(126, 209);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(79, 19);
            lblContraseña.TabIndex = 2;
            lblContraseña.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsuario.ForeColor = Color.White;
            lblUsuario.Location = new Point(85, 99);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(56, 19);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "Usuario";
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = Color.Gainsboro;
            txtContraseña.Location = new Point(215, 222);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.PlaceholderText = "Ingrese contraseña";
            txtContraseña.Size = new Size(170, 23);
            txtContraseña.TabIndex = 4;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.Gainsboro;
            txtUsuario.Location = new Point(215, 99);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Ingrese usuario";
            txtUsuario.Size = new Size(170, 23);
            txtUsuario.TabIndex = 5;
            // 
            // FrmLogin
            // 
            AcceptButton = btnAceptar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(423, 405);
            Controls.Add(txtUsuario);
            Controls.Add(txtContraseña);
            Controls.Add(lblUsuario);
            Controls.Add(lblContraseña);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Cursor = Cursors.Hand;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLogin";
            Text = "Ingrese sus datos";
            KeyPress += FrmLogin_KeyPress;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private Button btnCancelar;
        private Label lblContraseña;
        private Label lblUsuario;
        private TextBox txtContraseña;
        private TextBox txtUsuario;
    }
}