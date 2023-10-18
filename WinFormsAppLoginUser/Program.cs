namespace WinFormsAppLoginUser
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
            //Application.Run(new FrnPrincipal());

            FrmLogin frm = new FrmLogin();

            try
            {
                frm.ShowDialog();

                if (frm.UsuarioDelForm != null)
                {
                    FrnPrincipal frmAplicacion = new FrnPrincipal(frm.UsuarioDelForm);

                    //INICIO LA APLICACION
                    Application.Run(frmAplicacion);
                }
                else if (frm.UsuarioDelForm == null)
                {
                    frm.DialogResult = DialogResult.Cancel;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                MessageBox.Show("Gracias por usar el servicio.", "CHAU!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}