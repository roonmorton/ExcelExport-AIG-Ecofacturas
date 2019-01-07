using ExcelDataReader;
using System;
using System.Data;
using System.IO;

namespace ExcelExport_AIG_Ecofacturas.BLL
{
    class ClsExcel
    {
        private string filePath;
        //private DataTable table;
        private DataSet result;
        private FileStream stream;
        
        public ClsExcel(string filePath)
        {
            try
            {
                this.filePath = filePath;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void cerrar()
        {
            try
            {
                stream.Close();
            }catch(Exception e)
            {
                throw e;
            }
        }

        public void abrir()
        {
            try
            {
                stream = File.Open(filePath, FileMode.Open, FileAccess.Read);
                var reader = ExcelReaderFactory.CreateReader(stream);
                result = reader.AsDataSet();
            }
            catch(Exception e)
            {
                throw e;
            }

        }

       /* private void s()
        {
            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                   var result = reader.AsDataSet();
                    
                    DataTable table = result.Tables[0];
                    //dataGridView1.DataSource = table;
                }
            }
        }*/

        public DataTable obtenerHoja(int noHoja = 0)
        {
            try
            {
                return result.Tables[noHoja];
            }catch(Exception  e)
            {
                throw e;
            }
        }
    }
}
