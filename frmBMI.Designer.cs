namespace hallo
{
    partial class frmBMI
    {
        /// <summary>
        /// 設計工具所需變數
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除使用中的資源
        /// </summary>
        /// <param name="disposing">若應釋放受控資源則為 true，否則為 false</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// 設計工具支援所需的方法
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.功能ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.計算BMIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清除資料ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.離開ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.說明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BMI說明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.健康建議ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.關於ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.關於本系統ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblResultTitle = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.功能ToolStripMenuItem,
            this.說明ToolStripMenuItem,
            this.關於ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 功能ToolStripMenuItem
            // 
            this.功能ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.計算BMIToolStripMenuItem,
            this.清除資料ToolStripMenuItem,
            this.離開ToolStripMenuItem});
            this.功能ToolStripMenuItem.Name = "功能ToolStripMenuItem";
            this.功能ToolStripMenuItem.Size = new System.Drawing.Size(53, 21);
            this.功能ToolStripMenuItem.Text = "功能";
            // 
            // 計算BMIToolStripMenuItem
            // 
            this.計算BMIToolStripMenuItem.Name = "計算BMIToolStripMenuItem";
            this.計算BMIToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.計算BMIToolStripMenuItem.Text = "計算 BMI";
            this.計算BMIToolStripMenuItem.Click += new System.EventHandler(this.計算BMIToolStripMenuItem_Click);
            // 
            // 清除資料ToolStripMenuItem
            // 
            this.清除資料ToolStripMenuItem.Name = "清除資料ToolStripMenuItem";
            this.清除資料ToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.清除資料ToolStripMenuItem.Text = "清除資料";
            this.清除資料ToolStripMenuItem.Click += new System.EventHandler(this.清除資料ToolStripMenuItem_Click);
            // 
            // 離開ToolStripMenuItem
            // 
            this.離開ToolStripMenuItem.Name = "離開ToolStripMenuItem";
            this.離開ToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.離開ToolStripMenuItem.Text = "離開";
            this.離開ToolStripMenuItem.Click += new System.EventHandler(this.離開ToolStripMenuItem_Click);
            // 
            // 說明ToolStripMenuItem
            // 
            this.說明ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BMI說明ToolStripMenuItem,
            this.健康建議ToolStripMenuItem});
            this.說明ToolStripMenuItem.Name = "說明ToolStripMenuItem";
            this.說明ToolStripMenuItem.Size = new System.Drawing.Size(53, 21);
            this.說明ToolStripMenuItem.Text = "說明";
            // 
            // BMI說明ToolStripMenuItem
            // 
            this.BMI說明ToolStripMenuItem.Name = "BMI說明ToolStripMenuItem";
            this.BMI說明ToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.BMI說明ToolStripMenuItem.Text = "BMI 說明";
            this.BMI說明ToolStripMenuItem.Click += new System.EventHandler(this.BMI說明ToolStripMenuItem_Click);
            // 
            // 健康建議ToolStripMenuItem
            // 
            this.健康建議ToolStripMenuItem.Name = "健康建議ToolStripMenuItem";
            this.健康建議ToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.健康建議ToolStripMenuItem.Text = "健康建議";
            this.健康建議ToolStripMenuItem.Click += new System.EventHandler(this.健康建議ToolStripMenuItem_Click);
            // 
            // 關於ToolStripMenuItem
            // 
            this.關於ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.關於本系統ToolStripMenuItem});
            this.關於ToolStripMenuItem.Name = "關於ToolStripMenuItem";
            this.關於ToolStripMenuItem.Size = new System.Drawing.Size(53, 21);
            this.關於ToolStripMenuItem.Text = "關於";
            // 
            // 關於本系統ToolStripMenuItem
            // 
            this.關於本系統ToolStripMenuItem.Name = "關於本系統ToolStripMenuItem";
            this.關於本系統ToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.關於本系統ToolStripMenuItem.Text = "關於本系統";
            this.關於本系統ToolStripMenuItem.Click += new System.EventHandler(this.關於本系統ToolStripMenuItem_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(90, 45);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 45);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "BMI 計算機";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHeight
            // 
            this.lblHeight.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.lblHeight.Location = new System.Drawing.Point(105, 125);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(120, 30);
            this.lblHeight.TabIndex = 2;
            this.lblHeight.Text = "身高 (cm)：";
            this.lblHeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWeight
            // 
            this.lblWeight.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.lblWeight.Location = new System.Drawing.Point(105, 180);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(120, 30);
            this.lblWeight.TabIndex = 3;
            this.lblWeight.Text = "體重 (kg)：";
            this.lblWeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtHeight
            // 
            this.txtHeight.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.txtHeight.Location = new System.Drawing.Point(230, 125);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(180, 29);
            this.txtHeight.TabIndex = 4;
            // 
            // txtWeight
            // 
            this.txtWeight.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.txtWeight.Location = new System.Drawing.Point(230, 180);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(180, 29);
            this.txtWeight.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(230, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "計算 BMI";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblResultTitle
            // 
            this.lblResultTitle.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.lblResultTitle.Location = new System.Drawing.Point(105, 320);
            this.lblResultTitle.Name = "lblResultTitle";
            this.lblResultTitle.Size = new System.Drawing.Size(120, 30);
            this.lblResultTitle.TabIndex = 7;
            this.lblResultTitle.Text = "計算結果：";
            this.lblResultTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.lblResult.Location = new System.Drawing.Point(230, 320);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(220, 40);
            this.lblResult.TabIndex = 8;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmBMI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 421);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblResultTitle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmBMI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI 計算機";
            this.Load += new System.EventHandler(this.frmBMI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 功能ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 計算BMIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清除資料ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 離開ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 說明ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BMI說明ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 健康建議ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 關於ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 關於本系統ToolStripMenuItem;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblResultTitle;
        private System.Windows.Forms.Label lblResult;
    }
}