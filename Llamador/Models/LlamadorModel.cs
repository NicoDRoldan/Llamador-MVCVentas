using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Llamador.Models
{
    public class LlamadorModel
    {
        public int NumPedido { get; set; }

        [ForeignKey("NumVenta, CodComprobante, CodModulo, NumSucursal")]
        public string NumVenta { get; set; }

        [Key]
        public string CodComprobante { get; set; }

        [Key]
        public string CodModulo { get; set; }

        [Key]
        public string NumSucursal { get; set; }

        [Key]
        public int Renglon { get; set; }

        public int Id_Articulo { get; set; }

        public decimal Cantidad { get; set; }

        public string? Retira { get; set; }

        public DateTime FechaCreacion { get; set; }

        public DateTime FechaExpiracion { get; set; }
    }
}
