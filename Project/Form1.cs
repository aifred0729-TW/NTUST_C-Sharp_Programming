using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project {
    public partial class mainForm : Form {

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern int MessageBox(IntPtr hWnd, String text, String caption, uint type);

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool TerminateProcess(IntPtr hProcess, uint uExitCode);

        int pipeSpeed = 8;
        int pipeGap = 200;
        int minPipeTop = -200;
        int maxPipeTop = -50;
        int score = 0;
        int maxScore = 0;

        float gravity = 1.8f;
        float velocity = 0;
        float jumpStrength = -20;
        float maxFallSpeed = 15;

        Random random = new Random();

        public mainForm() {
            InitializeComponent(); 
            this.KeyDown += new KeyEventHandler(gameKeyDown);
            this.KeyUp += new KeyEventHandler(gameKeyUp);
        }

        private void mainForm_Load(object sender, EventArgs e) {

        }

        private void timer_Tick(object sender, EventArgs e) {
            velocity += gravity;
            if (velocity > maxFallSpeed) {
                velocity = maxFallSpeed;
            }

            PB_meow.Top += (int)velocity;
            PB_pipeBottom.Left -= pipeSpeed;
            PB_pipeTop.Left -= pipeSpeed;

            if (PB_pipeBottom.Left < -80 || PB_pipeTop.Left < -80) {
                PB_pipeBottom.Left = 800;
                PB_pipeTop.Left = 800;
                score++;
                LB_score.Text = "Score : " + score.ToString();
                if (maxScore < score) LB_max.Text = "Max : " + score.ToString();


                int randomPipeTop = random.Next(minPipeTop, maxPipeTop);
                PB_pipeTop.Top = randomPipeTop;
                PB_pipeBottom.Top = PB_pipeTop.Bottom + pipeGap;
            }

            if (PB_meow.Bounds.IntersectsWith(PB_pipeBottom.Bounds) ||
                PB_meow.Bounds.IntersectsWith(PB_pipeTop.Bounds) ||
                PB_meow.Top < -25 || PB_meow.Bottom > 500) { 
                endGame();
            }
        }

        private void gameKeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Space) 
            {
                velocity = jumpStrength;
            }
        }

        private void gameKeyUp(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }
        }

        private void endGame() {
            timer.Stop();
            int result = MessageBox(IntPtr.Zero, "Score : " + score.ToString() + "\nTry again ?", "Game Over !", 0x4);

            if (result == 7) TerminateProcess((IntPtr)(-1), 0);

            if (maxScore < score) maxScore = score;
            LB_max.Text = "Max : " + maxScore.ToString();

            score = 0;
            LB_score.Text = "Score : " + score.ToString();
            
            PB_meow.Top = 50;
            PB_pipeBottom.Left = 800;
            PB_pipeTop.Left = 800;
            timer.Start();
        }

    }
}
