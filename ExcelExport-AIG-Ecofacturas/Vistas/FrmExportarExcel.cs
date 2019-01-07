using ClosedXML.Excel;
using System;
using System.Data;
using System.Windows.Forms;

namespace ExcelExport_AIG_Ecofacturas
{
    public partial class FrmExportarExcel : Form
    {
        private string filePath = "";
        BLL.ClsVentas ventas = new BLL.ClsVentas();
        public FrmExportarExcel()
        {
            InitializeComponent();
            grdRegistros.DataSource = ventas.dtResult();
        }

        

        private void cargarExcel(string filePath)
        {
            ventas.archivo = filePath;
            if (ventas.validarArchivo())
            {
                ventas.generarRegistros();
                grdRegistros .DataSource = ventas.dtResult();
                MessageBox.Show("Terminado...", "Terminado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1);
                return;
            }
            else
            {
                MessageBox.Show("Archivo Invalido...", "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error ,
                                    MessageBoxDefaultButton.Button1);
            }            
        }

     
        private void btnProcesar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Helpers.ClsHelper.validarTexto(filePath))
                {
                    MessageBox.Show("No se a seleccionado ningun archivo", "Alerta",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1);
                    return;
                }
                
                cargarExcel(filePath );
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtResult = (DataTable)grdRegistros.DataSource;


                if (dtResult.Rows.Count < 1)
                {
                    MessageBox.Show("No hay datos para exportar", "Alerta",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Stop,
                            MessageBoxDefaultButton.Button1);
                    return;
                }
                /*
                SaveFileDialog fichero = new SaveFileDialog();
                fichero.Filter = "Excel (*.xlsx)|*.xlsx";
                string fileName = "AIG_Carga_" + DateTime.Now.Day.ToString() + "-" +
                   DateTime.Now.Month.ToString() + "-" +
                   DateTime.Now.Year.ToString();
                fichero.FileName = fileName;
                */
                // if (fichero.ShowDialog() == DialogResult.OK)
                // {

                string fileName = System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + 
                    @"\AIG_Carga_" + DateTime.Now.Day.ToString() + "-" +
                   DateTime.Now.Month.ToString() + "-" +
                   DateTime.Now.Year.ToString() + ".xlsx";
                /*MessageBox.Show("Archivo: " + fileName, "Error",
                    
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error,
                           MessageBoxDefaultButton.Button1);*/
                //return;
                if (!String.IsNullOrEmpty(fileName))
                {
                    //Exporting to Excel
                   // fileName = fichero.FileName;
                    //if (!Directory.Exists(folderPath))
                    //{
                    //    Directory.CreateDirectory(folderPath);
                    //}
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        wb.Worksheets.Add(dtResult, "AIG-Carga");
                        //wb.Worksheet("Ventas").Range(("D" + (dtResult.Rows.Count + 2).ToString())).Value = "Hello"; ;
                        wb.SaveAs(fileName);

                        if (MessageBox.Show("Archivo guardado correctamente,¿Desea abrirlo?", "Abrir Archivo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            System.Diagnostics.Process.Start(fileName);
                        }
                    }
                }else
                    MessageBox.Show("Ocurrio un error al crear el archivo", "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error ,
                            MessageBoxDefaultButton.Button1);
                //}


                /* //Exporting to Excel
                 fileName = fichero.FileName;
                 //if (!Directory.Exists(folderPath))
                 //{
                 //    Directory.CreateDirectory(folderPath);
                 //}
                 using (XLWorkbook wb = new XLWorkbook())
                 {
                     wb.Worksheets.Add(dtResult, "AIG-Carga");
                     //wb.Worksheet("Ventas").Range(("D" + (dtResult.Rows.Count + 2).ToString())).Value = "Hello"; ;
                     wb.SaveAs(fileName);

                     if (MessageBox.Show("Archivo guardado correctamente,¿Desea abrirlo?", "Abrir Archivo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                     {
                         System.Diagnostics.Process.Start(fileName);
                     }
                 }*/


            

                    /* if (fichero.ShowDialog() == DialogResult.OK)
                     {
                        if (!String.IsNullOrEmpty(fichero.FileName))
                        {

                            DataSet dt = new DataSet();
                            dt.Tables.Add(dtResult);
                            dt.WriteXml(fileName);
                            MessageBox.Show("Proceso Completado", "Exportado con exito",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information,
                                MessageBoxDefaultButton.Button1);

                             //Exporting to Excel
                             fileName = fichero.FileName;
                             //if (!Directory.Exists(folderPath))
                             //{
                             //    Directory.CreateDirectory(folderPath);
                             //}
                             using (XLWorkbook wb = new XLWorkbook())
                             {
                                 wb.Worksheets.Add(dtResult, "Carga");
                                 //wb.Worksheet("Ventas").Range(("D" + (dtResult.Rows.Count + 2).ToString())).Value = "Hello"; ;
                                 wb.SaveAs(fileName);

                                 if (MessageBox.Show("Archivo guardado correctamente,¿Desea abrirlo?", "Abrir Archivo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                                 {
                                     System.Diagnostics.Process.Start(fichero.FileName );
                                 }
                             }

                        }

                            /*Microsoft.Office.Interop.Excel.Application aplicacion;
                            Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                            Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                            aplicacion = new Microsoft.Office.Interop.Excel.Application();
                            libros_trabajo = aplicacion.Workbooks.Add();
                            hoja_trabajo = (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
                            //Recorremos el DataGridView rellenando la hoja de trabajo
                            //oja_trabajo = (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);

                            for (int i = 0; i < dtResult.Columns.Count ; i++)
                            {
                                hoja_trabajo.Cells[1, i + 1] = dtResult.Columns[i].ToString();
                            }

                            for (int i = 0; i < dtResult .Rows.Count - 1; i++)
                            {
                                for (int j = 1; j < dtResult .Columns.Count; j++)
                                {
                                    hoja_trabajo.Cells[i + 1, j + 1] = dtResult.Rows[i][j].ToString();
                                }
                            }
                            libros_trabajo.SaveAs(fichero.FileName,
                                Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                            libros_trabajo.Close(true);
                            aplicacion.Quit();
                }*/
                }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnExplorar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Libro Excel|*.xls";
                openFileDialog1.Title = "Seleccione Libro Ventas AIG";

                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    lblNombreArchivo.Text = openFileDialog1.SafeFileName;
                    lblRutaArchivo.Text = openFileDialog1.FileName;
                    filePath = openFileDialog1.FileName;
                }
                else
                {
                    lblNombreArchivo.Text = "...";
                    lblRutaArchivo.Text = "...";
                    filePath = "";
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }



}
