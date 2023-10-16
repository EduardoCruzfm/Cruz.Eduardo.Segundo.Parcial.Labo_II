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

            this.cmbColor.SelectedIndex = 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
