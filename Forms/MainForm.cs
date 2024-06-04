using MineSweeper.Models;
using System;
using MineSweeper.Enums;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void fichierToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void débutantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gameBoard = new Board(GameLevel.Beginner);
            gameBoard.DebugBoard();
        }

        private void boardView1_Load(object sender, EventArgs e)
        {

        }

        private void intermédiaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gameBoard = new Board(GameLevel.Intermediate);
            gameBoard.DebugBoard();
        }

        private void expertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gameBoard = new Board(GameLevel.Expert);
            gameBoard.DebugBoard();
        }
    }
}
