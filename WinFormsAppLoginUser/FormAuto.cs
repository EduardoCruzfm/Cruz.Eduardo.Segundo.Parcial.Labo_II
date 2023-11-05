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
    /// Representa un formulario para la creacion y edición de datos de un Automóvil.
    /// </summary>
    public partial class FormAuto : FormVehiculo
    {
        protected Automovil auto;

        /// <summary>
        /// Retorna el atributo de tipo Automovil auto.
        /// </summary>
        public Automovil Auto { get { return this.auto; } }

        /// <summary>
        /// Inicializa una nueva instancia de la clase FormAuto.
        /// </summary>
        public FormAuto()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase FormAuto y llena los campos del formulario
        /// con los datos de un objeto de tipo Automovil.
        /// </summary>
        /// <param name="a">El objeto de tipo Automovil que contiene los datos del automovil.</param>
        public FormAuto(Automovil a) : this()
        {
            this.txtMarca.Text = a.Marca;
            this.txtChasis.Text = a.NChasis;
            this.txtCantRuedas.Text = a.CantidadRuedas.ToString();
            this.txtMarchas.Text = a.CantidadMarchas.ToString();
            this.cmbColor.Text = a.Color.ToString();

            this.txtTipoCombustible.Text = a.TipoDeCombustible;
            this.txtCantPuertas.Text = a.CantidadDePuertas.ToString();
        }

        /// <summary>
        /// btnAcepatar_Click() Verifica que los campos no esten vacios antes de agregar
        /// un Automovil.
        /// Muestra un mensaje de aviso si hay campos vacíos o datos incorrectos.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">El evento.</param>
        private void btnAcepatar_Click(object sender, EventArgs e)
        {
            if (this.QueNoHallaCamposVacios() == true)
            {
                bool retono = true;

                if (string.IsNullOrWhiteSpace(this.txtTipoCombustible.Text)) { retono = false; }

                if (!short.TryParse(this.txtCantPuertas.Text, out short cantPuerta)) { retono = false; }

                if (retono)
                {
                    string marca = this.txtMarca.Text;
                    short cantRuedas = short.Parse(this.txtCantRuedas.Text);
                    short cantMarchas = short.Parse(this.txtMarchas.Text);
                    Colores color = (Colores)this.cmbColor.SelectedItem;
                    string nChasis = this.txtChasis.Text;
                    string tipoCombustible = this.txtTipoCombustible.Text;
                    short cantPuertas = short.Parse(this.txtCantPuertas.Text);

                    this.auto = new Automovil(marca, cantRuedas, cantMarchas, color, nChasis, tipoCombustible, cantPuertas);

                    this.DialogResult = DialogResult.OK;
                }
                else { MessageBox.Show("Por favor, verifique los demas datos."); }
            }
            else { MessageBox.Show("Por favor, ingrese los datos."); }
        }

        /// <summary>
        /// Controla el evento KeyPress para el campo de txtCantPuertas.
        /// Verifica que el valor ingresado sea un número.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">El evento</param>
        private void txtCantPuertas_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.QueSeaNumero(e);
        }
    }
}
