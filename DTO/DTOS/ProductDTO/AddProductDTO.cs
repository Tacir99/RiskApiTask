namespace DTO.DTOS.ProductDTO;

public class AddProductDTO
{

    public int Id { get; set; }
    public string Title { get; set; } 

    public string Description { get; set; }

    public decimal Price { get; set; }
    
    public int CategoryId { get; set; }
}
