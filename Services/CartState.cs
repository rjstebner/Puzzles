namespace Puzzles.Services;

/// <summary>
/// Class <c>CartState</c> handles the current state of the <c>Cart</c> and any methods for manipulating the <c>CartPuzzles</c> list
/// </summary>
public class CartState
{
    /// <summary>
    /// <value>Property <c>Cart</c> is a <c>Cart</c> object that contains the current cart.</value> 
    /// </summary>
    public Cart Cart { get; private set; } = new Cart();

    /// <summary>
    /// Adds the given puzzle to the cart.
    /// </summary>
    /// <param name="puzzle">A PuzzleList object.</param>
    public void AddToCart(PuzzleList puzzle)
    {
        // Create a new CartPuzzle object
        CartPuzzle newPuzzle = new(puzzle.Id, puzzle.Name!, puzzle.ImageUrl!, puzzle.BasePrice);
        // Try to the given puzzle in the cart
        CartPuzzle existingPuzzle = Cart.CartPuzzles.Find(p => p.Id == puzzle.Id)!;
        // If the cart already has the given puzzle
        if (Cart.CartPuzzles.Find(p => p.Id == puzzle.Id) != null)
        {
            // Increase the quantity of the puzzle in the cart 
            existingPuzzle!.Quantity++;
        }
        else
        {
            // Add the puzzle to the cart
            Cart.CartPuzzles.Add(newPuzzle);
        }
        // Increase the cart total with the given cart's base price
        Cart.CartTotal += puzzle.BasePrice;
    }

    /// <summary>
    /// Removes the puzzle with the given Id, if it exists in the cart.
    /// </summary>
    /// <param name="puzzleId">The puzzle's Id.</param>
    public void RemoveFromCart(int puzzleId)
    {
        // Find the puzzle with the given puzzleId
        CartPuzzle existingPuzzle = Cart.CartPuzzles.Find(p => p.Id == puzzleId)!;
        // If the puzzle exisits
        if (existingPuzzle != null)
            // Remove it from the cart
            Cart.CartPuzzles?.Remove(existingPuzzle);
    }
}