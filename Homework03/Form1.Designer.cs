namespace Homework03 {
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.readData = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemName = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemChinese = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemEnglish = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemMath = new System.Windows.Forms.ToolStripMenuItem();
            this.LB_display = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readData});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // readData
            // 
            this.readData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemName,
            this.mnuItemChinese,
            this.mnuItemEnglish,
            this.mnuItemMath});
            this.readData.Name = "readData";
            this.readData.Size = new System.Drawing.Size(71, 20);
            this.readData.Text = "讀取資料";
            // 
            // mnuItemName
            // 
            this.mnuItemName.Name = "mnuItemName";
            this.mnuItemName.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuItemName.Size = new System.Drawing.Size(171, 22);
            this.mnuItemName.Text = "成員名單";
            this.mnuItemName.Click += new System.EventHandler(this.mnuItemName_Click);
            // 
            // mnuItemChinese
            // 
            this.mnuItemChinese.Name = "mnuItemChinese";
            this.mnuItemChinese.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.mnuItemChinese.Size = new System.Drawing.Size(171, 22);
            this.mnuItemChinese.Text = "國文成績";
            this.mnuItemChinese.Click += new System.EventHandler(this.mnuItemChinese_Click);
            // 
            // mnuItemEnglish
            // 
            this.mnuItemEnglish.Name = "mnuItemEnglish";
            this.mnuItemEnglish.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.mnuItemEnglish.Size = new System.Drawing.Size(171, 22);
            this.mnuItemEnglish.Text = "英文成績";
            this.mnuItemEnglish.Click += new System.EventHandler(this.mnuItemEnglish_Click);
            // 
            // mnuItemMath
            // 
            this.mnuItemMath.Name = "mnuItemMath";
            this.mnuItemMath.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.mnuItemMath.Size = new System.Drawing.Size(171, 22);
            this.mnuItemMath.Text = "數學成績";
            this.mnuItemMath.Click += new System.EventHandler(this.mnuItemMath_Click);
            // 
            // LB_display
            // 
            this.LB_display.AutoSize = true;
            this.LB_display.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_display.Location = new System.Drawing.Point(24, 33);
            this.LB_display.Name = "LB_display";
            this.LB_display.Size = new System.Drawing.Size(0, 27);
            this.LB_display.TabIndex = 1;
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 428);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(800, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.LB_display);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "四資工二_B11215013_徐牧遠";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem readData;
        private System.Windows.Forms.ToolStripMenuItem mnuItemName;
        private System.Windows.Forms.ToolStripMenuItem mnuItemChinese;
        private System.Windows.Forms.ToolStripMenuItem mnuItemEnglish;
        private System.Windows.Forms.ToolStripMenuItem mnuItemMath;
        private System.Windows.Forms.Label LB_display;
        private System.Windows.Forms.StatusStrip statusStrip;
    }
}

