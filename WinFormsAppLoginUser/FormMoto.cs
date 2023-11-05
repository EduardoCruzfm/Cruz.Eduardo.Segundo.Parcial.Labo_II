using Cruz.Eduardo.Primer.Parcial.Labo_II;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppLoginUser
{
    /// <summary>
    /// Representa un formulario para la creacion y edición de datos de una Motocicleta.
    /// </summary>
    public partial class FormMoto : FormVehiculo
    {
        protected Motocicleta moto;

        /// <summary>
        /// Retorna el atributo de tipo Motocicleta moto.
        /// </summary>
        public Motocicleta Moto { get { return this.moto; } }

        /// <summary>
        /// Inicializa una nueva instancia de la clase FormMoto.
        /// Agrega dos items al comboBox.
        /// </summary>
        public FormMoto() : base()
        {
            InitializeComponent();
            this.cmbUsoUrbano.Items.Add("Si");
            this.cmbUsoUrbano.Items.Add("No");
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase FormMoto y llena los campos del formulario
        /// con los datos de un objeto de tipo Motocicleta.
        /// </summary>
        /// <param name="m">El objeto de tipo Motocicleta que contiene los datos de la motocicleta.</param>
        public FormMoto(Motocicleta m) : this()
        {
            this.txtMarca.Text = m.Marca;
            this.txtCantRuedas.Text = m.CantidadRuedas.ToString();
            this.txtMarchas.Text = m.CantidadMarchas.ToString();
            this.cmbColor.Text = m.Color.ToString();
            this.txtChasis.Text = m.NChasis;

            this.txtCilindrada.Text = m.Cilindrada.ToString();
            this.cmbUsoUrbano.Text = m.Urbano.ToString();
        }

        private void FormMoto_Load(object sender, EventArgs e)
        {
            // Establecer la selección predeterminada
            //this.cmbUsoUrbano.SelectedIndex = 0;

        }

        /// <summary>
        /// btnGuardar_Click() Verifica que los campos no esten vacios antes de agregar
        /// una Motocicleta.
        /// Muestra un mensaje de aviso si hay campos vacíos o datos incorrectos.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">El evento</param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (this.QueNoHallaCamposVacios() == true) 
            {
                bool retono = true;

                if (!short.TryParse(this.txtCilindrada.Text, out short cilindrda)) { retono = false; }

                if (string.IsNullOrWhiteSpace(this.cmbUsoUrbano.Text)) { retono = false; }

                if (retono)
                {
                    string marca = this.txtMarca.Text;
                    short cantRuedas = short.Parse(this.txtCantRuedas.Text);
                    short cantMarchas = short.Parse(this.txtMarchas.Text);
                    Colores color = (Colores)Enum.Parse(typeof(Colores), this.cmbColor.Text);
                    string nChasis = this.txtChasis.Text;

                    short cilindrada = short.Parse(this.txtCilindrada.Text);
                    string usoUrbano = this.cmbUsoUrbano.Text;

                    this.moto = new Motocicleta(marca, cantRuedas, cantMarchas, color, nChasis, cilindrada, usoUrbano);
                    this.DialogResult = DialogResult.OK;
                }
                else { MessageBox.Show("Por favor, verifique los demas datos."); }
            }
            else { MessageBox.Show("Por favor, ingrese los datos."); }
        }

        /// <summary>
        /// Controla el evento KeyPress para el campo de txtCilindrada.
        /// Verifica que el valor ingresado sea un número.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">El evento</param>
        private void txtCilindrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.QueSeaNumero(e);
        }
    }
}
