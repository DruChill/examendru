using System;
using System.Collections.Generic;

namespace Core.Entities;

public class Cliente : BaseEntity
{
    public required string Nombre { get; set; }
    public required string Apellido { get; set; }
    public required string Telefono { get; set; }
    public required string Email { get; set; }
    public required string Direccion { get; set; }
    public virtual ICollection<Mascota> Mascotas { get; set; }
    public virtual ICollection<Venta> Ventas { get; set; }
}