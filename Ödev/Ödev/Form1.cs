namespace Ödev
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }
        string onceki;
        private double yenitahmin;
        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            if (a < 0)
            {
                a = -a;
            }
            else
            {
                a = a;
            }
            textBox1.Text = a.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = onceki;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            onceki = textBox1.Text;

            string metin = textBox1.Text;
            string[] v = metin.Split(',');

            int enb = int.MinValue;

            for (int i = 0; i < v.Length; i++)
            {
                int sayi;
                if (int.TryParse(v[i], out sayi))
                {
                    if (sayi > enb)
                    {
                        enb = sayi;
                    }
                }
            }
            textBox1.Text = enb.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sayi;
            onceki = textBox1.Text;
            if (double.TryParse(textBox1.Text, out sayi))
            {
                double karekok = KareKokBul(sayi);
                textBox1.Text = karekok.ToString();
            }

            double KareKokBul(double y)
            {
                double karekok = y / 2;

                while (true)
                {
                    double yenitahmin = ((y / karekok) + karekok) / 2;
                    double sonuc;
                    if ((yenitahmin - karekok) < 0)
                    {
                        sonuc = (yenitahmin - karekok) * -1;
                    }
                    else
                    {
                        sonuc = yenitahmin - karekok;
                    }
                    if (sonuc < 0.0001)
                    {
                        break;
                    }
                    karekok = yenitahmin;
                }
                return karekok;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            onceki = textBox1.Text;

            if (double.TryParse(textBox1.Text, out double acidegeri))
            {
                double sinus = SinusHesapla(acidegeri);
                textBox1.Text = sinus.ToString();
            }

            double SinusHesapla(double aci)
            {
                double radyan = DereceRadyan(aci);

                double sonuc = 0;
                int isaret = 1;
                for (int n = 0; n < 10; n++)
                {
                    sonuc = sonuc + isaret * ((UsAl(radyan, 2 * n + 1) / Faktoriyel(2 * n + 1)));
                    isaret = isaret * -1;
                }
                return sonuc;
            }

            double DereceRadyan(double derece)
            {
                return ((derece * 3.14159) / 180);
            }

            double UsAl(double taban, int us)
            {
                double sonuc = 1;
                for (int i = 0; i < us; i++)
                {
                    sonuc = sonuc * taban;
                }
                return sonuc;
            }

            double Faktoriyel(int n)
            {
                double fak = 1;
                for (int i = 1; i <= n; i++)
                {
                    fak = fak * i;
                }
                return fak;

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            onceki = textBox1.Text;

            if (double.TryParse(textBox1.Text, out double acidegeri))
            {
                double sinus = SinusHesapla(acidegeri);   
                textBox1.Text = sinus.ToString();   
            }

            double SinusHesapla(double aci)
            {
                double radyan = DereceRadyan(aci);  

                double sonuc = 0;
                int isaret = 1;
                for (int n = 0; n < 10; n++)
                {
                    sonuc = sonuc + (isaret * (UsAl(radyan, 2 * n) / Faktoriyel(2 * n))); 
                    isaret = isaret * -1; 
                }
                return sonuc;
            }

            double DereceRadyan(double derece)
            {
                return ((derece * 3.14159) / 180);  
            }

            double UsAl(double taban, int us)
            {
                double sonuc = 1;
                for (int i = 0; i < us; i++)
                {
                    sonuc = sonuc * taban;
                }
                return sonuc;
            }

            double Faktoriyel(int n)
            {
                double fak = 1;
                for (int i = 1; i <= n; i++)
                {
                    fak = fak * i;
                }
                return fak;
            }

        }
    }
}
