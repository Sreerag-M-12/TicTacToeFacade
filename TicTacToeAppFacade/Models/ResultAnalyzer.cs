using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeAppFacade.Models
{
    internal class ResultAnalyzer
    {
        public Board Board { get; set; }
        public ResultType Result { get; set; }

        public ResultAnalyzer()
        {
            Result= ResultType.PROGRESS;
        }
        
        public void HorizontalWinCheck()
        {

            if (((Board.cells[0].Mark == Board.cells[1].Mark && Board.cells[1].Mark == Board.cells[2].Mark) && Board.cells[0].Mark != MarkType.EMPTY) ||
                ((Board.cells[3].Mark == Board.cells[4].Mark && Board.cells[4].Mark == Board.cells[5].Mark) && Board.cells[3].Mark != MarkType.EMPTY) ||
                ((Board.cells[6].Mark == Board.cells[7].Mark && Board.cells[7].Mark == Board.cells[8].Mark) && Board.cells[6].Mark != MarkType.EMPTY))
            {
                // Code to execute when any of the conditions are true
                Result=ResultType.WIN;
            }
        }
        public void VerticalWinCheck()
        {

            if (((Board.cells[0].Mark == Board.cells[3].Mark && Board.cells[3].Mark == Board.cells[6].Mark) && Board.cells[0].Mark != MarkType.EMPTY) ||
                ((Board.cells[1].Mark == Board.cells[4].Mark && Board.cells[4].Mark == Board.cells[7].Mark) && Board.cells[1].Mark != MarkType.EMPTY) ||
                ((Board.cells[2].Mark == Board.cells[5].Mark && Board.cells[5].Mark == Board.cells[8].Mark) && Board.cells[2].Mark != MarkType.EMPTY))
            {
                // Code to execute when any of the conditions are true
                Result = ResultType.WIN;

            }
        }
        public void DiagonalWinCheck()
        {
            if (((Board.cells[0].Mark == Board.cells[4].Mark && Board.cells[4].Mark == Board.cells[8].Mark) && Board.cells[0].Mark != MarkType.EMPTY) ||
                ((Board.cells[2].Mark == Board.cells[4].Mark && Board.cells[4].Mark == Board.cells[6].Mark) && Board.cells[2].Mark != MarkType.EMPTY))
            {
                Result = ResultType.WIN;
            }
        }

        public ResultType AnalyzeResult()
        {
            HorizontalWinCheck();
            VerticalWinCheck();
            DiagonalWinCheck();

            if (Result == ResultType.PROGRESS && Board.IsBoardFull())
            {
                Result = ResultType.DRAW;
                Console.WriteLine("Game Ended in Draw");
            }

            return Result;
        }
    }
}
