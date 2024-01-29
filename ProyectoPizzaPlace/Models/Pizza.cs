namespace ProyectoPizzaPlace.Models;

public class Pizza
{
    public Pizza(int Id, string Nombre, decimal Precio, Picante Picante)
    {
        this.Id = Id;
        this.Nombre = Nombre;
        this.Precio = Precio;
        this.Picante = Picante;
    }
    public int Id { get; }
    public string Nombre { get; }
    public decimal Precio { get; }
    public Picante Picante { get; }
}