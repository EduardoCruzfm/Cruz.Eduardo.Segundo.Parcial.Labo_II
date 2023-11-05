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
    public partial class FormVehiculo : Form
    {

        public FormVehiculo(Vehiculo vehiculo)
        {
            this.txtMarca.Text = vehiculo.Marca;
            this.txtChasis.Text = vehiculo.NChasis.ToString();
            this.txtCantRuedas.Text = vehiculo.CantidadRuedas.ToString();
            this.txtMarchas.Text = vehiculo.CantidadMarchas.ToString();
            this.cmbColor.Text = vehiculo.Color.ToString();

        }

        //public Vehiculo Vehiculo { get { return this.vehiculo;  } }

        public FormVehiculo()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormVehuiculo_Load(object sender, EventArgs e)
        {
            foreach (Colores color in Enum.GetValues(typeof(Colores)))
            {
                this.cmbColor.Items.Add(color);
            }

            //this.cmbColor.SelectedIndex = 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// QueSeaNumero() Verifica si la tecla presionada es un número o la tecla Backspace (para borrar)
        /// Si no es un número ni la tecla Backspace, no permitir la entrada.
        /// </summary>
        /// <param name="e">Evento de KeyPressEventArgs</param>
        protected void QueSeaNumero(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtChasis_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.QueSeaNumero(e);
        }

        private void txtCantRuedas_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.QueSeaNumero(e);
        }

        private void txtMarchas_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.QueSeaNumero(e);
        }

        /// <summary>
        /// QueNoHallaCamposVacios() Valida que si alguno de los campos es falso retorna false, 
        /// en caso contrario true
        /// </summary>
        /// <returns>bool</returns>
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
