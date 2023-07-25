using System.ComponentModel.DataAnnotations;

namespace PROYECTOAPI.Models
{
    // Entidad Producto_MasVendido
    public class mayor_vendido_producto
    {
        [Key]
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public double Costo { get; set; }
        public double Total_obtenido { get; set; }
    }

    public class menor_vendido_producto
    {
        [Key]
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public double Costo { get; set; }
        public double Total_obtenido { get; set; }
    }
    public class valores_calculados
    {
        [Key]
        public int Id { get; set; }
        public double Gross_profit { get; set; }
        public double Average_purchase_value { get; set; }
        public int Total_users { get; set; }
        public int New_users_weekly { get; set; }
    }

    public class ventas_mensuales
    {
        [Key]
        public int Id { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int Total_Sales { get; set; }
    }
}
