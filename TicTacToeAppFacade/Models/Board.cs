using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeAppFacade.Models
{
    internal class Board
    {
        public Cell[] cells = new Cell[9];
       // Cell cell =new Cell();
        public Board()
        {

            for (int i = 0; i < cells.Length; i++)
            {
                cells[i] = new Cell();
            }
            
        }
        public bool IsBoardFull()
        {
            foreach (var cell in cells)
            {
                if (cell.IsEmpty()==true)
                    return false;
               
            }
            return true;
        }
        public void SetCellMark(int location, MarkType mark)
        {
            Cell cell = cells[location];

            if (cell.Mark != MarkType.EMPTY)
            {
                throw new InvalidOperationException($"Cell at index {location} is already marked with {cell.Mark}. Choose a different cell.");
            }

            cell.Mark = mark;
        }

        public void DisplayBoard()
        {
          
            Console.WriteLine($"     |     |      \n" +
                  $"  {GetCellMark(0)}  |  {GetCellMark(1)}  |  {GetCellMark(2)}  \n" +
                  $"_____|_____|_____ \n" +
                  $"     |     |      \n" +
                  $"  {GetCellMark(3)}  |  {GetCellMark(4)}  |  {GetCellMark(5)}  \n" +
                  $"_____|_____|_____ \n" +
                  $"     |     |      \n" +
                  $"  {GetCellMark(6)}  |  {GetCellMark(7)}  |  {GetCellMark(8)}  \n" +
                  $"     |     |      ");
        }

        private string GetCellMark(int index)
        {
            if (cells[index] == null)
            {
                throw new InvalidOperationException($"Cell at index {index} is not initialized.");
            }

            string mark;

            if (cells[index].Mark == MarkType.EMPTY)
            {
                mark = " "; // If the cell is empty, return a space
            }
            else
            {
                mark = cells[index].Mark.ToString(); // Convert the MarkType to string (should return "X" or "O")
            }

            return mark;
        }

    }
}
