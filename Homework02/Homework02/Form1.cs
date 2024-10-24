using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework02 {
    public partial class Form1 : Form {

        int[,] score = new int[3,5];
        
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            Random randomInt = new Random(Guid.NewGuid().GetHashCode());
            
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 5; j++) {
                    score[i,j] = randomInt.Next(1, 100);
                }
            }

            LB_dashboard.Text = "                                                                     \r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";

        }


        string computeAverage() {
            string buffer = "";





            return buffer;
        }

        private void BT_computeScores_Click(object sender, EventArgs e) {
            string buffer = "";
            buffer += "                                                                     \n";
            buffer += "名字    國文    英文    數學\n";
            buffer += "====================================\n";


            LB_dashboard.Text = buffer;
        }
    }
}
