using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace hallo
{
    partial class frmBMI
    {
        private IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.功能FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.計算BMIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清除資料ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.離開ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.說明HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BMI說明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.健康建議ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.關於本系統ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblResultTitle = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.pnlMarquee = new System.Windows.Forms.Panel();
            this.lblMarquee = new System.Windows.Forms.Label();
            this.timerMarquee = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.pnlMarquee.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.功能FToolStripMenuItem,
            this.說明HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(404, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 功能FToolStripMenuItem
            // 
            this.功能FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.計算BMIToolStripMenuItem,
            this.清除資料ToolStripMenuItem,
            this.離開ToolStripMenuItem});
            this.功能FToolStripMenuItem.Name = "功能FToolStripMenuItem";
            this.功能FToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.功能FToolStripMenuItem.Text = "功能(&F)";
            // 
            // 計算BMIToolStripMenuItem
            // 
            this.計算BMIToolStripMenuItem.Name = "計算BMIToolStripMenuItem";
            this.計算BMIToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.計算BMIToolStripMenuItem.Text = "計算 BMI";
            this.計算BMIToolStripMenuItem.Click += new System.EventHandler(this.計算BMIToolStripMenuItem_Click);
            // 
            // 清除資料ToolStripMenuItem
            // 
            this.清除資料ToolStripMenuItem.Name = "清除資料ToolStripMenuItem";
            this.清除資料ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.清除資料ToolStripMenuItem.Text = "清除資料";
            this.清除資料ToolStripMenuItem.Click += new System.EventHandler(this.清除資料ToolStripMenuItem_Click);
            // 
            // 離開ToolStripMenuItem
            // 
            this.離開ToolStripMenuItem.Name = "離開ToolStripMenuItem";
            this.離開ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.離開ToolStripMenuItem.Text = "離開";
            this.離開ToolStripMenuItem.Click += new System.EventHandler(this.離開ToolStripMenuItem_Click);
            // 
            // 說明HToolStripMenuItem
            // 
            this.說明HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BMI說明ToolStripMenuItem,
            this.健康建議ToolStripMenuItem,
            this.關於本系統ToolStripMenuItem});
            this.說明HToolStripMenuItem.Name = "說明HToolStripMenuItem";
            this.說明HToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.說明HToolStripMenuItem.Text = "說明(&H)";
            // 
            // BMI說明ToolStripMenuItem
            // 
            this.BMI說明ToolStripMenuItem.Name = "BMI說明ToolStripMenuItem";
            this.BMI說明ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.BMI說明ToolStripMenuItem.Text = "BMI 說明";
            this.BMI說明ToolStripMenuItem.Click += new System.EventHandler(this.BMI說明ToolStripMenuItem_Click);
            // 
            // 健康建議ToolStripMenuItem
            // 
            this.健康建議ToolStripMenuItem.Name = "健康建議ToolStripMenuItem";
            this.健康建議ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.健康建議ToolStripMenuItem.Text = "健康建議";
            this.健康建議ToolStripMenuItem.Click += new System.EventHandler(this.健康建議ToolStripMenuItem_Click);
            // 
            // 關於本系統ToolStripMenuItem
            // 
            this.關於本系統ToolStripMenuItem.Name = "關於本系統ToolStripMenuItem";
            this.關於本系統ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.關於本系統ToolStripMenuItem.Text = "關於本系統";
            this.關於本系統ToolStripMenuItem.Click += new System.EventHandler(this.關於本系統ToolStripMenuItem_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitle.Location = new System.Drawing.Point(30, 36);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(340, 32);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "BMI 健康計算機";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.lblHeight.Location = new System.Drawing.Point(48, 90);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(92, 18);
            this.lblHeight.TabIndex = 2;
            this.lblHeight.Text = "身高 (cm)：";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.lblWeight.Location = new System.Drawing.Point(48, 130);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(91, 18);
            this.lblWeight.TabIndex = 3;
            this.lblWeight.Text = "體重 (kg)：";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(150, 88);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(160, 25);
            this.txtHeight.TabIndex = 4;
            this.txtHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(150, 128);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(160, 25);
            this.txtWeight.TabIndex = 5;
            this.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "計算";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(214, 173);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 34);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "清除";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblResultTitle
            // 
            this.lblResultTitle.AutoSize = true;
            this.lblResultTitle.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.lblResultTitle.Location = new System.Drawing.Point(48, 225);
            this.lblResultTitle.Name = "lblResultTitle";
            this.lblResultTitle.Size = new System.Drawing.Size(80, 18);
            this.lblResultTitle.TabIndex = 8;
            this.lblResultTitle.Text = "計算結果：";
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Location = new System.Drawing.Point(51, 252);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(299, 36);
            this.lblResult.TabIndex = 9;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMarquee
            // 
            this.pnlMarquee.BackColor = System.Drawing.Color.White;
            this.pnlMarquee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMarquee.Controls.Add(this.lblMarquee);
            this.pnlMarquee.Location = new System.Drawing.Point(30, 307);
            this.pnlMarquee.Name = "pnlMarquee";
            this.pnlMarquee.Size = new System.Drawing.Size(340, 32);
            this.pnlMarquee.TabIndex = 10;
            // 
            // lblMarquee
            // 
            this.lblMarquee.AutoSize = true;
            this.lblMarquee.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold);
            this.lblMarquee.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblMarquee.Location = new System.Drawing.Point(340, 8);
            this.lblMarquee.Name = "lblMarquee";
            this.lblMarquee.Size = new System.Drawing.Size(0, 15);
            this.lblMarquee.TabIndex = 0;
            // 
            // timerMarquee
            // 
            this.timerMarquee.Enabled = true;
            this.timerMarquee.Interval = 60;
            this.timerMarquee.Tick += new System.EventHandler(this.timerMarquee_Tick);
            // 
            // frmBMI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 371);
            this.Controls.Add(this.pnlMarquee);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblResultTitle);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmBMI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI 健康計算機 Pro";
            this.Load += new System.EventHandler(this.frmBMI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlMarquee.ResumeLayout(false);
            this.pnlMarquee.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem 功能FToolStripMenuItem;
        private ToolStripMenuItem 計算BMIToolStripMenuItem;
        private ToolStripMenuItem 清除資料ToolStripMenuItem;
        private ToolStripMenuItem 離開ToolStripMenuItem;
        private ToolStripMenuItem 說明HToolStripMenuItem;
        private ToolStripMenuItem BMI說明ToolStripMenuItem;
        private ToolStripMenuItem 健康建議ToolStripMenuItem;
        private ToolStripMenuItem 關於本系統ToolStripMenuItem;
        private Label lblTitle;
        private Label lblHeight;
        private Label lblWeight;
        private TextBox txtHeight;
        private TextBox txtWeight;
        private Button button1;
        private Button btnClear;
        private Label lblResultTitle;
        private Label lblResult;
        private Panel pnlMarquee;
        private Label lblMarquee;
        private Timer timerMarquee;
    }
}