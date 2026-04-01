using System;
using System.Drawing;
using System.Windows.Forms;

namespace hallo
{
    public partial class frmBMI : Form
    {
        private double lastBmi = 0;
        private string lastResult = "";

        private string marqueeText = "每日健康小語：多喝水、規律運動、少熬夜，健康從每天的小習慣開始！     ";
        private int marqueeX = 0;

        public frmBMI()
        {
            InitializeComponent();
            InitializeKeyboardAndUI();

            this.KeyDown += new KeyEventHandler(frmBMI_KeyDown);
            txtHeight.KeyDown += new KeyEventHandler(txtHeight_KeyDown);
            txtWeight.KeyDown += new KeyEventHandler(txtWeight_KeyDown);
        }

        private void frmBMI_Load(object sender, EventArgs e)
        {
            lblResult.Text = "";
            lblResult.BackColor = SystemColors.ControlLight;
            lblResult.ForeColor = Color.Black;
            txtHeight.Focus();

            lblMarquee.Text = marqueeText;
            marqueeX = pnlMarquee.Width;
            lblMarquee.Left = marqueeX;
            timerMarquee.Start();
        }

        private void txtHeight_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtWeight.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtWeight_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CalculateBMI();
                e.SuppressKeyPress = true;
            }
        }

        private void InitializeKeyboardAndUI()
        {
            this.KeyPreview = true;
            this.Font = new Font("微軟正黑體", 10F, FontStyle.Regular);

            txtHeight.BackColor = Color.AliceBlue;
            txtWeight.BackColor = Color.Honeydew;

            button1.Text = "&計算";
            btnClear.Text = "&清除";

            button1.BackColor = Color.SteelBlue;
            button1.ForeColor = Color.White;

            btnClear.BackColor = Color.Gray;
            btnClear.ForeColor = Color.White;

            txtHeight.TabIndex = 0;
            txtWeight.TabIndex = 1;
            button1.TabIndex = 2;
            btnClear.TabIndex = 3;
            lblResult.TabIndex = 4;

            計算BMIToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.C;
            清除資料ToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.L;
            離開ToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.X;
            BMI說明ToolStripMenuItem.ShortcutKeys = Keys.F1;
            健康建議ToolStripMenuItem.ShortcutKeys = Keys.F2;
            關於本系統ToolStripMenuItem.ShortcutKeys = Keys.F3;
        }

        private void frmBMI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                ClearData();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.F1)
            {
                ShowBMIInfo();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.F2)
            {
                ShowHealthAdvice();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.F3)
            {
                ShowAbout();
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalculateBMI();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void CalculateBMI()
        {
            bool isHeightValid = double.TryParse(txtHeight.Text, out double heightCm);
            bool isWeightValid = double.TryParse(txtWeight.Text, out double weightKg);

            if (!isHeightValid || !isWeightValid)
            {
                MessageBox.Show(
                    "請輸入正確的數字！",
                    "輸入錯誤",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (heightCm <= 0 || weightKg <= 0)
            {
                MessageBox.Show(
                    "身高與體重必須大於 0",
                    "數值錯誤",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            double heightM = heightCm / 100.0;
            double bmi = weightKg / (heightM * heightM);

            string[] resultList =
            {
                "體重過輕",
                "健康體位",
                "體位過重",
                "輕度肥胖",
                "中度肥胖",
                "重度肥胖"
            };

            Color[] colorList =
            {
                Color.LightSkyBlue,
                Color.LightGreen,
                Color.Gold,
                Color.Orange,
                Color.IndianRed,
                Color.MediumPurple
            };

            Color[] formColorList =
            {
                Color.FromArgb(230, 245, 255),
                Color.FromArgb(235, 255, 235),
                Color.FromArgb(255, 249, 220),
                Color.FromArgb(255, 239, 213),
                Color.FromArgb(255, 228, 225),
                Color.FromArgb(245, 235, 255)
            };

            int index;
            if (bmi < 18.5)
                index = 0;
            else if (bmi < 24)
                index = 1;
            else if (bmi < 27)
                index = 2;
            else if (bmi < 30)
                index = 3;
            else if (bmi < 35)
                index = 4;
            else
                index = 5;

            string result = resultList[index];
            Color resultColor = colorList[index];
            Color formColor = formColorList[index];

            lastBmi = bmi;
            lastResult = result;

            lblResult.Text = $"{bmi:F2} ({result})";
            lblResult.BackColor = resultColor;
            lblResult.ForeColor = Color.Black;
            lblResult.BorderStyle = BorderStyle.FixedSingle;

            this.BackColor = formColor;

            MessageBox.Show(
                $"您的 BMI 是 {bmi:F2}\n判定結果：{result}",
                "BMI 計算完成",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void ClearData()
        {
            txtHeight.Clear();
            txtWeight.Clear();
            lblResult.Text = "";
            lblResult.BackColor = SystemColors.ControlLight;
            lblResult.ForeColor = Color.Black;
            lblResult.BorderStyle = BorderStyle.None;

            this.BackColor = SystemColors.Control;

            lastBmi = 0;
            lastResult = "";

            txtHeight.Focus();
        }

        private void ShowHealthAdvice()
        {
            if (lastBmi <= 0 || string.IsNullOrEmpty(lastResult))
            {
                MessageBox.Show(
                    "請先完成 BMI 計算！",
                    "提醒",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            string advice = "";

            switch (lastResult)
            {
                case "體重過輕":
                    advice =
                        "【飲食建議】\n增加均衡熱量攝取，多補充蛋白質。\n\n" +
                        "【運動建議】\n以肌力訓練為主，幫助增加肌肉量。\n\n" +
                        "【生活建議】\n保持充足睡眠，必要時諮詢醫師。";
                    break;

                case "健康體位":
                    advice =
                        "【飲食建議】\n維持均衡飲食，多吃蔬菜水果。\n\n" +
                        "【運動建議】\n每週維持規律運動 3~5 次。\n\n" +
                        "【生活建議】\n持續保持良好作息與健康習慣。";
                    break;

                case "體位過重":
                    advice =
                        "【飲食建議】\n減少高糖飲料、甜食、油炸食物。\n\n" +
                        "【運動建議】\n每週至少 150 分鐘有氧運動。\n\n" +
                        "【生活建議】\n逐步控制體重，不要過度節食。";
                    break;

                case "輕度肥胖":
                    advice =
                        "【飲食建議】\n控制熱量攝取，減少宵夜與甜食。\n\n" +
                        "【運動建議】\n增加有氧運動並搭配肌力訓練。\n\n" +
                        "【生活建議】\n建議開始長期體重管理。";
                    break;

                case "中度肥胖":
                    advice =
                        "【飲食建議】\n建議尋求營養師協助規劃飲食。\n\n" +
                        "【運動建議】\n從低衝擊運動開始，例如快走或游泳。\n\n" +
                        "【生活建議】\n建議定期健康檢查。";
                    break;

                case "重度肥胖":
                    advice =
                        "【飲食建議】\n建議由醫師或營養師協助控制體重。\n\n" +
                        "【運動建議】\n先以低強度活動為主。\n\n" +
                        "【生活建議】\n儘快接受專業健康管理。";
                    break;

                default:
                    advice = "目前無法提供建議。";
                    break;
            }

            MessageBox.Show(
                $"您的 BMI：{lastBmi:F2}\n判定結果：{lastResult}\n\n{advice}",
                "健康建議",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void ShowBMIInfo()
        {
            string info =
                "BMI（身體質量指數）是用來初步評估體重是否正常的健康指標。\n\n" +
                "公式：BMI = 體重(kg) / 身高(m)^2\n\n" +
                "分類標準：\n" +
                "BMI < 18.5：體重過輕\n" +
                "18.5 ≤ BMI < 24：健康體位\n" +
                "24 ≤ BMI < 27：體位過重\n" +
                "27 ≤ BMI < 30：輕度肥胖\n" +
                "30 ≤ BMI < 35：中度肥胖\n" +
                "BMI ≥ 35：重度肥胖";

            MessageBox.Show(
                info,
                "BMI 說明",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void ShowAbout()
        {
            string about =
                "系統名稱：BMI 健康計算機 Pro\n" +
                "版本：1.0\n" +
                "開發工具：C# Windows Forms\n\n" +
                "快捷鍵：\n" +
                "Enter：身高跳到體重 / 體重直接計算\n" +
                "Esc：清除資料\n" +
                "F1：BMI 說明\n" +
                "F2：健康建議\n" +
                "F3：關於本系統\n" +
                "Alt+C：計算\n" +
                "Alt+L：清除\n" +
                "Alt+X：離開\n\n" +
                "作者：田秉立";

            MessageBox.Show(
                about,
                "關於本系統",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void timerMarquee_Tick(object sender, EventArgs e)
        {
            lblMarquee.Left -= 3;

            if (lblMarquee.Right < 0)
            {
                lblMarquee.Left = pnlMarquee.Width;
            }
        }

        private void 計算BMIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalculateBMI();
        }

        private void 清除資料ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void 離開ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BMI說明ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowBMIInfo();
        }

        private void 健康建議ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowHealthAdvice();
        }

        private void 關於本系統ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAbout();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
        }
    }
}