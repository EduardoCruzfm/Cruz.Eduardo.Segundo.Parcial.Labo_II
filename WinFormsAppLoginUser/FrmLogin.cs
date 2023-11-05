using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppLoginUser
{
    public partial class FrmLogin : Form
    {
        private List<Usuario> usuarios;

        public Usuario UsuarioDelForm { get { return this.Verificar(); } }

        public FrmLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.txtUsuario.Focus();
            this.usuarios = this.Deserializar();
        }

        /// <summary>
        /// Deserializar() Deserializa el JSON de los usuarios.
        /// </summary>
        /// <returns></returns>
        private List<Usuario> Deserializar()
        {

            try
            {
                using (StreamReader sr = new StreamReader(@"..\..\..\MOCK_DATA.json"))
                {
                    JsonSerializerOptions opciones = new JsonSerializerOptions();
                    string json_str = sr.ReadToEnd();

                    List<Usuario> users = (List<Usuario>)JsonSerializer.Deserialize(json_str, typeof(List<Usuario>));
                    return users;
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
                return new List<Usuario>();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (Verificar() != null)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Usuario no encontrado verifique sus datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Verificar() Verifica que el correo como la contaseña sean validas.
        /// </summary>
        /// <returns>Usuario validado</returns>
        private Usuario Verificar()
        {
            Usuario? usuario = null;

            foreach (Usuario item in this.usuarios)
            {
                if (item.correo == this.txtUsuario.Text && item.clave == this.txtContraseña.Text)
                {
                    usuario = item;
                    break;
                }
            }
            return usuario;
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnAceptar_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void FrmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnAceptar_Click(sender, e);
                e.Handled = true;
            }
        }

    }
}
