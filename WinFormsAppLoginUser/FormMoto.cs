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
    public partial class FormMoto : FormVehiculo
    {
        protected Motocicleta moto;

        public Motocicleta Moto { get { return this.moto; } }

        public FormMoto() : base()
        {
            InitializeComponent();
            this.cmbUsoUrbano.Items.Add("Si");
            this.cmbUsoUrbano.Items.Add("No");
        }

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
            this.cmbUsoUrbano.SelectedIndex = 0;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (this.QueNoHallaCamposVacios() == true) // esran llenos
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
            else { MessageBox.Show("Por favor, ingresa un los datos."); }
        }

        private void txtCilindrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.QueSeaNumero(e);
        }
    }
}
