using System.Collections.Generic;

namespace Puzzles.Data;
public class PuzzleData
{
    public static List<PuzzleList> GetPuzzles()
    {
        return new List<PuzzleList>
        {
            new PuzzleList { Name = "Sudoku Challenge", BasePrice = 11.99M, Description = "Test your logical skills with this classic puzzle", Difficulty = 3, ImageUrl = "https://developers.elementor.com/docs/assets/img/elementor-placeholder-image.png" },
            new PuzzleList { Name = "Word Search Mania", BasePrice = 12.75M, Description = "Find hidden words in a grid of letters", Difficulty = 2, ImageUrl = "https://developers.elementor.com/docs/assets/img/elementor-placeholder-image.png" },
            new PuzzleList { Name = "Maze Runner", BasePrice = 11.5M, Description = "Navigate through a complex maze and reach the exit", Difficulty = 1, ImageUrl = "https://developers.elementor.com/docs/assets/img/elementor-placeholder-image.png" },
            new PuzzleList { Name = "Jigsaw Puzzle Master", BasePrice = 9.99M, Description = "Piece together fragments to form a complete picture", Difficulty = 1, ImageUrl = "https://developers.elementor.com/docs/assets/img/elementor-placeholder-image.png" },
            new PuzzleList { Name = "Crossword Challenge", BasePrice = 11.99M, Description = "Fill in the blanks with words to complete the puzzle", Difficulty = 1, ImageUrl = "https://developers.elementor.com/docs/assets/img/elementor-placeholder-image.png" },
            new PuzzleList { Name = "Sudoku Junior", BasePrice = 10.5M, Description = "A simplified version of Sudoku for beginners", Difficulty = 1, ImageUrl = "https://developers.elementor.com/docs/assets/img/elementor-placeholder-image.png" }
        };
    }
}