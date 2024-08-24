using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeAppFacade.Models
{
    internal class Game
    {
        private Board GameBoard { get; set; }
        private Player Player1 { get; set; }
        private Player Player2 { get; set; }
        private ResultAnalyzer Result { get; set; }
        public Player CurrentPlayer { get; set; }


        public Game(Player player1, Player player2, Board board) 
        {
             Player1 = player1;
             Player2 = player2;  
             GameBoard = board;
             Result = new ResultAnalyzer() { Board=GameBoard};
             CurrentPlayer = player1;
        }

        public void PlayGame()
        {
            int cnt = 0;
            while (Result.AnalyzeResult() == ResultType.PROGRESS && !GameBoard.IsBoardFull())
            {
               
                GameBoard.DisplayBoard();
                Console.WriteLine($"{CurrentPlayer.Name}'s turn ({CurrentPlayer.Symbol}):");
                Console.WriteLine("Enter location from 0 to 8");
                try
                {
                    int loc = Convert.ToInt32(Console.ReadLine());
                    GameBoard.SetCellMark(loc, CurrentPlayer.Symbol);
                    cnt++;

                    if (Result.AnalyzeResult() == ResultType.WIN)
                    {
                        // Console.Clear();

                        GameBoard.DisplayBoard();

                        Console.WriteLine($"Congratulations! {CurrentPlayer.Name} wins!");
                        return;
                    }

                    if (GameBoard.IsBoardFull())
                    {
                        // Console.Clear();

                        GameBoard.DisplayBoard();

                        Console.WriteLine("The game is a draw!");
                        return;
                    }

                    if (cnt % 2 == 0)
                    {
                        CurrentPlayer = Player1;
                    }
                    else
                    {
                        CurrentPlayer = Player2;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }

    }
}
