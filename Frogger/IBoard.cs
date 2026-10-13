interface IBoard
{
    int Width { get; }
    int Height { get; }

    void BoardSize(int width, int height);
    bool IsInside(int x, int y);
    bool IsOccupied(int x, int y);

    //void BoardSize(int width, int height);
    //void AddEntity(IEntity entity);
    //void RemoveEntity(IEntity entity);
    //IEnumerable<IEntity> GetEntities();
}   