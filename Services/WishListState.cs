namespace Puzzles.Services;

public class WishlistState
{
    public Wishlist Wishlist { get; private set; } = new Wishlist();

    public void AddToWishlist(PuzzleList puzzle)
    {
        Wishlist.WishlistPuzzles.Add(puzzle);

    }

    public void RemoveFromWishlist(PuzzleList puzzle)
    {
        Wishlist.WishlistPuzzles.Remove(puzzle);
    }
}