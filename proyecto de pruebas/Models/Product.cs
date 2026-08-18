namespace proyecto_de_pruebas.Models;

public class Product
{
    public int Id { get; set; }
    public float Price { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Category { get; set; }
    public int Stock { get; set; }

    public Product(int Id, float Price, string Title, string Description, string Category, int Stock)
    {
        this.Id = Id;
        this.Price = Price;
        this.Title = Title;
        this.Description = Description;
        this.Category = Category;
        this.Stock = Stock;
    }
}