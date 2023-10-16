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
    public partial class FormAuto : FormVehiculo
    {
        protected Automovil auto;

        public Automovil Auto { get { return this.auto; } }

        public FormAuto()
        {
            InitializeComponent();
        }

        public FormAuto(Automovil a) : this()
        {
            this.txtMarca.Text = a.Marca;
            this.txtChasis.Text = a.NChasis.ToString();
            this.txtCantRuedas.Text = a.CantidadRuedas.ToString();
            this.txtMarchas.Text = a.CantidadMarchas.ToString();
            this.cmbColor.Text = a.Color.ToString();
            //
            this.txtTipoCombustible.Text = a.TipoDeCombustible;
            this.txtCantPuertas.Text = a.CantidadDePuertas.ToString();
        }

        private void btnAcepatar_Click(object sender, EventArgs e)
        {
            if (this.QueNoHallaCamposVacios() == true) // esran llenos
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
                    long nChasis = long.Parse(this.txtChasis.Text);
                    string tipoCombustible = this.txtTipoCombustible.Text;
                    short cantPuertas = short.Parse(this.txtCantPuertas.Text);

                    this.auto = new Automovil(marca, cantRuedas, cantMarchas, color, nChasis, tipoCombustible, cantPuertas);

                    this.DialogResult = DialogResult.OK;
                }
                else {  MessageBox.Show("Por favor, verifique los demas datos.");  }
            }
            else { MessageBox.Show("Por favor, ingresa un los datos."); }
        }

        private void txtCantPuertas_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.QueSeaNumero(e);
        }
    }
}
