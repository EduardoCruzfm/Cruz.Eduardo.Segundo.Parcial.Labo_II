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
            string marca = this.txtMarca.Text;
            long nChasis = long.Parse(this.txtChasis.Text);
            short cantRuedas = short.Parse(this.txtCantRuedas.Text);
            short cantMarchas = short.Parse(this.txtMarchas.Text);
            Colores color = (Colores)this.cmbColor.SelectedItem;
            string tipoCombustible = this.txtTipoCombustible.Text;
            short cantPuertas = short.Parse(this.txtCantPuertas.Text);

            this.auto = new Automovil(marca, cantRuedas, cantMarchas, color, nChasis, tipoCombustible, cantPuertas);

            this.DialogResult = DialogResult.OK;

        }
    }
}
