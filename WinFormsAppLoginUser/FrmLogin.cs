using Biblioteca_Exepciones;
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
    /// <summary>
    /// Formulario de inicio de sesión que permite a los usuarios ingresar al sistema.
    /// </summary>
    public partial class FrmLogin : Form
    {
        private List<Usuario> usuarios;
        private int cantidadIntentos = 0;

        /// <summary>
        /// Obtiene el usuario validado por el formulario de inicio de sesión.
        /// </summary>
        public Usuario UsuarioDelForm { get { return this.Verificar(); } }

        /// <summary>
        /// Constructor de la clase FrmLogin. 
        /// Inicializa el formulario y carga la lista de usuarios desde un archivo JSON.
        /// </summary>
        public FrmLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.txtUsuario.Focus();
            this.usuarios = this.Deserializar();
        }

        /// <summary>
        /// Deserializar() Deserializa los datos de usuarios desde un archivo JSON.
        /// </summary>
        /// <returns>Una lista de usuarios deserializados.</returns>
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

        /// <summary>
        /// Maneja el evento de clic en el botón "Aceptar". Verifica las credenciales ingresadas por el usuario.
        /// Si las credenciales son válidas, establece el resultado del diálogo como "Aceptar".
        /// En caso contrario, muestra un mensaje de error.
        /// </summary>
        /// <param name="sender">El objeto que generó el evento (el botón "Aceptar").</param>
        /// <param name="e">El evento EventArgs.</param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            

            if (Verificar() != null)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.cantidadIntentos++;
                MessageBox.Show("Usuario no encontrado verifique sus datos", "Datos invalidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (this.cantidadIntentos == 3)
            {
                throw new IntereaccionesSuperadasException(this.txtUsuario.Text);

            }
        }

        /// <summary>
        /// Verificar() si el correo y la contraseña ingresados son válidos comparándolos con la lista de usuarios.
        /// </summary>
        /// <returns>El usuario validado o null si las credenciales son inválidas.</returns>
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

        /// <summary>
        /// Maneja el evento de clic en el botón "Cancelar".
        /// Establece el resultado del diálogo como "Cancelar".
        /// </summary>
        /// <param name="sender">El objeto que generó el evento (el botón "Cancelar").</param>
        /// <param name="e">El evento.</param>

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Está seguro de que deseas cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;

            }
        }


        private void btnAceptar_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        /// <summary>
        /// Maneja el evento de presionar una tecla en el formulario principal. 
        /// Permite que se haga clic en "Aceptar" al presionar la tecla Enter.
        /// </summary>
        /// <param name="sender">El objeto que generó el evento (el formulario principal).</param>
        /// <param name="e">El evento KeyPressEventArgs.</param>
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
