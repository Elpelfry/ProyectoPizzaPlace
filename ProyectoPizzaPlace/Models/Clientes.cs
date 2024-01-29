using System.ComponentModel.DataAnnotations;

namespace ProyectoPizzaPlace.Models;

public class Clientes
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "El Nombre es un campo obligatorio.")]
    [RegularExpression("^[a-zA-Z ]+$", ErrorMessage = "El Nombre debe contener solo letras.")]
    public string? Nombre { get; set; } 

    [Required(ErrorMessage = "Campo Obligatorio")]
    public string? Calle { get; set; } 

    [Required(ErrorMessage = "Campo Obligatorio")]
    [RegularExpression("^[a-zA-Z ]+$", ErrorMessage = "El campo debe contener solo letras.")]
    public string? Ciudad { get; set; } 
}
