using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeAppFacade.Models
{
    internal class Cell
    {
        public MarkType Mark { get; set; }

        public Cell()
        {
            Mark =MarkType.EMPTY;
        }
        public bool IsEmpty()
        {
            if(Mark == MarkType.EMPTY)
                return true;
            return false;
        }
        
    }
}
