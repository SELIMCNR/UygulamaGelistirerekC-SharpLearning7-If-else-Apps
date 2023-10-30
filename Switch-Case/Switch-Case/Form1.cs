namespace Switch_Case
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ay = Convert.ToInt16(textBox1.Text);
            switch (ay)
            {
                case 1: label1.Text = "Ocak"; break;
                case 2: label1.Text = "�ubat"; break;
                case 3: label1.Text = "Mart"; break;
                case 4: label1.Text = "Nisan"; break;
                case 5: label1.Text = "May�s"; break;
                case 6: label1.Text = "Haziran"; break;
                case 7: label1.Text = "Temmuz"; break;
                case 8: label1.Text = "A�ustos"; break;
                case 9: label1.Text = "Eyl�l"; break;
                case 10: label1.Text = "Ekim"; break;
                case 11: label1.Text = "Kas�m"; break;
                case 12: label1.Text = "Aral�k"; break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mevsim = textBox2.Text;
            switch (mevsim)
            {
                case "yaz":
                    label4.Text = "Haziran temmuz a�ustos";
                    break;
                case "sonbahar":
                    label4.Text = "Eyl�l ekim kas�m";
                    break;
                case "k��":
                    label4.Text = "Aral�k Ocak �ubat";
                    break;
                case "ilkbahar":
                    label4.Text = "Mart Nisan May�s";
                    break;

                default: label4.Text = "Hatal� mevsim "; break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2;
            string islem, sonuc;
            sayi1 = Convert.ToInt32(textBox3.Text);
            sayi2 = Convert.ToInt32(textBox5.Text);
            islem = textBox4.Text;
            switch (islem)
            {
                case "+":
                    sonuc = (sayi1 + sayi2).ToString();
                    label5.Text = sonuc;
                    break;
                case "-":
                    sonuc = (sayi1 - sayi2).ToString();
                    label5.Text = sonuc;
                    break;
                case "*":
                    sonuc = (sayi1 * sayi2).ToString();
                    label5.Text = sonuc;
                    break;
                case "/":
                    sonuc = (sayi1 / sayi2).ToString();
                    break;
            }
        }
    }
}