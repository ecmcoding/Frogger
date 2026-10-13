class Game
{
    private IBoard board;
    private IRenderer renderer;

    public Game(IBoard board, IRenderer renderer)
    {
        this.board = board;
        this.renderer = renderer;
    }

    public void Render()
    {
        renderer.Draw(board);
    }

}