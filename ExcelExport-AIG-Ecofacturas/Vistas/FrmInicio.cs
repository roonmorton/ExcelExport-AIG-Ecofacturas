using System;
using System.Windows.Forms;

namespace ExcelExport_AIG_Ecofacturas
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
            if (!BE.ClsGlobals.validarUsuario())
            {
                FrmLogin login = new FrmLogin();
                login.ShowDialog(this);
            }
            if (!BE.ClsGlobals.validarUsuario())
            {
                System.Environment.Exit(1);
            }
        }

        private void btnExportar_Click(object sender, System.EventArgs e)
        {
            try
            {
                new FrmExportarExcel().ShowDialog(this);
            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
