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
    public partial class FormColectivo : FormVehiculo
    {
        protected Colectivo colctivo;

        public Colectivo Colctivo { get { return this.colctivo; } }

        public FormColectivo()
        {
            InitializeComponent();
            this.cmbTransAutomatica.Items.Add("Si");
            this.cmbTransAutomatica.Items.Add("No");
        }

        public FormColectivo(Colectivo c) : this()
        {
            this.txtMarca.Text = c.Marca;
            this.txtChasis.Text = c.NChasis.ToString();
            this.txtCantRuedas.Text = c.CantidadRuedas.ToString();
            this.txtMarchas.Text = c.CantidadMarchas.ToString();
            this.cmbColor.Text = c.Color.ToString();
            this.cmbTransAutomatica.Text = c.EsAutomatico;
            this.txtCantPasajeros.Text = c.CantidadDePasajeros.ToString();
        }

        private void FormColectivo_Load(object sender, EventArgs e)
        {
            this.cmbTransAutomatica.SelectedIndex = 0;

        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string marca = this.txtMarca.Text;
            long nChasis = long.Parse(this.txtChasis.Text);
            short cantRuedas = short.Parse(this.txtCantRuedas.Text);
            short cantMarchas = short.Parse(this.txtMarchas.Text);
            Colores color = (Colores)this.cmbColor.SelectedItem;
            string esAutomatico = this.cmbTransAutomatica.Text;
            int cantPasajeros = int.Parse(this.txtCantPasajeros.Text);

            this.colctivo = new Colectivo(marca, cantRuedas, cantMarchas, color, nChasis, esAutomatico, cantPasajeros);
            this.DialogResult = DialogResult.OK;
        }


    }
}
