using System;
using System.Drawing;
using System.Windows.Forms;

namespace hallo
{
    public partial class frmBMI : Form
    {
        private double lastBmi = 0;
        private string lastResult = "";

        public frmBMI()
        {
            InitializeComponent();
        }

        private void frmBMI_Load(object sender, EventArgs e)
        {
            lblResult.Text = "";
            txtHeight.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalculateBMI();
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
                Color.LightBlue,
                Color.LightGreen,
                Color.Khaki,
                Color.Orange,
                Color.IndianRed,
                Color.Plum
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

            lastBmi = bmi;
            lastResult = result;

            lblResult.Text = $"{bmi:F2} ({result})";
            lblResult.BackColor = resultColor;
            lblResult.ForeColor = Color.Black;

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
            lblResult.BackColor = SystemColors.Control;
            lblResult.ForeColor = Color.Black;

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
                        "【飲食建議】\n" +
                        "增加均衡熱量攝取，多補充蛋白質，例如蛋、豆類、魚肉與雞肉。\n\n" +
                        "【運動建議】\n" +
                        "以肌力訓練為主，幫助增加肌肉量。\n\n" +
                        "【生活建議】\n" +
                        "保持充足睡眠，若長期過瘦可諮詢醫師或營養師。";
                    break;

                case "健康體位":
                    advice =
                        "【飲食建議】\n" +
                        "維持均衡飲食，多吃蔬菜水果，少吃高糖高油食物。\n\n" +
                        "【運動建議】\n" +
                        "每週維持規律運動 3~5 次，有氧與肌力訓練並行更好。\n\n" +
                        "【生活建議】\n" +
                        "持續保持良好作息與健康習慣。";
                    break;

                case "體位過重":
                    advice =
                        "【飲食建議】\n" +
                        "減少高糖飲料、甜食、油炸食物，注意份量控制。\n\n" +
                        "【運動建議】\n" +
                        "每週至少 150 分鐘有氧運動，例如快走、慢跑、騎腳踏車。\n\n" +
                        "【生活建議】\n" +
                        "逐步控制體重，不要使用過度節食方式。";
                    break;

                case "輕度肥胖":
                    advice =
                        "【飲食建議】\n" +
                        "控制熱量攝取，減少油炸、甜食與宵夜，建議記錄每日飲食。\n\n" +
                        "【運動建議】\n" +
                        "增加有氧運動頻率，並搭配基礎肌力訓練。\n\n" +
                        "【生活建議】\n" +
                        "建議開始長期體重管理並定期追蹤身體狀況。";
                    break;

                case "中度肥胖":
                    advice =
                        "【飲食建議】\n" +
                        "建議尋求營養師協助規劃飲食，避免暴飲暴食。\n\n" +
                        "【運動建議】\n" +
                        "從低衝擊運動開始，例如快走或游泳，再逐步增加活動量。\n\n" +
                        "【生活建議】\n" +
                        "建議定期健康檢查，留意血糖、血脂與血壓。";
                    break;

                case "重度肥胖":
                    advice =
                        "【飲食建議】\n" +
                        "建議由醫師或營養師協助控制體重，不建議自行極端節食。\n\n" +
                        "【運動建議】\n" +
                        "先以安全、低強度活動為主，運動前建議先評估身體狀況。\n\n" +
                        "【生活建議】\n" +
                        "儘快接受專業健康管理，留意慢性病與關節負擔風險。";
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
                "BMI ≥ 35：重度肥胖\n\n" +
                "注意：BMI 只是初步參考，對孕婦、健身者、老人等族群不一定完全適用。";

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
                "功能：\n" +
                "1. BMI 計算\n" +
                "2. 健康建議\n" +
                "3. BMI 說明\n" +
                "4. 基本資料清除\n\n" +
                "作者：田秉立";

            MessageBox.Show(
                about,
                "關於本系統",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
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
    }
}