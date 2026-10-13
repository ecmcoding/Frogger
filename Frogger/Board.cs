class Board : IBoard
{
    IBoard board;
    public int Width { get; private set; }
    public int Height { get; private set; }

    public Board(IBoard board)
    {
        this.board = board;
    }

    public void BoardSize(int width, int height)
    {
        this.Width = width;
        this.Height = height;
    }

    // Testing method to make every cell inside the board unoccupied
    public bool IsInside(int x, int y) => x >= 0 && x < Width && y >= 0 && y < Height;
    public bool IsOccupied(int x, int y) => false;

    //public bool IsInside(int x, int y) => board.IsInside(x, y);
    //public bool IsOccupied(int x, int y) => board.IsOccupied(x, y);

    //public void AddEntity(IEntity entity) => board.AddEntity(entity);
    //public void RemoveEntity(IEntity entity) => board.RemoveEntity(entity);
    //public IEnumerable<IEntity> GetEntities() => board.GetEntities();
}