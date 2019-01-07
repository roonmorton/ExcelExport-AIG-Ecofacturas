using System;
using System.Data;
using System.Windows.Forms;

namespace ExcelExport_AIG_Ecofacturas.BLL
{
    class ClsVentas
    {
        string[] cols =
        {
            "Docto",
            "Serie",
            "Disp. Electronico",
            "Año Emisión",
            "Correlativo",
            "fecha",
            "NIT Beneficiario",
            "Observación",
            "Moneda",
            "Tasa de Cambio",
            "Código Artículo",
            "Nombre Artículo",
            "Unidad Medida",
            "Valor Unitario",
            "Cantidad",
            "Descuento",
            "Bien o Servicio",
            "Excento",
            "E-Mail's",
            "Resolución de Documento a Anular",
            "Tipo de Transacción de Documento a Anular FACE",
            "Serie de Documento a Anular",
            "Dispositivo electronico de Documento a Anular",
            "Año del Documento a Anular",
            "Numero de Documento a Anular",
            "Pais Destino",
            "Estado",
            "ClienteCodigo",
            "ClienteNombre",
            "ClienteDireccion"
        };

        private DataTable data;
        public string archivo{ get; set; }

        
        public ClsVentas(string archivo = "")
        {
            try
            {
                this.archivo = archivo;
                this.data = new DataTable();
                foreach(string colName in cols)
                    this.data.Columns.Add(colName);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public DataTable dtResult()
        {
            try
            {
                return this.data;
            }catch(Exception e)
            {
                throw e;
            }
        }

        public void generarRegistros()
        {
            try
            {
                ClsExcel excel = new ClsExcel(archivo);
                excel.abrir();
                DataTable dt = excel.obtenerHoja(0);
                foreach(DataRow r in dt.Rows)
                {
                    add(r);
                }
                excel.cerrar();

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }


        public Boolean validarArchivo()
        {
            try
            {
                ClsExcel excel = new ClsExcel(archivo);
                excel.abrir();
                DataTable dt = excel.obtenerHoja(0);
                DataRow RowE = dt.Rows[0];
               // MessageBox.Show("Row 0: " + RowE[0].ToString());
                if ( 
                    RowE[0].ToString().Trim().Equals("Fecha") &&
                    RowE[1].ToString().Trim().Equals("Serie") &&
                    RowE[2].ToString().Trim().Equals("Número") &&
                    RowE[3].ToString().Trim().Equals("Nit") &&
                    RowE[4].ToString().Trim().Equals("Nombre") &&
                    RowE[5].ToString().Trim().Equals("Admón") &&
                    RowE[6].ToString().Trim().Equals("Intereses") &&
                    RowE[7].ToString().Trim().Equals("Mora") &&
                    RowE[8].ToString().Trim().Equals("Mora <0") &&
                    RowE[9].ToString().Trim().Equals("Reserva") &&
                    RowE[10].ToString().Trim().Equals("Gastos Funerarios") &&
                    RowE[11].ToString().Trim().Equals("Gastos Saldos Insolutos")
                    )
                {
                    excel.cerrar();
                    return true;
                } 
                return false;
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public void add(DataRow rowAIG)
        {
            try
            {
                DateTime fecha;
                Double admin = 0.00;
                Double intereses = 0.00;
                Double interesesMora = 0.00;
                Double interesesMora0 = 0.00;
                Double reserva = 0.00;
                Double gastosInsolutos = 0.00;
                Double gastosFunerarios = 0.00;
                Double total = 0.00;

                if (DateTime.TryParse(rowAIG[0].ToString().Trim(), out fecha))
                {
                    BE.ClsVenta venta = new BE.ClsVenta();

                    venta.Docto = "CFACE-1";
                    venta.DispElectronico = "001";
                    venta.AnioEmision = 0;
                    venta.Moneda = "GTQ";
                    venta.TasadeCambio = 1;
                    venta.CodigoArticulo = 1;
                    venta.UnidadMedida = "UNIDAD";
                    venta.Cantidad = 1;
                    venta.Descuento = 0;
                    venta.BienOServicio = 1; //0 = Bien o 1 = servicio
                    venta.Excento = 0;

                    venta.fecha = DateTime.Parse(rowAIG[0].ToString().Trim()).ToString("dd/MM/yyyy");
                    venta.Serie = rowAIG[1].ToString();
                    venta.Correlativo = int.Parse(rowAIG[2].ToString().Trim());

                    if (rowAIG[3].ToString().Equals(""))
                        venta.NITBeneficiario = "C/F";
                    else
                        venta.NITBeneficiario  = rowAIG[3].ToString();
                    venta.ClienteNombre = rowAIG[4].ToString();
                    //MessageBox.Show("valor: " + rowAIG[5].ToString().Trim());
                    admin = rowAIG[5].ToString().Equals("") ? 0 : Double.Parse(rowAIG[5].ToString()) ;
                    admin += (admin * 0.12);

                    intereses = rowAIG[6].ToString().Equals("") ? 0 : Double.Parse(rowAIG[6].ToString());
                    intereses += (intereses * 0.12);

                    interesesMora = rowAIG[7].ToString().Equals("") ? 0 : Double.Parse(rowAIG[7].ToString());
                    interesesMora += (interesesMora * 0.12);

                    interesesMora0 = rowAIG[8].ToString().Equals("") ? 0 : Double.Parse(rowAIG[8].ToString());
                    interesesMora0 += (interesesMora0 * 0.12);

                    reserva = rowAIG[9].ToString().Equals("") ? 0 : Double.Parse(rowAIG[9].ToString());
                    reserva += (reserva * 0.12);

                    gastosFunerarios = rowAIG[10].ToString().Equals("") ? 0 : Double.Parse(rowAIG[10].ToString());
                    gastosFunerarios += (gastosFunerarios * 0.12);

                    gastosInsolutos = rowAIG[11].ToString().Equals("") ? 0 : Double.Parse(rowAIG[11].ToString());
                    gastosInsolutos += (gastosInsolutos * 0.12);




                    /*intereses = Double.Parse(rowAIG[6].ToString().Trim());
                    intereses  = intereses + (intereses * 0.12 );
                    interesesMora = Double.Parse(rowAIG[7].ToString().Trim()) +Double.Parse(rowAIG[7].ToString().Trim()) * 0.12;
                    interesesMora0  = Double.Parse(rowAIG[8].ToString().Trim()) + Double.Parse(rowAIG[8].ToString().Trim()) * 0.12;
                    reserva = Double.Parse(rowAIG[9].ToString().Trim()) + Double.Parse(rowAIG[9].ToString().Trim()) * 0.12;
                    gastosFunerarios  = Double.Parse(rowAIG[10].ToString().Trim()) + Double.Parse(rowAIG[10].ToString().Trim()) * 0.12;
                    gastosInsolutos = Double.Parse(rowAIG[11].ToString().Trim()) + Double.Parse(rowAIG[11].ToString().Trim()) * 0.12;
                    
    */
                    total = admin + intereses + interesesMora + interesesMora0 + reserva   + gastosFunerarios + gastosInsolutos;

                    if(total == 0)
                    {
                        venta.NombreArticulo = "COMISION";
                        venta.ValorUnitario = 0.00;
                        venta.Estado = "A";
                        if(rowAIG[4].ToString().Equals(""))
                            venta.ClienteNombre = "ANULADO";
                        addFila(venta);
                    }
                    else
                    {
                        venta.Estado = "E";

                        if (admin > 0)
                        {
                            venta.NombreArticulo = "COMISION";
                            venta.ValorUnitario = Math.Round(admin, 2);
                            addFila(venta);
                        }
                        if(intereses > 0)
                        {
                            venta.NombreArticulo = "INTERESES";
                            venta.ValorUnitario = Math.Round(intereses , 2);
                            addFila(venta);
                        }
                        if (interesesMora > 0)
                        {
                            venta.NombreArticulo = "INTERESES MORATORIOS";
                            venta.ValorUnitario = Math.Round(interesesMora , 2);
                            addFila(venta);
                        }
                        if (interesesMora0 > 0)
                        {
                            venta.NombreArticulo = "CUOTA ADMINISTRATIVA";
                            venta.ValorUnitario = Math.Round(interesesMora0 , 2);
                            addFila(venta);
                            
                        }
                        if (reserva > 0)
                        {
                            venta.NombreArticulo = "COMISION POR OTORGAMIENTO";
                            venta.ValorUnitario = Math.Round(reserva , 2);
                            addFila(venta);
                        }
                        if (gastosFunerarios > 0)
                        {
                            venta.NombreArticulo = "GASTOS FUNERALES";
                            venta.ValorUnitario = Math.Round(gastosFunerarios , 2);
                            addFila(venta);
                        }
                        if (gastosInsolutos  > 0)
                        {
                            venta.NombreArticulo = "SEGURO DE SALDOS INSOLUTOS";
                            venta.ValorUnitario = Math.Round(gastosInsolutos , 2);
                            addFila(venta);
                            
                        }


                    }


                }
                

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void addFila(BE.ClsVenta venta)
        {
            try
            {
                DataRow dr = data.NewRow();
                int i = 0;
                foreach (var _property in venta.GetType().GetProperties())
                {
                    

                    var prop = venta.GetType().GetProperty(_property.Name);
                    dr[i] = prop.GetValue(venta,null);

                    //prop.SetValue(_material, prop.GetValue(_material, null).ToString().ToUpper());
                    i++;
                }
                data.Rows.Add(dr);

            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
