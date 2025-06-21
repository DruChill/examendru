using System;

namespace Core.Entities;

public class Mascota : BaseEntity
{
    public required string Nombre { get; set; }
    public required string Especie { get; set; }
    public string Raza { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public string Genero { get; set; }
    public string Color { get; set; }
    public string Observaciones { get; set; }
    
    // Relación con Cliente
    public int ClienteId { get; set; }
    public virtual Cliente Cliente { get; set; }
}