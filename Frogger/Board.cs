public class Board
{
    private char[,] board;
    string Piece = "🌱";

    public Board(int rows, int cols)
    {
        board = new char[rows, cols];
    }

    public void Print()
    {
        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                Console.Write(board[i, j] + Piece);
            }
            Console.WriteLine();
        }
    }
}