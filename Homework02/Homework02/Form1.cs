using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;


namespace Homework02 {
    public partial class Form1 : Form {

        const int PATTERN_COUNT = 8;
        const int PATTERN_WINDOW = 60;

        bool spawnRank = false;
        int[] ranks = new int[5];
        float[] averages = new float[5];
        int[,] scores = new int[5,3];
        string[] students = { "Red", "Yellow", "Purple", "Green", "Black"};
        string[] courses = { "Chinese", "English", "Math" };
        string LINE = "==============================================================\n";

        public Form1() {
            InitializeComponent();
        }

        void computeAverage() {
            float average = 0;

            for (int i = 0; i < students.Length; i++) {
                average = 0;
                for (int j = 0; j < courses.Length; j++) {
                    average += scores[i, j];
                }
                average /= courses.Length;
                average = (float)Math.Round(average, 1);
                averages[i] = average;
            }
        }

        void computeRank() {
            float tmp = 0;
            int index = 0;
            float[] tmpAvg = (float[])averages.Clone();

            for (int i = 0; i < students.Length; i++) {
                for (int j = 0; j < students.Length; j++) {
                    if (tmp > tmpAvg[j]) continue;
                    tmp = tmpAvg[j];
                    index = j;
                }
                ranks[index] = i+1;
                tmpAvg[index] = 0;
                tmp = 0;
            }
        }

        string messageWithPattern(string message) {
            return message.PadRight(PATTERN_COUNT);
        }

        private void Form1_Load(object sender, EventArgs e) {

            Random randomInt = new Random(Guid.NewGuid().GetHashCode());
            
            for (int i = 0; i < students.Length; i++) {
                for (int j = 0; j < courses.Length; j++) {
                    scores[i,j] = randomInt.Next(30, 100);
                }
            }

            computeAverage();
            computeRank();

            LB_dashboard.Text = "".PadRight(PATTERN_WINDOW);
            LB_dashboard.Text += "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
        }

        string generateBasicInformation(int studentIndex) {
            string buffer = "";

            buffer += students[studentIndex].PadRight(PATTERN_COUNT);

            for (int i = 0; i < courses.Length; i++) {
                buffer += messageWithPattern(scores[studentIndex, i].ToString());
            }

            return buffer;
        }

        string getAverage(int index) {
            return messageWithPattern(averages[index].ToString());
        }

        string countFailed(int index) {
            int count = 0;
            for (int i = 0; i < courses.Length;i++) {
                if (scores[index, i] < 60) count++;
            }
            return messageWithPattern(count.ToString());
        }

        string getRank(int index) {
            return messageWithPattern(ranks[index].ToString());
        }

        string computeTotal(int index) {
            int total = 0;
            for (int i = 0; i < courses.Length; i++) {
                total += scores[index, i];
            }
            return messageWithPattern(total.ToString());
        }

        string generateLine(int studentIndex) {
            string buffer = generateBasicInformation(studentIndex);

            if (CB_average.Checked) buffer += getAverage(studentIndex);
            if (CB_failedPoints.Checked) buffer += countFailed(studentIndex);
            if (CB_ranking.Checked) {
                buffer += getRank(studentIndex);
                buffer += computeTotal(studentIndex);
            }

            return buffer;
        }

        string computeCourseAverage() {
            string buffer = messageWithPattern("Average");
            float average = 0;

            for (int i = 0; i < courses.Length; i++) {
                for (int j = 0; j < students.Length; j++) {
                    average += scores[j, i];
                }
                average /= students.Length;
                average = (float)Math.Round(average, 1);
                buffer += messageWithPattern(average.ToString());
            }

            return buffer;
        }

        string generateResult(string query="") {

            string[] studentResults = new string[students.Length];

            string buffer = messageWithPattern("");
            buffer += '\n';
            buffer += messageWithPattern("Name");

            for (int i = 0; i < courses.Length; i++) {
                buffer += messageWithPattern(courses[i]);
            }

            if (CB_average.Checked) buffer += messageWithPattern("Average");
            if (CB_failedPoints.Checked) buffer += messageWithPattern("Failed");
            if (CB_ranking.Checked) {
                buffer += messageWithPattern("Rank");
                buffer += messageWithPattern("Total");
            }

            buffer += "\n";

            buffer += LINE;

            for (int i = 0; i < students.Length; i++) {
                studentResults[i] = generateLine(i);
                studentResults[i] += '\n';
            }

            int[] tmpRanks = (int[])ranks.Clone();

            for (int i = students.Length-1; i > 0; i--) {
                for (int j = 0; j < i; j++) {
                    if (tmpRanks[j] > tmpRanks[j+1]) {
                        string tmpS = studentResults[j];
                        studentResults[j] = studentResults[j+1];
                        studentResults[j + 1] = tmpS;
                        int tmpI = tmpRanks[j];
                        tmpRanks[j] = tmpRanks[j + 1];
                        tmpRanks[j+1] = tmpI;
                    }
                }
            }

            for (int i = 0; i < studentResults.Length; i++) {
                if (query != "") {
                    if (studentResults[i].Contains(query)) {
                        buffer += studentResults[i];
                        break;
                    }
                    continue;
                } else {
                    buffer += studentResults[i];
                }
                
            }

            buffer += LINE;

            if (CB_allAverage.Checked) buffer += computeCourseAverage();

            buffer += "\n\n";

            return buffer;
        }

        private void BT_computeScores_Click(object sender, EventArgs e) {
            LB_dashboard.Text = generateResult();
            return;
        }

        private void BT_search_Click(object sender, EventArgs e) {
            LB_dashboard.Text = generateResult(TB_name.Text);
            return;
        }
    }
}
