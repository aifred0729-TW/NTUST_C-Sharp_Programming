namespace Project {
    partial class mainForm {
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
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.PB_pipeBottom = new System.Windows.Forms.PictureBox();
            this.PB_pipeTop = new System.Windows.Forms.PictureBox();
            this.PB_meow = new System.Windows.Forms.PictureBox();
            this.LB_score = new System.Windows.Forms.Label();
            this.LB_max = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PB_pipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_meow)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 20;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // PB_pipeBottom
            // 
            this.PB_pipeBottom.Image = global::Project.Properties.Resources.pipeButton;
            this.PB_pipeBottom.Location = new System.Drawing.Point(548, 357);
            this.PB_pipeBottom.Name = "PB_pipeBottom";
            this.PB_pipeBottom.Size = new System.Drawing.Size(89, 261);
            this.PB_pipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_pipeBottom.TabIndex = 2;
            this.PB_pipeBottom.TabStop = false;
            // 
            // PB_pipeTop
            // 
            this.PB_pipeTop.Image = global::Project.Properties.Resources.pipeTop;
            this.PB_pipeTop.Location = new System.Drawing.Point(548, -64);
            this.PB_pipeTop.Name = "PB_pipeTop";
            this.PB_pipeTop.Size = new System.Drawing.Size(89, 236);
            this.PB_pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_pipeTop.TabIndex = 1;
            this.PB_pipeTop.TabStop = false;
            // 
            // PB_meow
            // 
            this.PB_meow.Image = global::Project.Properties.Resources.meow;
            this.PB_meow.Location = new System.Drawing.Point(181, 224);
            this.PB_meow.Name = "PB_meow";
            this.PB_meow.Size = new System.Drawing.Size(64, 61);
            this.PB_meow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_meow.TabIndex = 0;
            this.PB_meow.TabStop = false;
            // 
            // LB_score
            // 
            this.LB_score.AutoSize = true;
            this.LB_score.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_score.Location = new System.Drawing.Point(12, 20);
            this.LB_score.Name = "LB_score";
            this.LB_score.Size = new System.Drawing.Size(113, 29);
            this.LB_score.TabIndex = 3;
            this.LB_score.Text = "Score : 0";
            // 
            // LB_max
            // 
            this.LB_max.AutoSize = true;
            this.LB_max.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_max.Location = new System.Drawing.Point(147, 20);
            this.LB_max.Name = "LB_max";
            this.LB_max.Size = new System.Drawing.Size(94, 29);
            this.LB_max.TabIndex = 4;
            this.LB_max.Text = "Max : 0";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LB_max);
            this.Controls.Add(this.LB_score);
            this.Controls.Add(this.PB_pipeBottom);
            this.Controls.Add(this.PB_pipeTop);
            this.Controls.Add(this.PB_meow);
            this.KeyPreview = true;
            this.Name = "mainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_pipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_meow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox PB_meow;
        private System.Windows.Forms.PictureBox PB_pipeTop;
        private System.Windows.Forms.PictureBox PB_pipeBottom;
        private System.Windows.Forms.Label LB_score;
        private System.Windows.Forms.Label LB_max;
    }
}

