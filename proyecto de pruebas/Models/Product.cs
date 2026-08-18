namespace proyecto_de_pruebas.Models;

public class Product
{
    public string Nombre { get; set; }
    public int Edad { get; set; }

    public string ObtenerInformacion { get; set; }

    public Product(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
        ObtenerInformacion = $"Nombre: {Nombre} \nEdad: {Edad}";
    }
}