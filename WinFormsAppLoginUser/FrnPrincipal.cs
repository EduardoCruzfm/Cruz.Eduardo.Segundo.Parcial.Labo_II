using Cruz.Eduardo.Primer.Parcial.Labo_II;
using Microsoft.Win32;
using System.Globalization;
using System.Text.Json;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace WinFormsAppLoginUser
{
    /// <summary>
    /// Representa la ventana principal de la aplicación.
    /// </summary>
    public partial class FrnPrincipal : Form
    {
        protected Usuario usuario;
        protected Estacionamiento<Vehiculo> estacionamiento;
        protected List<UsuarioLog> listaDeLogeo;
        protected DateTime fechaHora;

        /// <summary>
        /// Constructor predeterminado de la clase FrnPrincipal.
        /// </summary>
        public FrnPrincipal()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.estacionamiento = new Estacionamiento<Vehiculo>("EST");
            this.listaDeLogeo = new List<UsuarioLog>();

        }

        /// <summary>
        /// Constructor de la clase FrnPrincipal que permite inicializar un usuario.
        /// </summary>
        /// <param name="usuario">El objeto de tipo Usuario que representa al usuario actual.</param>
        public FrnPrincipal(Usuario usuario) : this()
        {
            this.usuario = usuario;
            //MessageBox.Show($"Bienvenido {usuario.nombre}");
        }

        /// <summary>
        /// FrnPrincipal_Load() Maneja el evento Load de la ventana principal.
        /// Inicializando fechaHora, lblNombreUsuario y lblFecha.
        /// Agrega items al cmbTipoVehiculo.
        /// </summary>
        /// <param name="sender">El objeto que generó el evento.</param>
        /// <param name="e">El evento EventArgs.</param>
        private void FrnPrincipal_Load(object sender, EventArgs e)
        {
            this.fechaHora = DateTime.Now;
            this.lblNombreUsuario.Text = $"Usuario: {usuario.nombre}";
            this.lblFecha.Text = $"Fecha: {this.fechaHora.ToString("dd/MM/yyyy")}";

            // Agregar elementos al ComboBox
            this.cmbTipoVehiculo.Items.Add("Auto");
            this.cmbTipoVehiculo.Items.Add("Colectivo");
            this.cmbTipoVehiculo.Items.Add("Moto");

            // Establecer la selección predeterminada - Hide()
            this.SerealizarUsuario();
            this.cmbTipoVehiculo.SelectedIndex = 0;
            this.DeserializarUsuarioLog();
        }

        /// <summary>
        /// ActualizarVisor() Limpia la lista y la vuelve a cargar con los datos actualizados.
        /// </summary>
        private void ActualizarVisor()
        {
            this.lstVisor.Items.Clear();
            foreach (Vehiculo item in this.estacionamiento.listVehiculos)
            {
                this.lstVisor.Items.Add(item.ToString());
            }
        }


        /// <summary>
        /// btnAgregar_Click() Agrega un nuevo Form ala lista.
        /// Segun el tipo seleccionado gerena el objeto a agregar.
        /// </summary>
        /// <param name="sender">El objeto que generó el evento.</param>
        /// <param name="e">El evento EventArgs.</param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (this.cmbTipoVehiculo.SelectedItem != null)
            {
                string? tipo = cmbTipoVehiculo.SelectedItem.ToString();

                switch (tipo)
                {
                    case "Auto":

                        FormAuto fromA = new FormAuto();
                        fromA.ShowDialog();

                        if (fromA.DialogResult == DialogResult.OK)
                        {
                            _ = this.estacionamiento + fromA.Auto;
                            this.ActualizarVisor();
                        }
                        break;
                    case "Moto":

                        FormMoto fromM = new FormMoto();
                        fromM.ShowDialog();

                        if (fromM.DialogResult == DialogResult.OK)
                        {
                            _ = this.estacionamiento + fromM.Moto;
                            this.ActualizarVisor();
                        }
                        break;

                    case "Colectivo":

                        FormColectivo fromC = new FormColectivo();
                        fromC.ShowDialog();

                        if (fromC.DialogResult == DialogResult.OK)
                        {
                            _ = this.estacionamiento + fromC.Colctivo;
                            this.ActualizarVisor();
                        }
                        break;
                }

            }
        }

        /// <summary>
        /// Remover() elimina un vehiculo de la lista segun el indice recibido por parametro
        /// </summary>
        /// <param name="indice">Indice del Vehiculo</param>
        private void Remover(int indice)
        {
            this.estacionamiento.listVehiculos.RemoveAt(indice);
            this.ActualizarVisor();
        }


        /// <summary>
        /// btnEliminar_Click() Maneja el evento de clic en el botón "Eliminar".
        /// </summary>
        /// <param name="sender">El objeto que generó el evento.</param>
        /// <param name="e">El evento EventArgs.</param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de que deseas eliminarlo?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int indice = this.lstVisor.SelectedIndex;

                if (indice == -1) { return; }

                this.Remover(indice);
            }
        }

        /// <summary>
        /// btnModificar_Click() Permite la modificacion del vehiculo selecionado
        /// </summary>
        /// <param name="sender">El objeto que generó el evento.</param>
        /// <param name="e">El evento EventArgs.</param>
        private void btnModificar_Click(object sender, EventArgs e)
        {
            int indice = this.lstVisor.SelectedIndex;
            if (indice == -1) { return; }

            Vehiculo? v = this.estacionamiento.listVehiculos[indice];
            string? tipo = v.GetType().Name;


            switch (tipo)
            {
                case nameof(Automovil):
                    FormAuto fromA = new FormAuto((Automovil)v);
                    fromA.ShowDialog();

                    if (fromA.DialogResult == DialogResult.OK)
                    {
                        if (this.estacionamiento == fromA.Auto)
                        {
                            this.MensajeDeAtencion(v.Marca,v.NChasis);
                        }
                        else if (this.estacionamiento != fromA.Auto)
                        {
                            this.Remover(indice);
                            _= this.estacionamiento + fromA.Auto;
                        }


                        this.ActualizarVisor();
                    }

                    break;
                case nameof(Motocicleta):

                    FormMoto fromM = new FormMoto((Motocicleta)v);
                    fromM.ShowDialog();

                    if (fromM.DialogResult == DialogResult.OK)
                    {
                        if (this.estacionamiento == fromM.Moto)
                        {
                            this.MensajeDeAtencion(v.Marca, v.NChasis);
                        }
                        else if (this.estacionamiento != fromM.Moto)
                        {
                            this.Remover(indice);
                            _ = this.estacionamiento + fromM.Moto;
                        }

                        this.ActualizarVisor();
                    }

                    break;

                case nameof(Colectivo):

                    FormColectivo fromC = new FormColectivo((Colectivo)v);
                    fromC.ShowDialog();

                    if (fromC.DialogResult == DialogResult.OK)
                    {
                        if (this.estacionamiento == fromC.Colctivo)
                        {
                            this.MensajeDeAtencion(v.Marca, v.NChasis);
                        }
                        else if (this.estacionamiento != fromC.Colctivo)
                        {
                            this.Remover(indice);
                            _ = this.estacionamiento + fromC.Colctivo;
                        }

                        this.ActualizarVisor();
                    }

                    break;
            }
        }

        /// <summary>
        /// Deserializar() Determina el tipo de vehículo y deserializa según ese tipo. 
        /// </summary>
        /// <param name="path">Ruta del archivo a deserealizar</param>
        private void Deserializar(string path)
        {
            if (File.Exists(path))
            {

                using (StreamReader sr = new StreamReader(path))
                {
                    JsonSerializerOptions opciones = new JsonSerializerOptions();
                    string json_str = sr.ReadToEnd();

                    var vehiculosAnonimos = JsonSerializer.Deserialize<List<object>>(json_str);


                    foreach (var vehiculoAnonimo in vehiculosAnonimos)
                    {
                        if (vehiculoAnonimo is JsonElement elemento)
                        {

                            if (elemento.TryGetProperty("Cilindrada", out _))
                            {
                                Motocicleta? moto = JsonSerializer.Deserialize<Motocicleta>(elemento.GetRawText());
                                _ = this.estacionamiento + moto;
                            }

                            if (elemento.TryGetProperty("TipoDeCombustible", out _))
                            {
                                Automovil? auto = JsonSerializer.Deserialize<Automovil>(elemento.GetRawText());
                                _ = this.estacionamiento + auto;
                            }

                            if (elemento.TryGetProperty("EsAutomatico", out _))
                            {
                                Colectivo? colec = JsonSerializer.Deserialize<Colectivo>(elemento.GetRawText());
                                _ = this.estacionamiento + colec;
                            }
                        }
                    }
                }

                this.ActualizarVisor();
            }
        }

        /// <summary>
        /// Maneja el evento de cierre del formulario principal.
        /// </summary>
        /// <param name="sender">El objeto que generó el evento.</param>
        /// <param name="e">Argumentos del evento de cierre del formulario.</param>
        private void FrnPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de que desea salir de la aplicación?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// SerealizarUsuario() Serealiza los logueos de los usuarios ingresados
        /// </summary>
        private void SerealizarUsuario()
        {
            string? path = @"..\..\..\Usuario.log";
            using (StreamWriter sw = File.AppendText(path))
            {
                string usuarioLog = $"Fecha: {this.fechaHora.ToString("dd/MM/yyyy HH:mm:ss")} \n " +
                    $"Usuario: {usuario.nombre} \n " +
                    $"Apellido: {usuario.apellido} \n " +
                    $"Correo: {usuario.correo} \n " +
                    $"Legajo: {usuario.legajo} \n" +
                    $"Perfil: {usuario.perfil} \n";

                sw.Write(usuarioLog);
            }
        }

        /// <summary>
        /// DeserializarUsuarioLog() Deserializa los usuarios de los "Logueos" verificando el formato
        /// de los campos para concretar la tarea, agregandola a listaDeLogeo.
        /// </summary>
        private void DeserializarUsuarioLog()
        {
            string? path = @"..\..\..\Usuario.log";
            // Lista para almacenar los registros
            List<UsuarioLog> registros = new List<UsuarioLog>();

            if (File.Exists(path))
            {

                using (StreamReader reader = new StreamReader(path))
                {
                    UsuarioLog? usuarioLog = null;

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
            }

            foreach (UsuarioLog u in registros)
            {
                this.listaDeLogeo.Add(u);
            }
        }

        /// <summary>
        /// Serealizar() Serealiza un archivo en formato JSON, pero antes verifica
        /// de que tipo clase derivada del padre es.
        /// </summary>
        /// <param name="path">Ruta donde se guardara el archivo</param>
        private void Serealizar(string path)
        {
            string objJson;

            List<string> objetosSerializados = new List<string>();

            JsonSerializerOptions opciones = new JsonSerializerOptions();
            opciones.WriteIndented = true;


            foreach (var item in this.estacionamiento.listVehiculos)
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

        /// <summary>
        /// NuevaListaOrdenada() se usa para guardar un nuevo ordanamiento segun criterio.
        /// </summary>
        /// <returns>Un objeto de tipo Estacionamiento</returns>
        private Estacionamiento<Vehiculo> NuevaListaOrdenada()
        {
            Estacionamiento<Vehiculo> es = new Estacionamiento<Vehiculo>("ES_ORDENADO");

            foreach (var v in this.estacionamiento.listVehiculos)
            {
                _ = es + v;
            }
            return es;
        }

        /// <summary>
        /// AgregarNuevaListaOrdenada() Limpia la lista actual, cargandola con los elementos ordenados
        /// segun criterio.
        /// </summary>
        /// <param name="est"></param>
        private void AgregarNuevaListaOrdenada(Estacionamiento<Vehiculo> est)
        {
            this.estacionamiento.listVehiculos.Clear();

            foreach (var item in est.listVehiculos)
            {
                _ = this.estacionamiento + item;
            }
            this.ActualizarVisor();
        }


        /// <summary>
        /// btnOrdenar_Click() Ordenda la lista por N° Chasis / Cantidad de ruedas.
        /// </summary>
        /// <param name="sender">El objeto que generó el evento.</param>
        /// <param name="e">El evento.</param>
        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            if (rdNChasis.Checked)
            {
                Estacionamiento<Vehiculo> estC = NuevaListaOrdenada();

                if (rdAsendente.Checked)
                {
                    estC.Ordenar("chasis");
                }
                else if (rdDesendente.Checked)
                {
                    estC.Ordenar("chasis");
                    estC.listVehiculos.Reverse();
                }
                this.AgregarNuevaListaOrdenada(estC);

            }
            else if (rdCantRuedas.Checked)
            {
                Estacionamiento<Vehiculo> estR = NuevaListaOrdenada();

                if (rdAsendente.Checked)
                {
                    estR.Ordenar("ruedas");
                }
                else if (rdDesendente.Checked)
                {
                    estR.Ordenar("ruedas");
                    estR.listVehiculos.Reverse();
                }

                this.AgregarNuevaListaOrdenada(estR);
            }
        }

        /// <summary>
        /// btnHistorialLog_Click() Muestra el Form de logueos registrados
        /// </summary>
        /// <param name="sender">El objeto que generó el evento.</param>
        /// <param name="e">El evento.</param>
        private void btnHistorialLog_Click(object sender, EventArgs e)
        {
            //this.DeserializarUsuarioLog();
            FormMostrarLogeos uLog = new FormMostrarLogeos(this.listaDeLogeo);
            uLog.ShowDialog();
        }

        /// <summary>
        /// btnAbrir_Click() Abre la interaccion con openFileDialog para poder 
        /// elegir que archivo deserializar.
        /// </summary> 
        /// <param name="sender">El objeto que generó el evento.</param>
        /// <param name="e">El evento.</param>
        private void btnAbrir_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog1.Title = "Busca tu archivo";
                this.openFileDialog1.ShowDialog();
                string ruta = this.openFileDialog1.FileName;

                this.Deserializar(ruta);

                this.txtDirecion.Text = ruta;
            }
            catch (Exception)
            {
                _ = MessageBox.Show($"Se a producido un error, archivo no compatible", "Error al abrir archivo", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK;

            }

        }

        /// <summary>
        /// btnGuardar_Click() Abre la interaccion con saveFileDialog para poder 
        /// elegir donde serializar el archivo.
        /// </summary>
        /// <param name="sender">El objeto que generó el evento.</param>
        /// <param name="e">El evento.</param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string ruta = this.saveFileDialog1.FileName;
                    this.Serealizar(ruta);
                    this.txtDirecion.Text = ruta;
                }

            }
            catch (Exception)
            {
                _ = MessageBox.Show($"Se a producido un error al guardar el archivo", "Error al guardar archivo", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK;
            }
        }

        /// <summary>
        /// MensajeDeAtencion() Muestra un mensaje de atención indicando que los datos ya existen en el registro.
        /// </summary>
        /// <param name="marca">La marca de un vehículo.</param>
        /// <param name="nChasis">El número de chasis del vehículo.</param>
        private void MensajeDeAtencion(string marca, string nChasis)
        {
            _ = MessageBox.Show($"Los datos Marca: {marca} y de N° de chasis: {nChasis} ya existe en el registro", "Datos existentes", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK;

        }
    }
}