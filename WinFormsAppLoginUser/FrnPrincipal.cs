using Cruz.Eduardo.Primer.Parcial.Labo_II;
using System.Windows.Forms;

namespace WinFormsAppLoginUser
{
    public partial class FrnPrincipal : Form
    {
        protected Usuario usuario;
        protected List<Vehiculo> listaVehiculos;

        public FrnPrincipal()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.listaVehiculos = new List<Vehiculo>();

        }

        public FrnPrincipal(Usuario usuario) : this()
        {
            this.usuario = usuario;
            MessageBox.Show($"Bienvenido {usuario.nombre}");
        }

        private void FrnPrincipal_Load(object sender, EventArgs e)
        {
            this.lblNombreUsuario.Text = $"Usuario: {usuario.nombre} Fecha: {DateTime.Now}";

            // Agregar elementos al ComboBox
            this.cmbTipoVehiculo.Items.Add("Auto");
            this.cmbTipoVehiculo.Items.Add("Colectivo");
            this.cmbTipoVehiculo.Items.Add("Moto");

            // Establecer la selección predeterminada
            this.cmbTipoVehiculo.SelectedIndex = 0;
        }

        private void ActualizarVisor()
        {
            this.lstVisor.Items.Clear();
            foreach (Vehiculo item in this.listaVehiculos)
            {
                this.lstVisor.Items.Add(item.ToString());
            }
        }




        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (this.cmbTipoVehiculo.SelectedItem != null)
            {
                string tipo = cmbTipoVehiculo.SelectedItem.ToString();

                switch (tipo)
                {
                    case "Auto":

                        FormAuto fromA = new FormAuto();
                        fromA.ShowDialog();

                        if (fromA.DialogResult == DialogResult.OK)
                        {
                            this.listaVehiculos.Add(fromA.Auto);
                            this.ActualizarVisor();
                        }
                        break;
                    case "Moto":

                        FormMoto fromM = new FormMoto();
                        fromM.ShowDialog();

                        if (fromM.DialogResult == DialogResult.OK)
                        {
                            this.listaVehiculos.Add(fromM.Moto);
                            this.ActualizarVisor();
                        }
                        break;

                    case "Colectivo":

                        FormColectivo formC = new FormColectivo();
                        formC.ShowDialog();

                        if (formC.DialogResult == DialogResult.OK)
                        {
                            this.listaVehiculos.Add(formC.Colctivo);
                            this.ActualizarVisor();
                        }
                        break;
                }

            }
        }

        private void Remover(int indice)
        {
            this.listaVehiculos.RemoveAt(indice);
            this.ActualizarVisor();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int indice = this.lstVisor.SelectedIndex;

            if (indice == -1) { return; }

            this.Remover(indice);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int indice = this.lstVisor.SelectedIndex;

            if (indice == -1) { return; }

            Vehiculo v = this.listaVehiculos[indice];

            

            string tipo = cmbTipoVehiculo.SelectedItem.ToString();

            
            switch (tipo)
            {
                case "Auto":
                    FormAuto fromA = new FormAuto((Automovil)v);
                    fromA.ShowDialog();

                    if (fromA.DialogResult == DialogResult.OK) {

                        this.listaVehiculos[indice] = fromA.Auto;
                        this.ActualizarVisor();
                    }

                    break;
                case "Moto":

                    FormMoto fromM = new FormMoto((Motocicleta)v);
                    fromM.ShowDialog();

                    if (fromM.DialogResult == DialogResult.OK) 
                    {
                        this.listaVehiculos[indice] = fromM.Moto;
                        this.ActualizarVisor();
                    }

                    break;

                case "Colectivo":

                    FormColectivo fromC = new FormColectivo((Colectivo)v);
                    fromC.ShowDialog();

                    if (fromC.DialogResult == DialogResult.OK) 
                    {
                        this.listaVehiculos[indice] = fromC.Colctivo;
                        this.ActualizarVisor();
                    }

                    break;
            }
        }
    }
}