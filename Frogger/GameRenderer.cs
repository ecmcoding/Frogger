class GameRenderer : IRenderer
{
    public void Draw(IBoard board)
    {
        for (int y = 0; y < board.Height; y++)
        {
            for (int x = 0; x < board.Width; x++)
            {
                if (board.IsOccupied(x, y))
                {
                    Console.Write("⬜");
                }
                else
                {
                    Console.Write("🌱");
                }
            }
            Console.WriteLine();
        }
    }
}