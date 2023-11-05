namespace WinFormsAppLoginUser
{
    partial class FormMostrarLogeos
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
            lstLog = new ListBox();
            btnCerrar = new Button();
            SuspendLayout();
            // 
            // lstLog
            // 
            lstLog.BackColor = Color.Gainsboro;
            lstLog.FormattingEnabled = true;
            lstLog.ItemHeight = 15;
            lstLog.Location = new Point(56, 40);
            lstLog.Name = "lstLog";
            lstLog.Size = new Size(734, 379);
            lstLog.TabIndex = 0;
            lstLog.SelectedIndexChanged += lstLog_SelectedIndexChanged;
            // 
            // btnCerrar
            // 
            btnCerrar.FlatAppearance.BorderColor = Color.Gray;
            btnCerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(382, 451);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 23);
            btnCerrar.TabIndex = 1;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FormMostrarLogeos
            // 
            AcceptButton = btnCerrar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(864, 577);
            Controls.Add(btnCerrar);
            Controls.Add(lstLog);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMostrarLogeos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Historial Logeos";
            Load += FormMostrarLogeos_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstLog;
        private Button btnCerrar;
    }
}