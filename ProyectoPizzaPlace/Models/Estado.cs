using ProyectoPizzaPlace.Services;

namespace ProyectoPizzaPlace.Models;

public class Estado
{
    public MenuService Menu { get; } = new MenuService();
    public CanastaCompras Canasta { get; } = new CanastaCompras();
    public InterfazUsuario Interfaz { get; set; } = new InterfazUsuario();
}
