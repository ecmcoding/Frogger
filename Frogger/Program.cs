
Console.OutputEncoding = System.Text.Encoding.UTF8;

IBoard board = new Board(null!);
board.BoardSize(10, 10);

IRenderer renderer = new GameRenderer();

Game game = new Game(board, renderer);
game.Render();
