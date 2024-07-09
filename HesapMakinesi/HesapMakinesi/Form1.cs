using System.Text;
using WinFormsApp3;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        Double result = 0;
        string operation = string.Empty;
        string fstNum, secNum;
        bool enterValue = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void BynNum_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "0" || enterValue) textBox3.Text = string.Empty;

            enterValue = false;
            ArtanButton button = (ArtanButton)sender;
            if (button.Text == ",")
            {
                if (textBox3.Text.Contains(","))
                    textBox3.Text = textBox3.Text + button.Text;

            }
            else textBox3.Text = textBox3.Text + button.Text;


        }
        private void BtnHistory_Click(object sender, EventArgs e)
        {

        }
        private void BtnMathOpperation_Click(object sender, EventArgs e)
        {
            if (result != 0) BtnEquals.PerformClick();
            else result = Double.Parse(textBox3.Text);

            ArtanButton button = (ArtanButton)sender;
            operation = button.Text;
            enterValue = true;
            if (textBox3.Text != "0")
            {
                textBox1.Text = fstNum = $"{result}{operation}";
                textBox3.Text = string.Empty;
            }
        }

        private void BtnEquals_Click(object sender, EventArgs e)
        {
            secNum = textBox3.Text;
            textBox1.Text = $"{textBox1.Text}{textBox3.Text}";
            if (textBox3.Text != string.Empty)
            {
                if (textBox3.Text == "0") textBox1.Text = string.Empty;
                switch (operation)
                {
                    case "+":
                        textBox3.Text = (result + Double.Parse(textBox3.Text)).ToString();
                        richTextBox1.AppendText($"{fstNum} {secNum} = {textBox3.Text} \n");
                        break;
                    case "-":
                        textBox3.Text = (result - Double.Parse(textBox3.Text)).ToString();
                        richTextBox1.AppendText($"{fstNum} {secNum} = {textBox3.Text} \n");
                        break;
                    case "×":
                        textBox3.Text = (result * Double.Parse(textBox3.Text)).ToString();
                        richTextBox1.AppendText($"{fstNum} {secNum} = {textBox3.Text} \n");
                        break;
                    case "÷ ":
                        textBox3.Text = (result / Double.Parse(textBox3.Text)).ToString();
                        richTextBox1.AppendText($"{fstNum} {secNum} = {textBox3.Text} \n");
                        break;
                    default:
                        textBox1.Text = $"{textBox3.Text} = ";
                        break;
                }

                result = Double.Parse(textBox3.Text);
                operation = string.Empty;


            }
        }

        private void BtnBackSpace_Click(object sender, EventArgs e)
        {
            if (textBox3.Text.Length > 0)
            {
                textBox3.Text = textBox3.Text.Remove(textBox3.Text.Length - 1, 1);
            }
            if (textBox3.Text == string.Empty)
            {
                textBox3.Text = "0";
            }
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            textBox3.Text = "0";
            textBox1.Text = "0";
            result = 0;
        }

        private void BtnCE_Click(object sender, EventArgs e)
        {
            textBox3.Text = "0";

        }

        private void BtnOperations_Click(object sender, EventArgs e)
        {
            ArtanButton button = (ArtanButton)sender;
            operation = button.Text;
            switch (operation)
            {
                case " √x":
                    textBox1.Text = $"√({textBox3.Text})";
                    textBox3.Text = Convert.ToString(Math.Sqrt((Double.Parse(textBox3.Text))));
                    break;
                case "x²":
                    textBox1.Text = $"({textBox3.Text})";
                    textBox3.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) * Convert.ToDouble(textBox3.Text));
                    break;
                case "1/X":
                    textBox1.Text = $"1/({textBox3.Text})";
                    textBox3.Text = Convert.ToString(1.0 / Convert.ToDouble(textBox3.Text));
                    break;
                case "%":
                    textBox1.Text = $"%({textBox3.Text})";
                    textBox3.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) / Convert.ToDouble(100));
                    break;
                case "+/_":
                    textBox3.Text = Convert.ToString(-1 * Convert.ToDouble(textBox3.Text));
                    break;

                default:
                    break;
            }
            richTextBox1.AppendText($"{textBox1.Text}= {textBox3.Text}");
        }

        private void kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

