using System;
using System.Collections.Generic;

namespace Core.Entities;

public class Venta : BaseEntity
{
    public DateTime Fecha { get; set; } = DateTime.Now;
    public decimal Total { get; set; }
    public int ClienteId { get; set; }
    public virtual Cliente Cliente { get; set; }
    public virtual ICollection<DetalleVenta> DetallesVenta { get; set; }
}