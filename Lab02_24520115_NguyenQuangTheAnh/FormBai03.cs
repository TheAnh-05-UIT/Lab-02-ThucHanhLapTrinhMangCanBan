using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_24520115_NguyenQuangTheAnh
{
    public partial class frm_Bai03 : Form
    {
        public frm_Bai03()
        {
            InitializeComponent();
        }

        private void btn_DocFile_Click(object sender, EventArgs e)
        {
            string filePath = "inputFormBai3.txt";
  
            try
            {
                string content = File.ReadAllText(filePath);
                if (string.IsNullOrWhiteSpace(content))
                {
                    MessageBox.Show("File đang rỗng.");
                }
                using (StreamReader sr = new StreamReader(filePath))
                {
                    rtb_Content.Text = sr.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc file: " + ex.Message);
            }
         
                
        }

        private void btn_GhiFile_Click(object sender, EventArgs e)
        {
            string contentToWrite = rtb_Content.Text;
            string filePath = "outputFormBai3.txt";
            if (!string.IsNullOrWhiteSpace(contentToWrite))
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    sw.WriteLine(contentToWrite);
                }
                MessageBox.Show("Ghi file thành công!");
            }
            else
            {
                MessageBox.Show("Không có nội dung để ghi!");
            }
        }

        private void btn_KetQua_Click(object sender, EventArgs e)
        {

            CultureInfo.CurrentCulture = new CultureInfo("en-US", false);
            string outputFile = "outputFormBai3.txt";
            bool check = true;
            try
            {
                if (!File.Exists(outputFile))
                {
                    MessageBox.Show($"Loi: Khong tim thay file '{outputFile}'.");
                    return;
                }

                string[] expressions = File.ReadAllLines(outputFile);
                List<string> results = new List<string>();
                //File.WriteAllText(outputFile, string.Empty);
                Console.WriteLine("Dang xu ly cac phep tinh...");

                foreach (string expression in expressions)
                {
                    if (string.IsNullOrWhiteSpace(expression)) continue;
                    string correctedExpression = expression.Trim().Replace('–', '-');

                    try
                    {
                        double result = ExpressionEvaluator.Evaluate(correctedExpression);
                        results.Add($"{correctedExpression} = {result}");
                    }
                    catch (Exception ex)
                    {
                        results.Add($"{correctedExpression} = Loi: {ex.Message}");
                        check = false;
                        MessageBox.Show("File chỉ được chứa các phép toán cộng, trừ, nhân, chia!");
                    }
                }

                if (check)
                {
                    File.WriteAllLines(outputFile, results);

                    MessageBox.Show($"Hoan thanh! Kiem tra ket qua trong file '{outputFile}'.");
                }

                string filePath = "outputFormBai3.txt";
                try
                {
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        rtb_Content.Text = sr.ReadToEnd();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi đọc file: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Da xay ra loi khong mong muon: {ex.Message}");
            }
        }
    }
}


public static class ExpressionEvaluator
{
    private static int GetPrecedence(char op)
    {
        if (op == '+' || op == '-') return 1;
        if (op == '*' || op == '/') return 2;
        return 0;
    }

    private static double ApplyOperation(char op, double b, double a)
    {
        switch (op)
        {
            case '+': return a + b;
            case '-': return a - b;
            case '*': return a * b;
            case '/':
                if (b == 0) throw new DivideByZeroException("Khong the chia cho 0.");
                return a / b;
        }
        return 0;
    }

    public static double Evaluate(string expression)
    {
        Stack<double> values = new Stack<double>();
        Stack<char> ops = new Stack<char>();

        for (int i = 0; i < expression.Length; i++)
        {
            char c = expression[i];

            if (c == ' ') continue;

            if (char.IsDigit(c) || c == '.')
            {
                string sbuf = "";
                while (i < expression.Length && (char.IsDigit(expression[i]) || expression[i] == '.'))
                {
                    sbuf += expression[i++];
                }
                i--;
                values.Push(double.Parse(sbuf, CultureInfo.InvariantCulture));
            }
            else if (c == '(')
            {
                ops.Push(c);
            }
            else if (c == ')')
            {
                while (ops.Peek() != '(')
                {
                    values.Push(ApplyOperation(ops.Pop(), values.Pop(), values.Pop()));
                }
                ops.Pop();
            }
            else
            {
                if (c == '-')
                {
                    bool isUnary = (i == 0);
                    if (!isUnary)
                    {
                        int j = i - 1;
                        while (j >= 0 && expression[j] == ' ') j--;
                        if (j < 0 || "+-*/(".Contains(expression[j]))
                        {
                            isUnary = true;
                        }
                    }
                    if (isUnary)
                    {
                        values.Push(0);
                    }
                }

                while (ops.Count > 0 && GetPrecedence(ops.Peek()) >= GetPrecedence(c))
                {
                    values.Push(ApplyOperation(ops.Pop(), values.Pop(), values.Pop()));
                }
                ops.Push(c);
            }
        }

        while (ops.Count > 0)
        {
            values.Push(ApplyOperation(ops.Pop(), values.Pop(), values.Pop()));
        }

        return values.Pop();
    }
}