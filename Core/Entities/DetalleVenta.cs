using System;

namespace Core.Entities;

public class DetalleVenta : BaseEntity
{
    public int VentaId { get; set; }
    public int ProductoId { get; set; }
    public int Cantidad { get; set; }
    public decimal PrecioUnitario { get; set; }
    public decimal Subtotal { get; set; }
    public virtual Venta Venta { get; set; }
    public virtual Producto Producto { get; set; }
}