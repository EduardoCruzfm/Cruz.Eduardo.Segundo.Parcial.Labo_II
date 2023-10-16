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

        public FormMoto() :base()
        {
            InitializeComponent();
            this.cmbUsoUrbano.Items.Add("Si");
            this.cmbUsoUrbano.Items.Add("No");
        }

        public FormMoto(Motocicleta m) : this()
        {
            this.txtMarca.Text = m.Marca;
            this.txtChasis.Text = m.NChasis.ToString();
            this.txtCantRuedas.Text = m.CantidadRuedas.ToString();
            this.txtMarchas.Text = m.CantidadMarchas.ToString();
            this.cmbColor.Text = m.Color.ToString();
            
            this.cmbUsoUrbano.Text = m.Urbano.ToString();
            this.txtCilindrada.Text = m.Cilindrada.ToString();
        }

        private void FormMoto_Load(object sender, EventArgs e) 
        {
            // Establecer la selección predeterminada
            this.cmbUsoUrbano.SelectedIndex = 0;
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string marca = this.txtMarca.Text;
            long nChasis = long.Parse(this.txtChasis.Text);
            short cantRuedas = short.Parse(this.txtCantRuedas.Text);
            short cantMarchas = short.Parse(this.txtMarchas.Text);

            Colores color = (Colores)Enum.Parse(typeof(Colores), this.cmbColor.Text);

            short cilindrada = short.Parse(this.txtCilindrada.Text);
            string usoUrbano = this.cmbUsoUrbano.Text;


            this.moto = new Motocicleta(marca, cantRuedas, cantMarchas, color, nChasis, cilindrada, usoUrbano);
            this.DialogResult = DialogResult.OK;

        }
    }
}
