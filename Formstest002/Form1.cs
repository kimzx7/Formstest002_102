namespace Formstest002
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*double weight = Convert.ToDouble(textBox1.Text);
            double hight = Convert.ToDouble(textBox2.Text);*/
            double weight = 0;
            double hight = 0;
            if (!double.TryParse(textBox1.Text, out weight))
            {
                textBox1.Text="0";
                return;

            }
            if(!double.TryParse(textBox2.Text, out hight))
            {
                textBox2.Text="0";
                return;

            }

            double sum_1 = weight / Math.Pow(hight / 100, 2);
            string result = "";
            if (sum_1 < 18.5)
            {
                result = "���";
            }
            else if (sum_1 < 25)
            {
                result = "����";
            }
            else if (sum_1 < 30)
            {
                result = "��ǹ";
            }
            else
            {
                result = "�ä��ǹ";
            }
            label3.Text = "���BMI = " + sum_1.ToString("F2");
            label4.Text = "���Ѿ��= " + result;
        }
    }
}
