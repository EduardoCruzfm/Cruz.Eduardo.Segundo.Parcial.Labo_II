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
    /// Representa un formulario para la creacion y edición de datos de un Colectivo.
    /// </summary>
    public partial class FormColectivo : FormVehiculo
    {
        protected Colectivo colctivo;

        /// <summary>
        /// Retorna el atributo de tipo Colectivo colctivo.
        /// </summary>
        public Colectivo Colctivo { get { return this.colctivo; } }

        /// <summary>
        /// Inicializa una nueva instancia de la clase FormColectivo.
        /// Agrega dos items al comboBox.
        /// </summary>
        public FormColectivo()
        {
            InitializeComponent();
            this.cmbTransAutomatica.Items.Add("Si");
            this.cmbTransAutomatica.Items.Add("No");
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase FormColectivo y llena los campos del formulario
        /// con los datos de un objeto de tipo Colectivo.
        /// </summary>
        /// <param name="c">El objeto de tipo Colectivo que contiene los datos del colectivo.</param>
        public FormColectivo(Colectivo c) : this()
        {
            this.txtMarca.Text = c.Marca;
            this.txtChasis.Text = c.NChasis;
            this.txtCantRuedas.Text = c.CantidadRuedas.ToString();
            this.txtMarchas.Text = c.CantidadMarchas.ToString();
            this.cmbColor.Text = c.Color.ToString();
            this.cmbTransAutomatica.Text = c.EsAutomatico;
            this.txtCantPasajeros.Text = c.CantidadDePasajeros.ToString();
        }

        private void FormColectivo_Load(object sender, EventArgs e)
        {
            //this.cmbTransAutomatica.SelectedIndex = 0;

        }

        /// <summary>
        /// btnGuardar_Click() Verifica que los campos no esten vacios antes de agregar
        /// un Colectivo.
        /// Muestra un mensaje de aviso si hay campos vacíos o datos incorrectos.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">El evento</param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.QueNoHallaCamposVacios() == true)
            {
                bool retono = true;

                if (string.IsNullOrWhiteSpace(this.cmbTransAutomatica.Text)) { retono = false; }

                if (!int.TryParse(this.txtCantPasajeros.Text, out int cntPasajeros)) { retono = false; }

                if (retono)
                {
                    string marca = this.txtMarca.Text;
                    short cantRuedas = short.Parse(this.txtCantRuedas.Text);
                    short cantMarchas = short.Parse(this.txtMarchas.Text);
                    Colores color = (Colores)this.cmbColor.SelectedItem;
                    string nChasis = this.txtChasis.Text;

                    string esAutomatico = this.cmbTransAutomatica.Text;
                    int cantPasajeros = int.Parse(this.txtCantPasajeros.Text);

                    this.colctivo = new Colectivo(marca, cantRuedas, cantMarchas, color, nChasis, esAutomatico, cantPasajeros);
                    this.DialogResult = DialogResult.OK;
                }
                else { MessageBox.Show("Por favor, verifique los demas datos."); }
            }
            else { MessageBox.Show("Por favor, ingrese los datos."); }
        }

        /// <summary>
        /// Controla el evento KeyPress para el campo de txtCantPasajeros.
        /// Verifica que el valor ingresado sea un número.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">El evento</param>
        private void txtCantPasajeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.QueSeaNumero(e);
        }
    }
}
