using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ExcelExport_AIG_Ecofacturas.BE
{
    class ClsVenta
    {
        public string Docto { get; set; }
        public string Serie { get; set; }
        public string DispElectronico { get; set; }
        public int AnioEmision { get; set; }
        public int Correlativo { get; set; }
        public string fecha { get; set; }
        public string NITBeneficiario { get; set; }
        public string Observación { get; set; }
        public string Moneda { get; set; }
        public int TasadeCambio { get; set; }
        public int CodigoArticulo { get; set; }
        public string NombreArticulo { get; set; }
        public string UnidadMedida { get; set; }
        public double ValorUnitario { get; set; }
        public int Cantidad { get; set; }
        public double Descuento { get; set; }
        public int BienOServicio { get; set; }
        public int Excento { get; set; }
        public string Emails { get; set; }
        public string ResolucionDocumentoAnular { get; set; }
        public string TipoTransacionDocumentoAnularFACE { get; set; }
        public string SerieDocumentoAnular { get; set; }
        public string DispositivoElectronicoDocumentoAnular { get; set; }
        public string AnioDocumentoAnular { get; set; }
        public string NumeroDocumentoAnular { get; set; }
        public string PaisDestino { get; set; }
        public string Estado { get; set; }
        public string ClienteCodigo { get; set; }
        public string ClienteNombre { get; set; }
        public string ClienteDireccion { get; set; }

        

    }
}
