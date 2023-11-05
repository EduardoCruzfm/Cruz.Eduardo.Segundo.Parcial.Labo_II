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
    /// <summary>
    /// Formulario que muestra una lista de registros de logueo de usuarios.
    /// </summary>
    public partial class FormMostrarLogeos : Form
    {
        protected List<UsuarioLog> listUsuarioLogs;

        /// <summary>
        /// Constructor de la clase FormMostrarLogeos que inicializa un formulario vacío.
        /// </summary>
        public FormMostrarLogeos()
        {
            InitializeComponent();
            listUsuarioLogs = new List<UsuarioLog>();
        }

        /// <summary>
        /// Constructor de la clase FormMostrarLogeos que permite inicializar el formulario 
        /// con una lista de registros de logueo.
        /// </summary>
        /// <param name="lista">La lista de registros de logueo a mostrar.</param>
        public FormMostrarLogeos(List<UsuarioLog> lista) : this()
        {
            this.listUsuarioLogs = lista;
        }

        /// <summary>
        /// Maneja el evento de carga del formulario. 
        /// Actualiza el visor de registros de logueo al cargar el formulario.
        /// </summary>
        private void FormMostrarLogeos_Load(object sender, EventArgs e)
        {
            this.ActualizarVisor();
        }

        /// <summary>
        /// ActualizarVisor() Actualiza el visor de registros de logueo con la lista de registros actual.
        /// </summary>
        private void ActualizarVisor()
        {
            this.lstLog.Items.Clear();
            foreach (UsuarioLog item in this.listUsuarioLogs)
            {
                this.lstLog.Items.Add(item.ToString());
            }
        }

        /// <summary>
        /// Maneja el evento de clic en el botón "Cerrar". 
        /// Establece el resultado del diálogo como "Cancelar" al cerrar el formulario.
        /// </summary>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void lstLog_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
