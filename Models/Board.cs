using MineSweeper.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeper.Models
{
    public class Board
    {
        public int Rows { get; set; }
        public int Columns { get; set; }
        public int Mines { get; set; }
        public BoardCell[,] Cells { get; set; }

        public Board(GameLevel gameLevel)
        {
            switch (gameLevel)
            {
                case GameLevel.Beginner:
                    Rows = 10; Columns = 10; Mines = 10; break;
                case GameLevel.Intermediate:
                    Rows = 16; Columns = 16; Mines = 40; break;
                case GameLevel.Expert:
                    Rows = 16; Columns = 30; Mines = 99; break;
            }
            Cells = new BoardCell[Rows, Columns];
            InitializeCells();
            SetMines();
        }

        private void InitializeCells()
        {
            for (int r = 0; r < Rows; r++)
            {
                for (int c = 0; c < Columns; c++)
                {
                    Cells[r, c] = new BoardCell();
                }
            }
        }

        private void SetMines()
        {
            var random = new Random();
            int minesPlaced = 0;

            while (minesPlaced < Mines)
            {
                int r = random.Next(Rows);
                int c = random.Next(Columns);
                if (!Cells[r, c].HasMine)
                {
                    Cells[r, c].HasMine = true;
                    minesPlaced++;
                }
            }
        }

        public void DebugBoard()
        {
            for (int r = 0; r < Rows; r++)
            {
                for (int c = 0; c < Columns; c++)
                {
                    Console.Write(Cells[r, c].HasMine ? "1 " : "0 ");
                }
                Console.WriteLine();
            }
        }
    }
}
