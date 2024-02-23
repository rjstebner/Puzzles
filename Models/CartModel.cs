namespace Puzzles;

/// <summary>
/// Class <c>Cart</c> is the main Cart object for storing the current cart. The class has two public properties: CartPuzzles, Cart Total and one public method: GetFormattedTotal().
/// </summary>
public class Cart
{
    /// <summary>
    /// <value>Property <c>CartPuzzles</c> is a <c>CartPuzzle</c> list that contains all the puzzles in the cart.</value> 
    /// </summary>
    public List<CartPuzzle> CartPuzzles { get; set; } = [];

    /// <summary>
    /// <value>Property <c>CartTotal</c> is a decimal to store the running total of the cart.</value>
    /// </summary>
    public decimal CartTotal { get; set; }

    /// <returns>The cart total as a string with the currency indicator in the front.</returns>
    public string? GetFormattedTotal() => CartTotal.ToString("C");
}

/// <summary>
/// Class <c>CartPuzzle</c> is used as an object class in Class <c>Cart</c> as a list to store all the puzzles added to the cart. The class has five public properties: Id, Name, ImageUrl, BasePrice, and Quantity and one public method: GetFormattedBasePrice.
/// </summary>
public class CartPuzzle
{
    /// <summary>
    /// <value>Proprty<c>Id</c> is an integer representing the puzzle's Id.</value>
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// <value>Proprty<c>Name</c> is a string representing the puzzle's name.</value>
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// <value>Proprty<c>ImageUrl</c> is a string representing the url to the puzzle's image.</value>
    /// </summary>
    public string? ImageUrl { get; set; }

    /// <summary>
    /// <value>Proprty<c>Id</c> is a decimal representing the puzzle's base price.</value>
    /// </summary>
    public decimal BasePrice { get; set; }

    /// <summary>
    /// <value>Proprty<c>Id</c> is an integer representing the amount of each puzzle in the cart.</value>
    /// </summary>
    public int Quantity { get; set; }

    /// <returns>The base price as a string with the currency indicator in the front.</returns>
    public string? GetFormattedBasePrice() => BasePrice.ToString("C");

    /// <summary>
    /// The Constructor of class <c>CartPuzzle</c> that sets the values of each property
    /// </summary>
    /// <param name="Id">The puzzle's Id.</param>
    /// <param name="Name">The puzzle's name.</param>
    /// <param name="ImageUrl">The url to the puzzle's image.</param>
    /// <param name="BasePrice">The puzzle's base price</param>
    public CartPuzzle(int Id, string Name, string ImageUrl, decimal BasePrice)
    {
        this.Id = Id;
        this.Name = Name;
        this.ImageUrl = ImageUrl;
        this.BasePrice = BasePrice;
        Quantity = 1;
    }
}