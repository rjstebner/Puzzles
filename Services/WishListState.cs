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

    public bool InWishlist(PuzzleList puzzle)
    {
        var wishlist = Wishlist.WishlistPuzzles.Find(p => p.Id == puzzle.Id);
        if (wishlist == null)
        {
            return false;
        }
        return true;
    }
}