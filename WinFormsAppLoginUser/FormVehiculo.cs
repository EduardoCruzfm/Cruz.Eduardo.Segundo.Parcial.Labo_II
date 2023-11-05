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
    /// Clase base para formularios que muestran información de un vehículo.
    /// </summary>
    public partial class FormVehiculo : Form
    {

        /// <summary>
        /// Constructor de la clase FormVehiculo que permite inicializar los campos del formulario 
        /// con los datos de un vehículo.
        /// </summary>
        /// <param name="vehiculo">El objeto de tipo Vehiculo que contiene los datos del vehículo</param>
        public FormVehiculo(Vehiculo vehiculo)
        {
            this.txtMarca.Text = vehiculo.Marca;
            this.txtChasis.Text = vehiculo.NChasis.ToString();
            this.txtCantRuedas.Text = vehiculo.CantidadRuedas.ToString();
            this.txtMarchas.Text = vehiculo.CantidadMarchas.ToString();
            this.cmbColor.Text = vehiculo.Color.ToString();

        }

        /// <summary>
        /// Constructor vacío de la clase FormVehiculo.
        /// </summary>
        public FormVehiculo()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        /// <summary>
        /// FormVehuiculo_Load() Va a cargar el cmbColor con el Enum Colores 
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">El evento EventArgs.</param>
        private void FormVehuiculo_Load(object sender, EventArgs e)
        {
            foreach (Colores color in Enum.GetValues(typeof(Colores)))
            {
                this.cmbColor.Items.Add(color);
            }
        }

        /// <summary>
        /// Maneja el evento de clic en el botón "Cancelar".
        /// Establece el resultado del diálogo como "Cancelar".
        /// </summary>
        /// <param name="sender">El objeto que generó el evento (el botón "Cancelar").</param>
        /// <param name="e">El evento EventArgs.</param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// QueSeaNumero() Verifica si la tecla presionada es un número o la tecla Backspace (para borrar)
        /// Si no es un número ni la tecla Backspace, no permitir la entrada.
        /// </summary>
        /// <param name="e">Evento de KeyPressEventArgs.</param>
        protected void QueSeaNumero(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Controla el evento KeyPress para el campo de txtChasis.
        /// Verifica que el valor ingresado sea un número.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">El evento KeyPressEventArgs.</param>
        private void txtChasis_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.QueSeaNumero(e);
        }

        /// <summary>
        /// Controla el evento KeyPress para el campo de txtCantRuedas.
        /// Verifica que el valor ingresado sea un número.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">El evento KeyPressEventArgs.</param>
        private void txtCantRuedas_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.QueSeaNumero(e);
        }

        /// <summary>
        /// Controla el evento KeyPress para el campo de txtMarchas.
        /// Verifica que el valor ingresado sea un número.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">El evento KeyPressEventArgs.</param>
        private void txtMarchas_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.QueSeaNumero(e);
        }

        /// <summary>
        /// QueNoHallaCamposVacios() Valida los campos de FormVehiculo
        /// </summary>
        /// <returns>Retorna true si los campos del FormVehiculo son validos, de lo contrario false.</returns>
        protected bool QueNoHallaCamposVacios()
        {
            bool retorno = true;

            // Valida si el campo de marca está vacío
            if (string.IsNullOrWhiteSpace(this.txtMarca.Text))
            {
                retorno = false;
            }

            // Valida si el campo de cantidad de ruedas es un número válido
            if (!short.TryParse(this.txtCantRuedas.Text, out short cantRuedas))
            {
                retorno = false;
            }

            // Valida si el campo de cantidad de marchas es un número válido
            if (!short.TryParse(this.txtMarchas.Text, out short cantMarchas))
            {
                retorno = false;
            }

            // Valida si el campo de chasis es un número válido
            if (!long.TryParse(this.txtChasis.Text, out long nChasis))
            {
                retorno = false;
            }

            return retorno;
        }
    }
}
