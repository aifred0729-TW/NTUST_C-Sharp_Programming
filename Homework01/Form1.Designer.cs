namespace Homework01
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.title = new System.Windows.Forms.Label();
            this.mainOrderGroup = new System.Windows.Forms.GroupBox();
            this.tbBigPizzaCount = new System.Windows.Forms.TextBox();
            this.tbSmallPizzaCount = new System.Windows.Forms.TextBox();
            this.tbChickenBurgerCount = new System.Windows.Forms.TextBox();
            this.tbFishBurgerCount = new System.Windows.Forms.TextBox();
            this.lbmainCount = new System.Windows.Forms.Label();
            this.chkBigPizza = new System.Windows.Forms.CheckBox();
            this.chkSmallPizza = new System.Windows.Forms.CheckBox();
            this.chkChickenBurger = new System.Windows.Forms.CheckBox();
            this.chkFishBurger = new System.Windows.Forms.CheckBox();
            this.sideMealGroup = new System.Windows.Forms.GroupBox();
            this.rbSmallFries = new System.Windows.Forms.RadioButton();
            this.rbBigFries = new System.Windows.Forms.RadioButton();
            this.tbSmallFries = new System.Windows.Forms.TextBox();
            this.tbBigFries = new System.Windows.Forms.TextBox();
            this.lbSideMealCount = new System.Windows.Forms.Label();
            this.chkFries = new System.Windows.Forms.CheckBox();
            this.drinkGroup = new System.Windows.Forms.GroupBox();
            this.rbBlackTea = new System.Windows.Forms.RadioButton();
            this.rbCoffee = new System.Windows.Forms.RadioButton();
            this.rbCola = new System.Windows.Forms.RadioButton();
            this.tbBlackTea = new System.Windows.Forms.TextBox();
            this.tbCoffee = new System.Windows.Forms.TextBox();
            this.tbCola = new System.Windows.Forms.TextBox();
            this.lbDrink = new System.Windows.Forms.Label();
            this.chkDrink = new System.Windows.Forms.CheckBox();
            this.btOrder = new System.Windows.Forms.Button();
            this.lbMoneyTitle = new System.Windows.Forms.Label();
            this.lbMoney = new System.Windows.Forms.Label();
            this.mainOrderGroup.SuspendLayout();
            this.sideMealGroup.SuspendLayout();
            this.drinkGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(12, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(394, 33);
            this.title.TabIndex = 1;
            this.title.Text = "Homework01 - POS Order System";
            // 
            // mainOrderGroup
            // 
            this.mainOrderGroup.Controls.Add(this.tbBigPizzaCount);
            this.mainOrderGroup.Controls.Add(this.tbSmallPizzaCount);
            this.mainOrderGroup.Controls.Add(this.tbChickenBurgerCount);
            this.mainOrderGroup.Controls.Add(this.tbFishBurgerCount);
            this.mainOrderGroup.Controls.Add(this.lbmainCount);
            this.mainOrderGroup.Controls.Add(this.chkBigPizza);
            this.mainOrderGroup.Controls.Add(this.chkSmallPizza);
            this.mainOrderGroup.Controls.Add(this.chkChickenBurger);
            this.mainOrderGroup.Controls.Add(this.chkFishBurger);
            this.mainOrderGroup.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainOrderGroup.Location = new System.Drawing.Point(29, 59);
            this.mainOrderGroup.Name = "mainOrderGroup";
            this.mainOrderGroup.Size = new System.Drawing.Size(299, 187);
            this.mainOrderGroup.TabIndex = 2;
            this.mainOrderGroup.TabStop = false;
            this.mainOrderGroup.Text = "漢堡/披薩";
            // 
            // tbBigPizzaCount
            // 
            this.tbBigPizzaCount.Location = new System.Drawing.Point(180, 144);
            this.tbBigPizzaCount.Name = "tbBigPizzaCount";
            this.tbBigPizzaCount.Size = new System.Drawing.Size(100, 29);
            this.tbBigPizzaCount.TabIndex = 7;
            // 
            // tbSmallPizzaCount
            // 
            this.tbSmallPizzaCount.Location = new System.Drawing.Point(180, 109);
            this.tbSmallPizzaCount.Name = "tbSmallPizzaCount";
            this.tbSmallPizzaCount.Size = new System.Drawing.Size(100, 29);
            this.tbSmallPizzaCount.TabIndex = 6;
            // 
            // tbChickenBurgerCount
            // 
            this.tbChickenBurgerCount.Location = new System.Drawing.Point(180, 74);
            this.tbChickenBurgerCount.Name = "tbChickenBurgerCount";
            this.tbChickenBurgerCount.Size = new System.Drawing.Size(100, 29);
            this.tbChickenBurgerCount.TabIndex = 5;
            // 
            // tbFishBurgerCount
            // 
            this.tbFishBurgerCount.Location = new System.Drawing.Point(180, 39);
            this.tbFishBurgerCount.Name = "tbFishBurgerCount";
            this.tbFishBurgerCount.Size = new System.Drawing.Size(100, 29);
            this.tbFishBurgerCount.TabIndex = 4;
            // 
            // lbmainCount
            // 
            this.lbmainCount.AutoSize = true;
            this.lbmainCount.Location = new System.Drawing.Point(202, 15);
            this.lbmainCount.Name = "lbmainCount";
            this.lbmainCount.Size = new System.Drawing.Size(55, 21);
            this.lbmainCount.TabIndex = 3;
            this.lbmainCount.Text = "Count";
            // 
            // chkBigPizza
            // 
            this.chkBigPizza.AutoSize = true;
            this.chkBigPizza.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBigPizza.Location = new System.Drawing.Point(16, 146);
            this.chkBigPizza.Name = "chkBigPizza";
            this.chkBigPizza.Size = new System.Drawing.Size(128, 25);
            this.chkBigPizza.TabIndex = 3;
            this.chkBigPizza.Text = "大披薩 $429";
            this.chkBigPizza.UseVisualStyleBackColor = true;
            // 
            // chkSmallPizza
            // 
            this.chkSmallPizza.AutoSize = true;
            this.chkSmallPizza.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSmallPizza.Location = new System.Drawing.Point(16, 111);
            this.chkSmallPizza.Name = "chkSmallPizza";
            this.chkSmallPizza.Size = new System.Drawing.Size(128, 25);
            this.chkSmallPizza.TabIndex = 2;
            this.chkSmallPizza.Text = "小披薩 $259";
            this.chkSmallPizza.UseVisualStyleBackColor = true;
            // 
            // chkChickenBurger
            // 
            this.chkChickenBurger.AutoSize = true;
            this.chkChickenBurger.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkChickenBurger.Location = new System.Drawing.Point(16, 76);
            this.chkChickenBurger.Name = "chkChickenBurger";
            this.chkChickenBurger.Size = new System.Drawing.Size(119, 25);
            this.chkChickenBurger.TabIndex = 1;
            this.chkChickenBurger.Text = "雞肉堡 $69";
            this.chkChickenBurger.UseVisualStyleBackColor = true;
            // 
            // chkFishBurger
            // 
            this.chkFishBurger.AutoSize = true;
            this.chkFishBurger.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFishBurger.Location = new System.Drawing.Point(16, 41);
            this.chkFishBurger.Name = "chkFishBurger";
            this.chkFishBurger.Size = new System.Drawing.Size(119, 25);
            this.chkFishBurger.TabIndex = 0;
            this.chkFishBurger.Text = "魚肉堡 $59";
            this.chkFishBurger.UseVisualStyleBackColor = true;
            // 
            // sideMealGroup
            // 
            this.sideMealGroup.Controls.Add(this.rbSmallFries);
            this.sideMealGroup.Controls.Add(this.rbBigFries);
            this.sideMealGroup.Controls.Add(this.tbSmallFries);
            this.sideMealGroup.Controls.Add(this.tbBigFries);
            this.sideMealGroup.Controls.Add(this.lbSideMealCount);
            this.sideMealGroup.Controls.Add(this.chkFries);
            this.sideMealGroup.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sideMealGroup.Location = new System.Drawing.Point(403, 59);
            this.sideMealGroup.Name = "sideMealGroup";
            this.sideMealGroup.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sideMealGroup.Size = new System.Drawing.Size(241, 111);
            this.sideMealGroup.TabIndex = 3;
            this.sideMealGroup.TabStop = false;
            // 
            // rbSmallFries
            // 
            this.rbSmallFries.AutoSize = true;
            this.rbSmallFries.Enabled = false;
            this.rbSmallFries.Location = new System.Drawing.Point(18, 68);
            this.rbSmallFries.Name = "rbSmallFries";
            this.rbSmallFries.Size = new System.Drawing.Size(100, 25);
            this.rbSmallFries.TabIndex = 13;
            this.rbSmallFries.TabStop = true;
            this.rbSmallFries.Text = "小薯 $25";
            this.rbSmallFries.UseVisualStyleBackColor = true;
            // 
            // rbBigFries
            // 
            this.rbBigFries.AutoSize = true;
            this.rbBigFries.Enabled = false;
            this.rbBigFries.Location = new System.Drawing.Point(18, 35);
            this.rbBigFries.Name = "rbBigFries";
            this.rbBigFries.Size = new System.Drawing.Size(100, 25);
            this.rbBigFries.TabIndex = 12;
            this.rbBigFries.TabStop = true;
            this.rbBigFries.Text = "大薯 $35";
            this.rbBigFries.UseVisualStyleBackColor = true;
            // 
            // tbSmallFries
            // 
            this.tbSmallFries.Location = new System.Drawing.Point(132, 67);
            this.tbSmallFries.Name = "tbSmallFries";
            this.tbSmallFries.Size = new System.Drawing.Size(100, 29);
            this.tbSmallFries.TabIndex = 11;
            // 
            // tbBigFries
            // 
            this.tbBigFries.Location = new System.Drawing.Point(132, 34);
            this.tbBigFries.Name = "tbBigFries";
            this.tbBigFries.Size = new System.Drawing.Size(100, 29);
            this.tbBigFries.TabIndex = 8;
            // 
            // lbSideMealCount
            // 
            this.lbSideMealCount.AutoSize = true;
            this.lbSideMealCount.Location = new System.Drawing.Point(152, 10);
            this.lbSideMealCount.Name = "lbSideMealCount";
            this.lbSideMealCount.Size = new System.Drawing.Size(55, 21);
            this.lbSideMealCount.TabIndex = 8;
            this.lbSideMealCount.Text = "Count";
            // 
            // chkFries
            // 
            this.chkFries.AutoSize = true;
            this.chkFries.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFries.Location = new System.Drawing.Point(6, 0);
            this.chkFries.Name = "chkFries";
            this.chkFries.Size = new System.Drawing.Size(65, 25);
            this.chkFries.TabIndex = 8;
            this.chkFries.Text = "薯條";
            this.chkFries.UseVisualStyleBackColor = true;
            this.chkFries.CheckedChanged += new System.EventHandler(this.chkFries_CheckedChanged);
            // 
            // drinkGroup
            // 
            this.drinkGroup.Controls.Add(this.rbBlackTea);
            this.drinkGroup.Controls.Add(this.rbCoffee);
            this.drinkGroup.Controls.Add(this.rbCola);
            this.drinkGroup.Controls.Add(this.tbBlackTea);
            this.drinkGroup.Controls.Add(this.tbCoffee);
            this.drinkGroup.Controls.Add(this.tbCola);
            this.drinkGroup.Controls.Add(this.lbDrink);
            this.drinkGroup.Controls.Add(this.chkDrink);
            this.drinkGroup.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinkGroup.Location = new System.Drawing.Point(403, 176);
            this.drinkGroup.Name = "drinkGroup";
            this.drinkGroup.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.drinkGroup.Size = new System.Drawing.Size(241, 150);
            this.drinkGroup.TabIndex = 12;
            this.drinkGroup.TabStop = false;
            // 
            // rbBlackTea
            // 
            this.rbBlackTea.AutoSize = true;
            this.rbBlackTea.Enabled = false;
            this.rbBlackTea.Location = new System.Drawing.Point(18, 105);
            this.rbBlackTea.Name = "rbBlackTea";
            this.rbBlackTea.Size = new System.Drawing.Size(100, 25);
            this.rbBlackTea.TabIndex = 16;
            this.rbBlackTea.TabStop = true;
            this.rbBlackTea.Text = "紅茶 $20";
            this.rbBlackTea.UseVisualStyleBackColor = true;
            // 
            // rbCoffee
            // 
            this.rbCoffee.AutoSize = true;
            this.rbCoffee.Enabled = false;
            this.rbCoffee.Location = new System.Drawing.Point(18, 70);
            this.rbCoffee.Name = "rbCoffee";
            this.rbCoffee.Size = new System.Drawing.Size(100, 25);
            this.rbCoffee.TabIndex = 15;
            this.rbCoffee.TabStop = true;
            this.rbCoffee.Text = "咖啡 $30";
            this.rbCoffee.UseVisualStyleBackColor = true;
            // 
            // rbCola
            // 
            this.rbCola.AutoSize = true;
            this.rbCola.Enabled = false;
            this.rbCola.Location = new System.Drawing.Point(18, 35);
            this.rbCola.Name = "rbCola";
            this.rbCola.Size = new System.Drawing.Size(100, 25);
            this.rbCola.TabIndex = 14;
            this.rbCola.TabStop = true;
            this.rbCola.Text = "可樂 $25";
            this.rbCola.UseVisualStyleBackColor = true;
            // 
            // tbBlackTea
            // 
            this.tbBlackTea.Location = new System.Drawing.Point(132, 104);
            this.tbBlackTea.Name = "tbBlackTea";
            this.tbBlackTea.Size = new System.Drawing.Size(100, 29);
            this.tbBlackTea.TabIndex = 13;
            // 
            // tbCoffee
            // 
            this.tbCoffee.Location = new System.Drawing.Point(132, 69);
            this.tbCoffee.Name = "tbCoffee";
            this.tbCoffee.Size = new System.Drawing.Size(100, 29);
            this.tbCoffee.TabIndex = 11;
            // 
            // tbCola
            // 
            this.tbCola.Location = new System.Drawing.Point(132, 34);
            this.tbCola.Name = "tbCola";
            this.tbCola.Size = new System.Drawing.Size(100, 29);
            this.tbCola.TabIndex = 8;
            // 
            // lbDrink
            // 
            this.lbDrink.AutoSize = true;
            this.lbDrink.Location = new System.Drawing.Point(152, 10);
            this.lbDrink.Name = "lbDrink";
            this.lbDrink.Size = new System.Drawing.Size(55, 21);
            this.lbDrink.TabIndex = 8;
            this.lbDrink.Text = "Count";
            // 
            // chkDrink
            // 
            this.chkDrink.AutoSize = true;
            this.chkDrink.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDrink.Location = new System.Drawing.Point(6, 0);
            this.chkDrink.Name = "chkDrink";
            this.chkDrink.Size = new System.Drawing.Size(65, 25);
            this.chkDrink.TabIndex = 8;
            this.chkDrink.Text = "飲料";
            this.chkDrink.UseVisualStyleBackColor = true;
            this.chkDrink.CheckedChanged += new System.EventHandler(this.cbDrink_CheckedChanged);
            // 
            // btOrder
            // 
            this.btOrder.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOrder.Location = new System.Drawing.Point(29, 252);
            this.btOrder.Name = "btOrder";
            this.btOrder.Size = new System.Drawing.Size(154, 74);
            this.btOrder.TabIndex = 13;
            this.btOrder.Text = "點餐";
            this.btOrder.UseVisualStyleBackColor = true;
            this.btOrder.Click += new System.EventHandler(this.btOrder_Click);
            // 
            // lbMoneyTitle
            // 
            this.lbMoneyTitle.AutoSize = true;
            this.lbMoneyTitle.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMoneyTitle.Location = new System.Drawing.Point(206, 257);
            this.lbMoneyTitle.Name = "lbMoneyTitle";
            this.lbMoneyTitle.Size = new System.Drawing.Size(34, 15);
            this.lbMoneyTitle.TabIndex = 14;
            this.lbMoneyTitle.Text = "Price";
            // 
            // lbMoney
            // 
            this.lbMoney.AutoSize = true;
            this.lbMoney.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbMoney.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMoney.Location = new System.Drawing.Point(205, 261);
            this.lbMoney.Name = "lbMoney";
            this.lbMoney.Size = new System.Drawing.Size(184, 51);
            this.lbMoney.TabIndex = 15;
            this.lbMoney.Text = "        ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 346);
            this.Controls.Add(this.lbMoneyTitle);
            this.Controls.Add(this.btOrder);
            this.Controls.Add(this.drinkGroup);
            this.Controls.Add(this.sideMealGroup);
            this.Controls.Add(this.mainOrderGroup);
            this.Controls.Add(this.title);
            this.Controls.Add(this.lbMoney);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "POSOrder 資工二甲_B11215013_徐牧遠";
            this.mainOrderGroup.ResumeLayout(false);
            this.mainOrderGroup.PerformLayout();
            this.sideMealGroup.ResumeLayout(false);
            this.sideMealGroup.PerformLayout();
            this.drinkGroup.ResumeLayout(false);
            this.drinkGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.GroupBox mainOrderGroup;
        private System.Windows.Forms.CheckBox chkFishBurger;
        private System.Windows.Forms.Label lbmainCount;
        private System.Windows.Forms.CheckBox chkBigPizza;
        private System.Windows.Forms.CheckBox chkSmallPizza;
        private System.Windows.Forms.CheckBox chkChickenBurger;
        private System.Windows.Forms.TextBox tbSmallPizzaCount;
        private System.Windows.Forms.TextBox tbChickenBurgerCount;
        private System.Windows.Forms.TextBox tbFishBurgerCount;
        private System.Windows.Forms.TextBox tbBigPizzaCount;
        private System.Windows.Forms.GroupBox sideMealGroup;
        private System.Windows.Forms.CheckBox chkFries;
        private System.Windows.Forms.Label lbSideMealCount;
        private System.Windows.Forms.RadioButton rbSmallFries;
        private System.Windows.Forms.RadioButton rbBigFries;
        private System.Windows.Forms.TextBox tbSmallFries;
        private System.Windows.Forms.TextBox tbBigFries;
        private System.Windows.Forms.GroupBox drinkGroup;
        private System.Windows.Forms.TextBox tbCoffee;
        private System.Windows.Forms.TextBox tbCola;
        private System.Windows.Forms.Label lbDrink;
        private System.Windows.Forms.CheckBox chkDrink;
        private System.Windows.Forms.RadioButton rbBlackTea;
        private System.Windows.Forms.RadioButton rbCoffee;
        private System.Windows.Forms.RadioButton rbCola;
        private System.Windows.Forms.TextBox tbBlackTea;
        private System.Windows.Forms.Button btOrder;
        private System.Windows.Forms.Label lbMoneyTitle;
        private System.Windows.Forms.Label lbMoney;
    }
}

