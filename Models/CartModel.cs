namespace Puzzles;


public class Cart
{
    public List<CartPuzzle> CartPuzzles { get; set; } = [];
    public decimal CartTotal { get; set; }
    public string? GetFormattedTotal() => CartTotal.ToString("C");
}

public class CartPuzzle
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? ImageUrl { get; set; }
    public decimal BasePrice { get; set; }
    public int Quantity { get; set; }
    public string? GetFormattedBasePrice() => BasePrice.ToString("C");

    public CartPuzzle(int Id, string Name, string ImageUrl, decimal BasePrice)
    {
        this.Id = Id;
        this.Name = Name;
        this.ImageUrl = ImageUrl;
        this.BasePrice = BasePrice;
        Quantity = 1;
    }
}