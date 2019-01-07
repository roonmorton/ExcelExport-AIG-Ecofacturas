using System;
using System.Windows.Forms;

namespace ExcelExport_AIG_Ecofacturas
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                iniciar();
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        private void iniciar()
        {
            try
            {
                if (!Helpers.ClsHelper.validarTexto(txtPassword.Text.ToString()))
                {
                    MessageBox.Show("Ingresar texto para validar", "Alerta",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1);
                    return;
                }
                if (Helpers.ClsHelper.validarPassword(txtPassword.Text.ToString()))
                    this.Close();
                else
                    MessageBox.Show("Contraseña Incorrecta", "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error ,
                        MessageBoxDefaultButton.Button1);
                return;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                System.Environment.Exit(1);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if((int)e.KeyChar == (int)Keys.Enter)
                {
                    iniciar();
                }
            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
