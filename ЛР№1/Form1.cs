namespace ЛР_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0)
            {
                MessageBox.Show("Введите число", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (radioButton1.Checked == false &&
                radioButton2.Checked == false &&
                radioButton3.Checked == false &&
                radioButton4.Checked == false &&
                radioButton5.Checked == false &&
                radioButton6.Checked == false)
            {
                MessageBox.Show("Выберите единицу измерения, в которую необходимо конвертироовать", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            double ch = Convert.ToDouble(textBox1.Text);
            int key = comboBox1.SelectedIndex;
            switch (key)
            {
                case 1:
                    if (radioButton4.Checked == true)
                    {
                        ch = ch * 1000;
                        listBox1.Items.Add ( Convert.ToDouble(textBox1.Text) + " Км = " + ch + " м. ");
                    }
                    if (radioButton3.Checked == true)
                    {
                        listBox1.Items.Add ( Convert.ToDouble(textBox1.Text) + " Км = " + ch + " Км. ");
                    }
                    if (radioButton2.Checked == true)
                    {
                        ch = ch * 3280.84;
                        listBox1.Items.Add ( Convert.ToDouble(textBox1.Text) + " Км = " + ch + " Фут(ов). ");
                    }
                    if (radioButton1.Checked == true)
                    {
                        ch = ch * 39370.08;
                        listBox1.Items.Add ( Convert.ToDouble(textBox1.Text) + " Км = " + ch + " Дюймы(ов). ");
                    }
                    if (radioButton5.Checked == true)
                    {
                        ch = ch * 0.6214;
                        listBox1.Items.Add(Convert.ToDouble(textBox1.Text) + " Км = " + ch + " Мили.");
                    }
                    if (radioButton6.Checked == true)
                    {
                        ch = ch * 0.9374;
                        listBox1.Items.Add(Convert.ToDouble(textBox1.Text) + " Км = " + ch + " Версты ");
                    }
                    break;
                case 2:
                    if (radioButton4.Checked == true)
                    {
                        ch = ch * 0.025;
                        listBox1.Items.Add ( Convert.ToDouble(textBox1.Text) + " Дюймы(ов) = " + ch + " м. ");
                    }
                    if (radioButton3.Checked == true)
                    {
                        ch = ch * 0.000025;
                        listBox1.Items.Add ( Convert.ToDouble(textBox1.Text) + " Дюймы(ов) = " + ch + " Км. ");
                    }
                    if (radioButton2.Checked == true)
                    {
                        ch = ch * 0.083;
                        listBox1.Items.Add ( Convert.ToDouble(textBox1.Text) + " Дюймы(ов) = " + ch + " Фут(ов). ");
                    }
                    if (radioButton1.Checked == true)
                    {
                        listBox1.Items.Add ( Convert.ToDouble(textBox1.Text) + " Дюймы(ов) = " + ch + " Дюймы(ов). ");
                    }
                    if (radioButton5.Checked == true)
                    {
                        ch = ch * 0.000016;
                        listBox1.Items.Add(Convert.ToDouble(textBox1.Text) + " Дюймы(ов) = " + ch + " Мили.");
                    }
                    if (radioButton6.Checked == true)
                    {
                        ch = ch * 0.000024;
                        listBox1.Items.Add(Convert.ToDouble(textBox1.Text) + " Дюймы(ов) = " + ch + " Версты ");
                    }
                    break;
                case 3:
                    if (radioButton4.Checked == true)
                    {
                        ch = ch * 0.3;
                        listBox1.Items.Add ( Convert.ToDouble(textBox1.Text) + " Фут(ов) = " + ch + " м. ");
                    }
                    if (radioButton3.Checked == true)
                    {
                        ch = ch * 0.000;
                        listBox1.Items.Add ( Convert.ToDouble(textBox1.Text) + " Фут(ов) = " + ch + " Км. ");
                    }
                    if (radioButton2.Checked == true)
                    {
                        listBox1.Items.Add ( Convert.ToDouble(textBox1.Text) + " Фут(ов) = " + ch + " Фут(ов). ");
                    }
                    if (radioButton1.Checked == true)
                    {
                        ch = ch * 12;
                        listBox1.Items.Add ( Convert.ToDouble(textBox1.Text) + " Фут(ов) = " + ch + " Дюймы(ов). ");
                    }
                    if (radioButton5.Checked == true)
                    {
                        ch = ch * 0.00019;
                        listBox1.Items.Add(Convert.ToDouble(textBox1.Text) + " Фут(ов) = " + ch + " Мили.");
                    }
                    if (radioButton6.Checked == true)
                    {
                        ch = ch * 0.00029;
                        listBox1.Items.Add(Convert.ToDouble(textBox1.Text) + " Фут(ов) = " + ch + " Версты ");
                    }
                    break;

                case 4:               
                    if (radioButton4.Checked == true)
                    {

                        listBox1.Items.Add ( Convert.ToDouble(textBox1.Text) + " м = " + ch + " м. ");
                    }
                    if (radioButton3.Checked == true)
                    {
                        ch = ch * 0.001;
                        listBox1.Items.Add ( Convert.ToDouble(textBox1.Text) + " м = " + ch + " Км. ");
                    }
                    if (radioButton2.Checked == true)
                    {
                        ch = ch * 3.28;
                        listBox1.Items.Add ( Convert.ToDouble(textBox1.Text) + " м = " + ch + " Фут(ов). ");
                    }
                    if (radioButton1.Checked == true)
                    {
                        ch = ch * 39.37;
                        listBox1.Items.Add ( Convert.ToDouble(textBox1.Text) + " м = " + ch + " Дюймы(ов). ");
                    }
                    if (radioButton5.Checked == true)
                    {
                        ch = ch * 0.00062;
                        listBox1.Items.Add(Convert.ToDouble(textBox1.Text) + " м = " + ch + " Мили.");
                    }
                    if (radioButton6.Checked == true)
                    {
                        ch = ch * 0.00094;
                        listBox1.Items.Add(Convert.ToDouble(textBox1.Text) + " м = " + ch + " Версты ");
                    }
                    break;

                case 5:
                    if (radioButton4.Checked == true)
                    {
                        ch = ch * 1609.34;
                        listBox1.Items.Add(Convert.ToDouble(textBox1.Text) + " Миля = " + ch + " м. ");
                    }
                    if (radioButton3.Checked == true)
                    {
                        ch = ch * 1.609;
                        listBox1.Items.Add(Convert.ToDouble(textBox1.Text) + " Миля = " + ch + " Км. ");
                    }
                    if (radioButton2.Checked == true)
                    {
                        ch = ch * 5280;
                        listBox1.Items.Add(Convert.ToDouble(textBox1.Text) + " Мили = " + ch + " Фут(ов). ");
                    }
                    if (radioButton1.Checked == true)
                    {
                        ch = ch * 63360;
                        listBox1.Items.Add(Convert.ToDouble(textBox1.Text) + " Мили = " + ch + " Дюймы(ов). ");
                    }
                    if (radioButton5.Checked == true)
                    {
                        listBox1.Items.Add(Convert.ToDouble(textBox1.Text) + " Мили = " + ch + " Мили.");
                    }
                    if (radioButton6.Checked == true)
                    {
                        ch = ch * 1.51;
                        listBox1.Items.Add(Convert.ToDouble(textBox1.Text) + " Мили = " + ch + " Версты ");
                    }
                    break;

                 default:
                    if (radioButton4.Checked == true)
                    {
                        ch = ch * 1066.8;
                        listBox1.Items.Add(Convert.ToDouble(textBox1.Text) + " Версты = " + ch + " м. ");
                    }
                    if (radioButton3.Checked == true)
                    {
                        ch = ch * 1.07;
                        listBox1.Items.Add(Convert.ToDouble(textBox1.Text) + " Версты = " + ch + " Км. ");
                    }
                    if (radioButton2.Checked == true)
                    {
                        ch = ch * 3500;
                        listBox1.Items.Add(Convert.ToDouble(textBox1.Text) + " Версты = " + ch + " Фут(ов). ");
                    }
                    if (radioButton1.Checked == true)
                    {
                        ch = ch * 42000;
                        listBox1.Items.Add(Convert.ToDouble(textBox1.Text) + " Версты = " + ch + " Дюймы(ов). ");
                    }
                    if (radioButton5.Checked == true)
                    {
                        ch = ch * 0.66;
                        listBox1.Items.Add(Convert.ToDouble(textBox1.Text) + " Версты = " + ch + " Мили.");
                    }
                    if (radioButton6.Checked == true)
                    {
                        
                        listBox1.Items.Add(Convert.ToDouble(textBox1.Text) + " Версты = " + ch + " Версты ");
                    }

                    break;
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}