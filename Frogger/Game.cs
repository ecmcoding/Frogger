class Game
{
    private Board board;

    public Game(int rows, int cols)
    {
        board = new Board(rows, cols);
        board.Print();
    }

}