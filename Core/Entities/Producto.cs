using System;

namespace Core.Entities;

public class Producto : BaseEntity
{
    public required string Nombre { get; set; }
    public string Descripcion { get; set; }
    public decimal Precio { get; set; }
    public int Stock { get; set; }
    public string Categoria { get; set; } // Medicamentos, Alimentos, Accesorios, etc.
}