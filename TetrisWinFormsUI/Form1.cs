using System;
using System.Drawing;
using System.Windows.Forms;
using Tetris.Logic;

namespace TetrisWinFormsUI
{
    public partial class Form1 : Form
    {
        private GameLogic gameLogic;
        private Timer timer;
        private readonly int gameSpeed = 800; // Speed of the game, lower is faster.

        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            gameLogic = new GameLogic();
            this.KeyDown += new KeyEventHandler(OnKeyPress);
            this.Paint += new PaintEventHandler(OnPaint);
            this.DoubleBuffered = true;
            this.Text = "Tetris Game";
            this.ClientSize = new Size(240, 400);
            this.BackColor = Color.Black;

            timer = new Timer();
            timer.Interval = gameSpeed;
            timer.Tick += new EventHandler(GameTick);
            timer.Start();
        }

        private void GameTick(object sender, EventArgs e)
        {
            // Game tick logic
            Invalidate(); // Forces the form to be redrawn
        }

        private void OnKeyPress(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    // Move piece left
                    break;
                case Keys.Right:
                    // Move piece right
                    break;
                case Keys.Up:
                    // Rotate piece
                    break;
                case Keys.Down:
                    // Move piece down faster
                    break;
            }
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            // Drawing logic will go here
        }
    }
}
