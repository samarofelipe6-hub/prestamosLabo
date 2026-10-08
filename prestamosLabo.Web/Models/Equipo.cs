namespace prestamosLabo.Web.Models;

public class Equipo
{
    public int Id { get; set; }
    public string Nombre { get; set; } = "";
    public string NumeroSerie { get; set; } = "";
    public bool Disponible { get; set; } = true;
}