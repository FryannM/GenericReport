using System;
using System.ComponentModel.DataAnnotations;

namespace Modelo.Dtos.Facturas
{
    public class FacturaCabeceraDto
    {
        [Key]
        public int facturaid { get; set; }
        public string factura { get; set; }
        public decimal? diario { get; set; }
        public string tipodecostoygasto { get; set; }
        public string numerodefactura { get; set; }
        public DateTime? fechafactura { get; set; }
        public double? year { get; set; }
        public double? mes { get; set; }
        public DateTime? fechavencimiento { get; set; }
        public string ncf { get; set; }
        public string referenciaproveedor { get; set; }
        public double? subtotal { get; set; }
        public int? tax_id { get; set; }
        public string tipoimpuesto { get; set; }
        public double? impuesto { get; set; }
        public decimal gravadoitebis { get; set; }
        public decimal? isc { get; set; }
        public decimal? cdt { get; set; }
        public double? total { get; set; }
        public decimal? neto { get; set; }
        public decimal? retenido { get; set; }
        public decimal? balance { get; set; }
        public double? tasa { get; set; }
        public double? totalrd { get; set; }
        public string moneda { get; set; }
        public int? partner_id { get; set; }
        public string sale_fiscal_type { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public string vat { get; set; }
        public string barcode { get; set; }
    }
}
