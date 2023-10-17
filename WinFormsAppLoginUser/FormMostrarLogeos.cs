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
    public partial class FormMostrarLogeos : Form
    {
        protected List<UsuarioLog> listUsuarioLogs;

        public FormMostrarLogeos()
        {
            InitializeComponent();
            listUsuarioLogs = new List<UsuarioLog>();
        }

        public FormMostrarLogeos(List<UsuarioLog> lista) : this()
        {
            this.listUsuarioLogs = lista;
        }

        private void FormMostrarLogeos_Load(object sender, EventArgs e)
        {
            this.ActualizarVisor();
        }
        private void ActualizarVisor()
        {
            this.lstLog.Items.Clear();
            foreach (UsuarioLog item in this.listUsuarioLogs)
            {
                this.lstLog.Items.Add(item.ToString());
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
