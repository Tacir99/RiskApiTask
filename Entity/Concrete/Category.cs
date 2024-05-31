namespace Entity.Concrete;

public class Category
{
    public int Id { get; set; }

    public string Name { get; set; }

    IEnumerable<Product> Products { get; set; }


}
