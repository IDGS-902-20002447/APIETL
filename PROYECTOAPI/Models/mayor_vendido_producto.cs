using Microsoft.AspNetCore.Routing;
using System;
using System.ComponentModel.DataAnnotations;

namespace PROYECTOAPI.Models
{
    // Entidad Producto_MasVendido
    public class mayor_vendido_producto
    {
        [Key]
        public int Id { get; set; }
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public double Costo { get; set; }
        public double Total_obtenido { get; set; }
        public int fecha { get; set; }
    }

    public class menor_vendido_producto
    {
        [Key]
        public int  Id { get; set; }
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public double Costo { get; set; }
        public double Total_obtenido { get; set; }
        public int fecha { get; set; }
    }
    public class valores_calculados
    {
        [Key]
        public int Id { get; set; }
        public double Gross_profit { get; set; }
        public double Average_purchase_value { get; set; }
        public int Total_users { get; set; }
        public int Average_order_value { get; set; }
        public int fecha {  get; set; }
    }

    public class ventas_mensuales
    {
        [Key]
        public int Id { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public string Nombre { get; set; }
        public int Total_vendido { get; set; }
    }
 
    public class materia_prima_existencia
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public string Unidad_medida { get; set; }
        public double Costo { get; set; }
        public int fecha { get; set; }
    }

    public class producto_existencia
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Costo { get; set; }
        public string Tipo_producto { get; set; }
        public int Stock { get; set; }
        public int fecha {get; set;}

    }
 
    public class clientes_mayores_pedidos
    {
        [Key]
        public int Id { get; set; }
        public int NumPedidos { get; set; }
        public string Name { get; set; }
        public int Telefono { get; set; }
        public string email { get; set; }
        public int fecha { get; set; }

    }



}
