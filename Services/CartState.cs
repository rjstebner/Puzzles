namespace Puzzles.Services;

public class CartState
{
    public Cart Cart { get; private set; } = new Cart();


    public void AddToCart(PuzzleList puzzle)
    {
        CartPuzzle newPuzzle = new(puzzle.Id, puzzle.Name!, puzzle.ImageUrl!, puzzle.BasePrice);
        CartPuzzle existingPuzzle = Cart.CartPuzzles.Find(p => p.Id == puzzle.Id)!;
        if (Cart.CartPuzzles.Find(p => p.Id == puzzle.Id) != null)
        { existingPuzzle!.Quantity++; }
        else
        { Cart.CartPuzzles.Add(newPuzzle); }
        Cart.CartTotal += puzzle.BasePrice;
    }

    public void RemoveFromCart(int puzzleId)
    {
        CartPuzzle existingPuzzle = Cart.CartPuzzles.Find(p => p.Id == puzzleId)!;
        if (existingPuzzle != null)
            Cart.CartPuzzles?.Remove(existingPuzzle);
    }
}