using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework03 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        string[] files = {"Chinese.txt",
                "English.txt",
                "Math.txt"};
        string[] names;

        int[,] scores = new int[10, 10];
        string[] tmps;
        int pattern = 10;

        private void Form1_Load(object sender, EventArgs e) {
            string resourcePath = @"..\..\Resources\";

            string tmp = File.ReadAllText(resourcePath + "student.txt");
            names = tmp.Split('\n');

            for (int i = 0; i < 3; i++) {
                tmp = File.ReadAllText(resourcePath + files[i]);
                tmps = tmp.Trim().Split('\n');
                for (int j = 0; j < tmps.Length; j++) {
                    scores[i, j] = Convert.ToInt32(tmps[j].Trim());
                }
            }
        }

        string buildTitle() {
            string buffer = "";
            if (mnuItemName.Checked) buffer += "Names".PadRight(pattern);
            if (mnuItemChinese.Checked) buffer += "Chinese".PadRight(pattern);
            if (mnuItemEnglish.Checked) buffer += "English".PadRight(pattern);
            if (mnuItemMath.Checked) buffer += "Math".PadRight(pattern);
            buffer += "\n";
            buffer += "=========================================\n";
            return buffer;
        }

        string buildLine(int index) {
            string buffer = "";

            if (mnuItemName.Checked) buffer += names[index].Trim().PadRight(pattern);
            if (mnuItemChinese.Checked) buffer += scores[0, index].ToString().PadRight(pattern);
            if (mnuItemEnglish.Checked) buffer += scores[1, index].ToString().PadRight(pattern);
            if (mnuItemMath.Checked) buffer += scores[2, index].ToString().PadRight(pattern);
            buffer += "\n";

            return buffer;
        }

        string buildResult() {
            string buffer = "";
            buffer += buildTitle();

            for (int i = 0; i < names.Length-1; i++) {
                buffer += buildLine(i);
            }

            return buffer;
        }

        void updateDashBoard() {
            string result = buildResult();
            LB_display.Text = result;
            return;
        }

        private void mnuItemName_Click(object sender, EventArgs e) {
            if (mnuItemName.Checked) {
                statusStrip.Visible = false;
                mnuItemName.Checked = false;
            } else {
                statusStrip.Visible= true;
                mnuItemName.Checked = true;
            }
            updateDashBoard();
        }

        private void mnuItemChinese_Click(object sender, EventArgs e) {
            if (mnuItemChinese.Checked) {
                statusStrip.Visible = false;
                mnuItemChinese.Checked = false;
            }
            else {
                statusStrip.Visible = true;
                mnuItemChinese.Checked = true;
            }
            updateDashBoard();
        }

        private void mnuItemEnglish_Click(object sender, EventArgs e) {
            if (mnuItemEnglish.Checked) {
                statusStrip.Visible = false;
                mnuItemEnglish.Checked = false;
            }
            else {
                statusStrip.Visible = true;
                mnuItemEnglish.Checked = true;
            }
            updateDashBoard();
        }

        private void mnuItemMath_Click(object sender, EventArgs e) {
            if (mnuItemMath.Checked) {
                statusStrip.Visible = false;
                mnuItemMath.Checked = false;
            }
            else {
                statusStrip.Visible = true;
                mnuItemMath.Checked = true;
            }
            updateDashBoard();
        }
    }
}
