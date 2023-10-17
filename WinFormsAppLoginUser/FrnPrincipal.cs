using Cruz.Eduardo.Primer.Parcial.Labo_II;
using Microsoft.Win32;
using System.Globalization;
using System.Text.Json;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace WinFormsAppLoginUser
{
    public partial class FrnPrincipal : Form
    {
        protected Usuario usuario;
        protected List<Vehiculo> listaVehiculos;
        protected List<UsuarioLog> listaDeLogeo;
        protected DateTime fechaHora;

        public FrnPrincipal()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.listaVehiculos = new List<Vehiculo>();
            this.listaDeLogeo = new List<UsuarioLog>();

        }

        public FrnPrincipal(Usuario usuario) : this()
        {
            this.usuario = usuario;
            MessageBox.Show($"Bienvenido {usuario.nombre}");
        }

        private void FrnPrincipal_Load(object sender, EventArgs e)
        {
            fechaHora = DateTime.Now;
            this.lblNombreUsuario.Text = $"Usuario: {usuario.nombre}";
            this.lblFecha.Text = $"Fecha: {fechaHora.ToString("dd/mm/yyyy")}";
            // Agregar elementos al ComboBox
            this.cmbTipoVehiculo.Items.Add("Auto");
            this.cmbTipoVehiculo.Items.Add("Colectivo");
            this.cmbTipoVehiculo.Items.Add("Moto");

            // Establecer la selección predeterminada
            this.cmbTipoVehiculo.SelectedIndex = 0;

            this.Deserializar();
            this.DerealizarUsuarioLog();
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
            MessageBox.Show("Se elimino");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int indice = this.lstVisor.SelectedIndex;

            if (indice == -1) { return; }

            Vehiculo v = this.listaVehiculos[indice];



            string tipo = v.GetType().Name;


            switch (tipo)
            {
                case nameof(Automovil):
                    FormAuto fromA = new FormAuto((Automovil)v);
                    fromA.ShowDialog();

                    if (fromA.DialogResult == DialogResult.OK)
                    {

                        this.listaVehiculos[indice] = fromA.Auto;
                        this.ActualizarVisor();
                    }

                    break;
                case nameof(Motocicleta):

                    FormMoto fromM = new FormMoto((Motocicleta)v);
                    fromM.ShowDialog();

                    if (fromM.DialogResult == DialogResult.OK)
                    {
                        this.listaVehiculos[indice] = fromM.Moto;
                        this.ActualizarVisor();
                    }

                    break;

                case nameof(Colectivo):

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

        private void Deserializar()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path += @"\List_vehiculos.json";

            List<Vehiculo> listaDatoJson;

            if (File.Exists(path))
            {

                using (StreamReader sr = new StreamReader(path))
                {
                    JsonSerializerOptions opciones = new JsonSerializerOptions();
                    string json_str = sr.ReadToEnd();

                    // Deserializar en una lista de objetos anónimos
                    var vehiculosAnonimos = JsonSerializer.Deserialize<List<object>>(json_str);

                    listaVehiculos = new List<Vehiculo>();

                    foreach (var vehiculoAnonimo in vehiculosAnonimos)
                    {
                        if (vehiculoAnonimo is JsonElement elemento)
                        {
                            // Determina el tipo de vehículo y deserializa según ese tipo.
                            if (elemento.TryGetProperty("Cilindrada", out _))
                            {
                                Motocicleta moto = JsonSerializer.Deserialize<Motocicleta>(elemento.GetRawText());
                                this.listaVehiculos.Add(moto);
                            }

                            if (elemento.TryGetProperty("TipoDeCombustible", out _))
                            {
                                Automovil auto = JsonSerializer.Deserialize<Automovil>(elemento.GetRawText());
                                this.listaVehiculos.Add(auto);
                            }

                            if (elemento.TryGetProperty("EsAutomatico", out _))
                            {
                                Colectivo colec = JsonSerializer.Deserialize<Colectivo>(elemento.GetRawText());
                                this.listaVehiculos.Add(colec);
                            }

                        }
                    }
                }
                this.ActualizarVisor();

            }
        }

        private void FrnPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Serealizar();
            this.SerealizarUsuario();

        }

        private void SerealizarUsuario()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path += @"\Usuario.log";


            using (StreamWriter sw = File.AppendText(path))
            {
                string usuarioLog = $"Fecha: {this.fechaHora} \n " +
                    $"Usuario: {usuario.nombre} \n " +
                    $"Apellido: {usuario.apellido} \n " +
                    $"Correo: {usuario.correo} \n " +
                    $"Legajo: {usuario.legajo} \n" +
                    $"Perfil: {usuario.perfil} \n";

                sw.Write(usuarioLog);
            }
        }

        private void DerealizarUsuarioLog()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path += @"\Usuario.log";

            // Lista para almacenar los registros
            List<UsuarioLog> registros = new List<UsuarioLog>();

            using (StreamReader reader = new StreamReader(path))
            {
                UsuarioLog usuarioLog = null;

                foreach (string line in reader.ReadToEnd().Split('\n'))
                {
                    if (line.StartsWith("Fecha:"))
                    {
                        usuarioLog = new UsuarioLog();
                        registros.Add(usuarioLog);

                        if (DateTime.TryParseExact(line.Substring(7).Trim(), "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime fecha))
                        {
                            usuarioLog.Fecha = fecha;
                        }
                    }
                    else if (usuarioLog != null)
                    {
                        if (line.StartsWith(" Usuario:"))
                        {
                            usuarioLog.nombre = line.Substring(10).Trim();
                        }
                        else if (line.StartsWith(" Apellido:"))
                        {
                            usuarioLog.apellido = line.Substring(11).Trim();
                        }
                        else if (line.StartsWith(" Correo:"))
                        {
                            usuarioLog.correo = line.Substring(9).Trim();
                        }
                        else if (line.StartsWith(" Legajo:"))
                        {
                            if (int.TryParse(line.Substring(8).Trim(), out int legajo))
                            {
                                usuarioLog.legajo = legajo;
                            }
                        }
                        else if (line.StartsWith("Perfil:"))
                        {
                            usuarioLog.perfil = line.Substring(8).Trim();
                        }
                    }
                }
            }

            foreach (UsuarioLog u in registros)
            {
                this.listaDeLogeo.Add(u);
            }
        }

        private void Serealizar()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path += @"\List_vehiculos.json";

            string objJson;

            List<string> objetosSerializados = new List<string>();

            JsonSerializerOptions opciones = new JsonSerializerOptions();
            opciones.WriteIndented = true;


            foreach (var item in this.listaVehiculos)
            {
                var tipo = item.GetType();

                switch (tipo.Name)
                {
                    case nameof(Motocicleta):

                        objJson = JsonSerializer.Serialize((Motocicleta)item, opciones);
                        objetosSerializados.Add(objJson);

                        break;

                    case nameof(Automovil):

                        objJson = JsonSerializer.Serialize((Automovil)item, opciones);
                        objetosSerializados.Add(objJson);
                        break;

                    case nameof(Colectivo):

                        objJson = JsonSerializer.Serialize((Colectivo)item, opciones);
                        objetosSerializados.Add(objJson);
                        break;
                }
            }

            string jsonArray = "[" + string.Join(",", objetosSerializados) + "]";

            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(jsonArray);
            }
        }

        private Estacionamiento NuevaLista()
        {
            Estacionamiento es = new Estacionamiento("ES_ORDENADO");

            foreach (var v in this.listaVehiculos)
            {
                _ = es + v;
            }
            return es;
        }

        private void AgregarNuevaLista(Estacionamiento est)
        {
            this.listaVehiculos.Clear();

            foreach (var item in est.listVehiculos)
            {
                this.listaVehiculos.Add(item);
            }
            this.ActualizarVisor();
        }


        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            if (rdNChasis.Checked)
            {
                Estacionamiento estC = NuevaLista();

                if (rdAsendente.Checked)
                {
                    estC.Ordenar("chasis");
                }
                else if (rdDesendente.Checked)
                {
                    estC.Ordenar("chasis");
                    estC.listVehiculos.Reverse();
                }
                this.AgregarNuevaLista(estC);

            }
            else if (rdCantRuedas.Checked)
            {
                Estacionamiento estR = NuevaLista();

                if (rdAsendente.Checked)
                {
                    estR.Ordenar("ruedas");
                }
                else if (rdDesendente.Checked)
                {
                    estR.Ordenar("ruedas");
                    estR.listVehiculos.Reverse();
                }

                this.AgregarNuevaLista(estR);
            }
        }

        private void btnHistorialLog_Click(object sender, EventArgs e)
        {
            FormMostrarLogeos uLog = new FormMostrarLogeos(this.listaDeLogeo);
            uLog.ShowDialog();
        }
    }
}