namespace WinFormsAppLoginUser
{
    partial class FrnPrincipal
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
            lstVisor = new ListBox();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            lblNombreUsuario = new Label();
            cmbTipoVehiculo = new ComboBox();
            gBoxOrdenar = new GroupBox();
            rdCantRuedas = new RadioButton();
            rdNChasis = new RadioButton();
            btnOrdenar = new Button();
            gBoxDeForma = new GroupBox();
            rdDesendente = new RadioButton();
            rdAsendente = new RadioButton();
            lblFecha = new Label();
            btnHistorialLog = new Button();
            lblDireccion = new Label();
            txtDirecion = new TextBox();
            btnAbrir = new Button();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            btnGuardar = new Button();
            lblEstado = new Label();
            lblPerfil = new Label();
            gBoxOrdenar.SuspendLayout();
            gBoxDeForma.SuspendLayout();
            SuspendLayout();
            // 
            // lstVisor
            // 
            lstVisor.BackColor = Color.Gainsboro;
            lstVisor.Cursor = Cursors.Hand;
            lstVisor.FormattingEnabled = true;
            lstVisor.ItemHeight = 15;
            lstVisor.Location = new Point(24, 55);
            lstVisor.Name = "lstVisor";
            lstVisor.Size = new Size(851, 229);
            lstVisor.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(64, 64, 64);
            btnAgregar.FlatAppearance.BorderColor = Color.Gray;
            btnAgregar.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(276, 343);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(64, 64, 64);
            btnModificar.FlatAppearance.BorderColor = Color.Gray;
            btnModificar.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(493, 343);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(64, 64, 64);
            btnEliminar.FlatAppearance.BorderColor = Color.Gray;
            btnEliminar.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(647, 343);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreUsuario.ForeColor = Color.White;
            lblNombreUsuario.Location = new Point(447, 19);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(104, 19);
            lblNombreUsuario.TabIndex = 4;
            lblNombreUsuario.Text = "nombreUsuario";
            // 
            // cmbTipoVehiculo
            // 
            cmbTipoVehiculo.BackColor = Color.Gainsboro;
            cmbTipoVehiculo.Cursor = Cursors.Hand;
            cmbTipoVehiculo.FlatStyle = FlatStyle.Flat;
            cmbTipoVehiculo.FormattingEnabled = true;
            cmbTipoVehiculo.Location = new Point(67, 343);
            cmbTipoVehiculo.Name = "cmbTipoVehiculo";
            cmbTipoVehiculo.Size = new Size(144, 23);
            cmbTipoVehiculo.TabIndex = 5;
            // 
            // gBoxOrdenar
            // 
            gBoxOrdenar.Controls.Add(rdCantRuedas);
            gBoxOrdenar.Controls.Add(rdNChasis);
            gBoxOrdenar.ForeColor = Color.FromArgb(128, 128, 255);
            gBoxOrdenar.Location = new Point(67, 383);
            gBoxOrdenar.Name = "gBoxOrdenar";
            gBoxOrdenar.Size = new Size(235, 54);
            gBoxOrdenar.TabIndex = 6;
            gBoxOrdenar.TabStop = false;
            gBoxOrdenar.Text = "Ordenar por :";
            // 
            // rdCantRuedas
            // 
            rdCantRuedas.AutoSize = true;
            rdCantRuedas.ForeColor = Color.White;
            rdCantRuedas.Location = new Point(122, 22);
            rdCantRuedas.Name = "rdCantRuedas";
            rdCantRuedas.Size = new Size(107, 19);
            rdCantRuedas.TabIndex = 1;
            rdCantRuedas.TabStop = true;
            rdCantRuedas.Text = "Cant. de ruedas";
            rdCantRuedas.UseVisualStyleBackColor = true;
            // 
            // rdNChasis
            // 
            rdNChasis.AutoSize = true;
            rdNChasis.ForeColor = Color.White;
            rdNChasis.Location = new Point(17, 22);
            rdNChasis.Name = "rdNChasis";
            rdNChasis.Size = new Size(76, 19);
            rdNChasis.TabIndex = 0;
            rdNChasis.TabStop = true;
            rdNChasis.Text = "N° Chasis";
            rdNChasis.UseVisualStyleBackColor = true;
            // 
            // btnOrdenar
            // 
            btnOrdenar.BackColor = Color.FromArgb(64, 64, 64);
            btnOrdenar.FlatAppearance.BorderColor = Color.Gray;
            btnOrdenar.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnOrdenar.FlatStyle = FlatStyle.Flat;
            btnOrdenar.ForeColor = Color.White;
            btnOrdenar.Location = new Point(270, 20);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(75, 23);
            btnOrdenar.TabIndex = 2;
            btnOrdenar.Text = "Ordenar";
            btnOrdenar.UseVisualStyleBackColor = false;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // gBoxDeForma
            // 
            gBoxDeForma.Controls.Add(rdDesendente);
            gBoxDeForma.Controls.Add(btnOrdenar);
            gBoxDeForma.Controls.Add(rdAsendente);
            gBoxDeForma.ForeColor = Color.FromArgb(128, 128, 255);
            gBoxDeForma.Location = new Point(353, 383);
            gBoxDeForma.Name = "gBoxDeForma";
            gBoxDeForma.Size = new Size(369, 54);
            gBoxDeForma.TabIndex = 7;
            gBoxDeForma.TabStop = false;
            gBoxDeForma.Text = "De forma :";
            // 
            // rdDesendente
            // 
            rdDesendente.AutoSize = true;
            rdDesendente.ForeColor = Color.White;
            rdDesendente.Location = new Point(135, 22);
            rdDesendente.Name = "rdDesendente";
            rdDesendente.Size = new Size(87, 19);
            rdDesendente.TabIndex = 1;
            rdDesendente.TabStop = true;
            rdDesendente.Text = "Desendente";
            rdDesendente.UseVisualStyleBackColor = true;
            // 
            // rdAsendente
            // 
            rdAsendente.AutoSize = true;
            rdAsendente.ForeColor = Color.White;
            rdAsendente.Location = new Point(16, 22);
            rdAsendente.Name = "rdAsendente";
            rdAsendente.Size = new Size(81, 19);
            rdAsendente.TabIndex = 0;
            rdAsendente.TabStop = true;
            rdAsendente.Text = "Asendente";
            rdAsendente.UseVisualStyleBackColor = true;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblFecha.ForeColor = Color.White;
            lblFecha.Location = new Point(678, 20);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(44, 19);
            lblFecha.TabIndex = 8;
            lblFecha.Text = "Fecha";
            // 
            // btnHistorialLog
            // 
            btnHistorialLog.BackColor = Color.FromArgb(64, 64, 64);
            btnHistorialLog.FlatAppearance.BorderColor = Color.Gray;
            btnHistorialLog.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnHistorialLog.FlatStyle = FlatStyle.Flat;
            btnHistorialLog.ForeColor = Color.White;
            btnHistorialLog.Location = new Point(777, 383);
            btnHistorialLog.Name = "btnHistorialLog";
            btnHistorialLog.Size = new Size(75, 23);
            btnHistorialLog.TabIndex = 9;
            btnHistorialLog.Text = "Logueos";
            btnHistorialLog.UseVisualStyleBackColor = false;
            btnHistorialLog.Click += btnHistorialLog_Click;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.ForeColor = Color.White;
            lblDireccion.Location = new Point(67, 464);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(63, 15);
            lblDireccion.TabIndex = 10;
            lblDireccion.Text = "Direccion :";
            // 
            // txtDirecion
            // 
            txtDirecion.BackColor = Color.Gainsboro;
            txtDirecion.Location = new Point(136, 461);
            txtDirecion.Name = "txtDirecion";
            txtDirecion.Size = new Size(474, 23);
            txtDirecion.TabIndex = 11;
            // 
            // btnAbrir
            // 
            btnAbrir.BackColor = Color.FromArgb(64, 64, 64);
            btnAbrir.FlatAppearance.BorderColor = Color.Gray;
            btnAbrir.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnAbrir.FlatStyle = FlatStyle.Flat;
            btnAbrir.ForeColor = Color.White;
            btnAbrir.Location = new Point(647, 460);
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(75, 23);
            btnAbrir.TabIndex = 12;
            btnAbrir.Text = "Abrir";
            btnAbrir.UseVisualStyleBackColor = false;
            btnAbrir.Click += btnAbrir_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnGuardar
            // 
            btnGuardar.FlatAppearance.BorderColor = Color.Gray;
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(777, 460);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.BackColor = Color.Transparent;
            lblEstado.BorderStyle = BorderStyle.FixedSingle;
            lblEstado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEstado.ForeColor = SystemColors.ButtonHighlight;
            lblEstado.Location = new Point(38, 16);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(127, 23);
            lblEstado.TabIndex = 14;
            lblEstado.Text = "Estado Conexion";
            // 
            // lblPerfil
            // 
            lblPerfil.AutoSize = true;
            lblPerfil.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblPerfil.ForeColor = Color.White;
            lblPerfil.Location = new Point(276, 20);
            lblPerfil.Name = "lblPerfil";
            lblPerfil.Size = new Size(38, 19);
            lblPerfil.TabIndex = 15;
            lblPerfil.Text = "Perfil";
            // 
            // FrnPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(903, 522);
            Controls.Add(lblPerfil);
            Controls.Add(lblEstado);
            Controls.Add(btnGuardar);
            Controls.Add(btnAbrir);
            Controls.Add(txtDirecion);
            Controls.Add(lblDireccion);
            Controls.Add(btnHistorialLog);
            Controls.Add(lblFecha);
            Controls.Add(gBoxDeForma);
            Controls.Add(gBoxOrdenar);
            Controls.Add(cmbTipoVehiculo);
            Controls.Add(lblNombreUsuario);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(lstVisor);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            ImeMode = ImeMode.Off;
            Name = "FrnPrincipal";
            Text = "Estacionamiento";
            FormClosing += FrnPrincipal_FormClosing;
            Load += FrnPrincipal_Load;
            gBoxOrdenar.ResumeLayout(false);
            gBoxOrdenar.PerformLayout();
            gBoxDeForma.ResumeLayout(false);
            gBoxDeForma.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstVisor;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private Label lblNombreUsuario;
        private ComboBox cmbTipoVehiculo;
        private GroupBox gBoxOrdenar;
        private RadioButton rdCantRuedas;
        private RadioButton rdNChasis;
        private Button btnOrdenar;
        private GroupBox gBoxDeForma;
        private RadioButton rdDesendente;
        private RadioButton rdAsendente;
        private Label lblFecha;
        private Button btnHistorialLog;
        private Label lblDireccion;
        private TextBox txtDirecion;
        private Button btnAbrir;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Button btnGuardar;
        private Label lblEstado;
        private Label lblPerfil;
    }
}