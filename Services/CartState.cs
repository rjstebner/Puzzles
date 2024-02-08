namespace Puzzles.Services;

public class CartState
{
    public Cart Cart { get; private set; } = new Cart();


    public void AddToCart(PuzzleList puzzle)
    {
        Cart.CartPuzzles.Add(puzzle);
    }

    public void RemoveFromCart(int puzzleId)
    {
        var removePuzzle = Cart.CartPuzzles?.Where(i => i.Id == puzzleId).First();
        if (removePuzzle != null)
            Cart.CartPuzzles?.Remove(removePuzzle);
    }
}