class Player : IEntity
{
    public int X { get; private set; }
    public int Y { get; private set; }

    public Player(int x, int y)
    {
        X = x;
        Y = y;
    }
}