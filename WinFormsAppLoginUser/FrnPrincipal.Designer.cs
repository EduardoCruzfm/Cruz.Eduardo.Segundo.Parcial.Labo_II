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
            gBoxOrdenar.SuspendLayout();
            gBoxDeForma.SuspendLayout();
            SuspendLayout();
            // 
            // lstVisor
            // 
            lstVisor.FormattingEnabled = true;
            lstVisor.ItemHeight = 15;
            lstVisor.Location = new Point(24, 55);
            lstVisor.Name = "lstVisor";
            lstVisor.Size = new Size(717, 229);
            lstVisor.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(246, 344);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(463, 344);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(666, 344);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Location = new Point(359, 18);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(89, 15);
            lblNombreUsuario.TabIndex = 4;
            lblNombreUsuario.Text = "nombreUsuario";
            // 
            // cmbTipoVehiculo
            // 
            cmbTipoVehiculo.FormattingEnabled = true;
            cmbTipoVehiculo.Location = new Point(37, 344);
            cmbTipoVehiculo.Name = "cmbTipoVehiculo";
            cmbTipoVehiculo.Size = new Size(144, 23);
            cmbTipoVehiculo.TabIndex = 5;
            // 
            // gBoxOrdenar
            // 
            gBoxOrdenar.Controls.Add(rdCantRuedas);
            gBoxOrdenar.Controls.Add(rdNChasis);
            gBoxOrdenar.Location = new Point(37, 384);
            gBoxOrdenar.Name = "gBoxOrdenar";
            gBoxOrdenar.Size = new Size(235, 54);
            gBoxOrdenar.TabIndex = 6;
            gBoxOrdenar.TabStop = false;
            gBoxOrdenar.Text = "Ordenar por :";
            // 
            // rdCantRuedas
            // 
            rdCantRuedas.AutoSize = true;
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
            btnOrdenar.Location = new Point(261, 22);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(75, 23);
            btnOrdenar.TabIndex = 2;
            btnOrdenar.Text = "Ordenar";
            btnOrdenar.UseVisualStyleBackColor = true;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // gBoxDeForma
            // 
            gBoxDeForma.Controls.Add(rdDesendente);
            gBoxDeForma.Controls.Add(btnOrdenar);
            gBoxDeForma.Controls.Add(rdAsendente);
            gBoxDeForma.Location = new Point(323, 384);
            gBoxDeForma.Name = "gBoxDeForma";
            gBoxDeForma.Size = new Size(369, 54);
            gBoxDeForma.TabIndex = 7;
            gBoxDeForma.TabStop = false;
            gBoxDeForma.Text = "De forma :";
            // 
            // rdDesendente
            // 
            rdDesendente.AutoSize = true;
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
            lblFecha.Location = new Point(500, 18);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 8;
            lblFecha.Text = "Fecha";
            // 
            // FrnPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblFecha);
            Controls.Add(gBoxDeForma);
            Controls.Add(gBoxOrdenar);
            Controls.Add(cmbTipoVehiculo);
            Controls.Add(lblNombreUsuario);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(lstVisor);
            Name = "FrnPrincipal";
            Text = "Form1";
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
    }
}