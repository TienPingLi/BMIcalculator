using System;
using System.Drawing;
using System.Windows.Forms;

namespace hallo
{
    public partial class BMI計算機 : Form
    {
        public BMI計算機()
        {
            InitializeComponent();
        }

       
            private void button1_Click(object sender, EventArgs e)
        {
            bool isHeightValid = double.TryParse(txtHeight.Text, out double heightCm);
            bool isWeightValid = double.TryParse(txtWeight.Text, out double weightKg);

            // ❌ 輸入錯誤
            if (!isHeightValid || !isWeightValid)
            {
                MessageBox.Show(
                    "請輸入正確的數字！",
                    "輸入錯誤",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // ❌ 防呆：不能為 0
            if (heightCm <= 0 || weightKg <= 0)
            {
                MessageBox.Show(
                    "身高與體重必須大於 0",
                    "數值錯誤",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            // BMI 計算
            double heightM = heightCm / 100.0;
            double bmi = weightKg / (heightM * heightM);

            // 分類
            string[] resultList = { "體重過輕", "健康體位", "體位過重", "輕度肥胖", "中度肥胖", "重度肥胖" };
            Color[] colorList = { Color.LightBlue, Color.LightGreen, Color.Khaki, Color.Orange, Color.IndianRed, Color.Plum };

            int index;
            if (bmi < 18.5) index = 0;
            else if (bmi < 24) index = 1;
            else if (bmi < 27) index = 2;
            else if (bmi < 30) index = 3;
            else if (bmi < 35) index = 4;
            else index = 5;

            string result = resultList[index];
            Color resultColor = colorList[index];

            // 顯示在 Label
            lblResult.Text = $"{bmi:F2} ({result})";
            lblResult.BackColor = resultColor;

            // ✅ 顯示 MessageBox 結果
            MessageBox.Show(
                $"您的 BMI 是 {bmi:F2}\n判定結果：{result}",
                "BMI 計算完成",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        
        }

        private void BMI計算機_Load(object sender, EventArgs e)
        {
        }
    }
}