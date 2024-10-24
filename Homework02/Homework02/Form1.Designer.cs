namespace Homework02 {
    partial class Form1 {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GB_scoreBox = new System.Windows.Forms.GroupBox();
            this.CB_average = new System.Windows.Forms.CheckBox();
            this.CB_failedPoints = new System.Windows.Forms.CheckBox();
            this.CB_ranking = new System.Windows.Forms.CheckBox();
            this.CB_allAverage = new System.Windows.Forms.CheckBox();
            this.BT_computeScores = new System.Windows.Forms.Button();
            this.LB_dashboard = new System.Windows.Forms.Label();
            this.LB_name = new System.Windows.Forms.Label();
            this.TB_name = new System.Windows.Forms.TextBox();
            this.BT_search = new System.Windows.Forms.Button();
            this.GB_scoreBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_scoreBox
            // 
            this.GB_scoreBox.Controls.Add(this.CB_allAverage);
            this.GB_scoreBox.Controls.Add(this.CB_ranking);
            this.GB_scoreBox.Controls.Add(this.CB_failedPoints);
            this.GB_scoreBox.Controls.Add(this.CB_average);
            this.GB_scoreBox.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_scoreBox.Location = new System.Drawing.Point(526, 34);
            this.GB_scoreBox.Name = "GB_scoreBox";
            this.GB_scoreBox.Size = new System.Drawing.Size(243, 163);
            this.GB_scoreBox.TabIndex = 0;
            this.GB_scoreBox.TabStop = false;
            this.GB_scoreBox.Text = "成績統計";
            // 
            // CB_average
            // 
            this.CB_average.AutoSize = true;
            this.CB_average.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_average.Location = new System.Drawing.Point(19, 35);
            this.CB_average.Name = "CB_average";
            this.CB_average.Size = new System.Drawing.Size(124, 24);
            this.CB_average.TabIndex = 0;
            this.CB_average.Text = "每人加權平均";
            this.CB_average.UseVisualStyleBackColor = true;
            // 
            // CB_failedPoints
            // 
            this.CB_failedPoints.AutoSize = true;
            this.CB_failedPoints.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_failedPoints.Location = new System.Drawing.Point(19, 65);
            this.CB_failedPoints.Name = "CB_failedPoints";
            this.CB_failedPoints.Size = new System.Drawing.Size(156, 24);
            this.CB_failedPoints.TabIndex = 1;
            this.CB_failedPoints.Text = "每人不及格學分數";
            this.CB_failedPoints.UseVisualStyleBackColor = true;
            // 
            // CB_ranking
            // 
            this.CB_ranking.AutoSize = true;
            this.CB_ranking.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_ranking.Location = new System.Drawing.Point(19, 95);
            this.CB_ranking.Name = "CB_ranking";
            this.CB_ranking.Size = new System.Drawing.Size(92, 24);
            this.CB_ranking.TabIndex = 2;
            this.CB_ranking.Text = "每人名次";
            this.CB_ranking.UseVisualStyleBackColor = true;
            // 
            // CB_allAverage
            // 
            this.CB_allAverage.AutoSize = true;
            this.CB_allAverage.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_allAverage.Location = new System.Drawing.Point(19, 125);
            this.CB_allAverage.Name = "CB_allAverage";
            this.CB_allAverage.Size = new System.Drawing.Size(92, 24);
            this.CB_allAverage.TabIndex = 3;
            this.CB_allAverage.Text = "各科平均";
            this.CB_allAverage.UseVisualStyleBackColor = true;
            // 
            // BT_computeScores
            // 
            this.BT_computeScores.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_computeScores.Location = new System.Drawing.Point(526, 212);
            this.BT_computeScores.Name = "BT_computeScores";
            this.BT_computeScores.Size = new System.Drawing.Size(243, 49);
            this.BT_computeScores.TabIndex = 1;
            this.BT_computeScores.Text = "成績計算";
            this.BT_computeScores.UseVisualStyleBackColor = true;
            this.BT_computeScores.Click += new System.EventHandler(this.BT_computeScores_Click);
            // 
            // LB_dashboard
            // 
            this.LB_dashboard.AutoSize = true;
            this.LB_dashboard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LB_dashboard.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_dashboard.Location = new System.Drawing.Point(12, 34);
            this.LB_dashboard.Name = "LB_dashboard";
            this.LB_dashboard.Size = new System.Drawing.Size(493, 172);
            this.LB_dashboard.TabIndex = 2;
            this.LB_dashboard.Text = "                                                                     \r\n\r\n\r\n\r\n\r\n\r\n" +
    "\r\n\r\n\r\n\r\n";
            // 
            // LB_name
            // 
            this.LB_name.AutoSize = true;
            this.LB_name.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_name.Location = new System.Drawing.Point(12, 226);
            this.LB_name.Name = "LB_name";
            this.LB_name.Size = new System.Drawing.Size(65, 20);
            this.LB_name.TabIndex = 3;
            this.LB_name.Text = "名字 : ";
            // 
            // TB_name
            // 
            this.TB_name.Location = new System.Drawing.Point(70, 226);
            this.TB_name.Name = "TB_name";
            this.TB_name.Size = new System.Drawing.Size(309, 22);
            this.TB_name.TabIndex = 4;
            // 
            // BT_search
            // 
            this.BT_search.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_search.Location = new System.Drawing.Point(385, 226);
            this.BT_search.Name = "BT_search";
            this.BT_search.Size = new System.Drawing.Size(120, 22);
            this.BT_search.TabIndex = 5;
            this.BT_search.Text = "搜尋成績";
            this.BT_search.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 273);
            this.Controls.Add(this.BT_search);
            this.Controls.Add(this.TB_name);
            this.Controls.Add(this.LB_name);
            this.Controls.Add(this.LB_dashboard);
            this.Controls.Add(this.BT_computeScores);
            this.Controls.Add(this.GB_scoreBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "資工二甲_B11215013_徐牧遠";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GB_scoreBox.ResumeLayout(false);
            this.GB_scoreBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_scoreBox;
        private System.Windows.Forms.CheckBox CB_average;
        private System.Windows.Forms.CheckBox CB_ranking;
        private System.Windows.Forms.CheckBox CB_failedPoints;
        private System.Windows.Forms.CheckBox CB_allAverage;
        private System.Windows.Forms.Button BT_computeScores;
        private System.Windows.Forms.Label LB_dashboard;
        private System.Windows.Forms.Label LB_name;
        private System.Windows.Forms.TextBox TB_name;
        private System.Windows.Forms.Button BT_search;
    }
}

