
using TicTacToeAppFacade.Models;

namespace TicTacToeAppFacade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player() { Name= "Plank", Symbol=MarkType.X};
            Player player2 = new Player() { Name="Jake", Symbol=MarkType.O};
            Board board1 = new Board();
            Game game = new Game(player1, player2, board1);

           
            game.PlayGame();
            
            
            //Player player3 = new Player() { Name = "Ge", Symbol = MarkType.X };
            //Player player4 = new Player() { Name = "Go", Symbol = MarkType.O };
            //Board board2 = new Board();
            //Game game2 = new Game(player3, player4, board2);
            //game2.PlayGame();
        }
    }
}
