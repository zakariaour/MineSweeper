using System;
using MineSweeper.Enums;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeper.Models
{
    public class BoardCell
    {
        public bool HasMine { get; set; } = false;
        public bool HasFlag{ get; set; } = false;
        public int Minesround { get; set; } = -1;

        public BoardCell()
        {

        }
    }
}
