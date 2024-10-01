using System;
using System.Threading;
using System.Windows.Forms;

namespace Lab5_Najm
{
    public partial class Form3 : Form
    {
        private int player1StartX;
        private int player1StartY;
        private int player2StartX;
        private int player2StartY;

        private Thread threadGo1;
        private Thread threadGo2;
        private volatile bool stopMovement;

        public Form3()
        {
            InitializeComponent();
            // Store the initial positions of the buttons
            player1StartX = btnPlayer1.Left;
            player1StartY = btnPlayer1.Top;
            player2StartX = btnPlayer2.Left;
            player2StartY = btnPlayer2.Top;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Start the thread to move btnPlayer1 if not already running
            if (threadGo1 == null || !threadGo1.IsAlive)
            {
                stopMovement = false; // Reset the stop flag
                threadGo1 = new Thread(MovePlayer1);
                threadGo1.IsBackground = true; // Set as background thread
                threadGo1.Start();
            }
        }

        private void MovePlayer1()
        {
            while (!stopMovement)
            {
                // Move btnPlayer1 to the right
                while (btnPlayer1.Left < this.ClientSize.Width - btnPlayer1.Width && !stopMovement)
                {
                    Invoke((Action)(() => btnPlayer1.Left += 5));
                    Thread.Sleep(20);
                }

                // Move btnPlayer1 back to the starting position if not stopped
                while (btnPlayer1.Left > player1StartX && !stopMovement)
                {
                    Invoke((Action)(() => btnPlayer1.Left -= 5));
                    Thread.Sleep(20);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Start the thread to move btnPlayer2 if not already running
            if (threadGo2 == null || !threadGo2.IsAlive)
            {
                stopMovement = false; // Reset the stop flag
                threadGo2 = new Thread(MovePlayer2);
                threadGo2.IsBackground = true; // Set as background thread
                threadGo2.Start();
            }
        }

        private void MovePlayer2()
        {
            while (!stopMovement)
            {
                // Move btnPlayer2 down
                while (btnPlayer2.Top < this.ClientSize.Height - btnPlayer2.Height && !stopMovement)
                {
                    Invoke((Action)(() => btnPlayer2.Top += 5));
                    Thread.Sleep(20);
                }

                // Move btnPlayer2 back to the starting position if not stopped
                while (btnPlayer2.Top > player2StartY && !stopMovement)
                {
                    Invoke((Action)(() => btnPlayer2.Top -= 5));
                    Thread.Sleep(20);
                }
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            // Set the stop flag for both players
            stopMovement = true;
        }
    }
}
