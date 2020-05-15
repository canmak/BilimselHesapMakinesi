using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilimselHesapMakinesiProjesi
{
    public partial class Form1 : Form
    {
        double sonuc;
        string aritmetikOperator;
        double ilkSayi;
        bool operatorClick = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bilimselTextBox.Text == "0"||operatorClick)

                bilimselTextBox.Clear();

            operatorClick = false;
            Button button = (Button)sender;

            if (button.Text == ".")
            {

                if (!bilimselTextBox.Text.Contains("."))
                    bilimselTextBox.Text += button.Text;
            }
            else
            {
                bilimselTextBox.Text += button.Text;
            }

            
  
        }

        private void button20_Click(object sender, EventArgs e)
        {
            int index = bilimselTextBox.Text.Length;
            index--;
            bilimselTextBox.Text = bilimselTextBox.Text.Remove(index);
            if(bilimselTextBox.Text==string.Empty)
            {
                bilimselTextBox.Text = "0";
            }

        }

        private void button17_Click(object sender, EventArgs e)
        {
            bilimselTextBox.Text = "0";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            sonuc = double.Parse(bilimselTextBox.Text);
            sonuc = sonuc * -1;
            bilimselTextBox.Text = sonuc.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ilkSayi = double.Parse(bilimselTextBox.Text);
            Button btn = (Button)sender;
            aritmetikOperator = btn.Text;
            operatorClick = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            switch(aritmetikOperator)
            {
                case "+":
                    bilimselTextBox.Text = (ilkSayi + double.Parse(bilimselTextBox.Text)).ToString();
                    break;
                case "-":
                    bilimselTextBox.Text = (ilkSayi - double.Parse(bilimselTextBox.Text)).ToString();
                    break;
                case "*":
                    bilimselTextBox.Text = (ilkSayi *double.Parse(bilimselTextBox.Text)).ToString();
                    break;
                case "/":
                    bilimselTextBox.Text = (ilkSayi / double.Parse(bilimselTextBox.Text)).ToString();
                    break;
                case "EXP":
                    double us = double.Parse(bilimselTextBox.Text);
                    double cevap = Math.Exp(us * Math.Log(ilkSayi * 4));
                    bilimselTextBox.Text = cevap.ToString();
                    break;
                case "MOD":
                    bilimselTextBox.Text = (ilkSayi % double.Parse(bilimselTextBox.Text)).ToString();
                    break;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            baslikLabel.Text = string.Empty;
            this.Width = 540;
        }

        private void dönüştürücüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 855;
        }

        private void bilimselToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 540;
        }

        private void çoğaltıcıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 1200;
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            baslikLabel.Text = string.Empty;
            double deger = Math.PI;
            bilimselTextBox.Text = deger.ToString();
            baslikLabel.Text = "PI";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            double deger = double.Parse(bilimselTextBox.Text);
            baslikLabel.Text = "LOG(" + deger + ")";
            deger = Math.Log10(deger);
            bilimselTextBox.Text = deger.ToString();
            
        }

        private void button21_Click(object sender, EventArgs e)
        {
            double deger = double.Parse(bilimselTextBox.Text);
            baslikLabel.Text = "Kare Kök(" + deger + ")";
            deger = Math.Sqrt(deger);
            bilimselTextBox.Text = deger.ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            double deger = double.Parse(bilimselTextBox.Text);
            baslikLabel.Text = deger+"^2";
            deger = Math.Pow(deger, 2);
            bilimselTextBox.Text = deger.ToString();

        }

        private void button33_Click(object sender, EventArgs e)
        {
            double deger = double.Parse(bilimselTextBox.Text);
            baslikLabel.Text = "Sinh(" + deger + ")";
            deger = Math.Sinh(deger);
            bilimselTextBox.Text = deger.ToString();

        }

        private void button32_Click(object sender, EventArgs e)
        {
            double deger = double.Parse(bilimselTextBox.Text);
            baslikLabel.Text = "Sin(" + deger + ")";
            deger = Math.Sin(deger);
            bilimselTextBox.Text = deger.ToString();

        }

        private void button31_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(bilimselTextBox.Text);
                baslikLabel.Text = "DECIMAL(" + bilimselTextBox.Text + ")";
                bilimselTextBox.Text = System.Convert.ToString(a, 10);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hata" + ex.Message,"Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            double deger = double.Parse(bilimselTextBox.Text);
            baslikLabel.Text = deger+"^3";
            deger = Math.Pow(deger, 3);
            bilimselTextBox.Text = deger.ToString();

        }

        private void button36_Click(object sender, EventArgs e)
        {
            double deger = double.Parse(bilimselTextBox.Text);

            baslikLabel.Text = "Cosh(" + deger + ")";
            deger = Math.Cosh(deger);
            bilimselTextBox.Text = deger.ToString();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            double deger = double.Parse(bilimselTextBox.Text);
            baslikLabel.Text = "Cos(" + deger + ")";
            deger = Math.Cos(deger);
            bilimselTextBox.Text = deger.ToString();

        }

        private void button39_Click(object sender, EventArgs e)
        {
            double deger = double.Parse(bilimselTextBox.Text);
            baslikLabel.Text = "Tanh(" + deger + ")";
            deger = Math.Tanh(deger);
            bilimselTextBox.Text = deger.ToString();
        }

        private void button38_Click(object sender, EventArgs e)
        {
            double deger = double.Parse(bilimselTextBox.Text);
            baslikLabel.Text = "Tan(" + deger + ")";
            deger = Math.Tan(deger);
            bilimselTextBox.Text = deger.ToString();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(bilimselTextBox.Text);
                baslikLabel.Text = "HEXADECIMAL(" + bilimselTextBox.Text + ")";
                bilimselTextBox.Text = System.Convert.ToString(a, 16);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            double deger = double.Parse(bilimselTextBox.Text);
            deger = 1 / deger;
            bilimselTextBox.Text = deger.ToString();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(bilimselTextBox.Text);
                baslikLabel.Text = "BINARY(" + bilimselTextBox.Text + ")";
                bilimselTextBox.Text = System.Convert.ToString(a, 2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            double deger = double.Parse(bilimselTextBox.Text);
            baslikLabel.Text = "Ln(" + deger + ")";
            deger = Math.Log(deger);
            bilimselTextBox.Text = deger.ToString();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(bilimselTextBox.Text);
                baslikLabel.Text = "OCTAL(" + bilimselTextBox.Text + ")";
                bilimselTextBox.Text = System.Convert.ToString(a, 8);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button28_Click(object sender, EventArgs e)
        {
            double deger = double.Parse(bilimselTextBox.Text);
            baslikLabel.Text = "YUZDE(" + deger + ")";
            deger = deger / 100;
            bilimselTextBox.Text = deger.ToString();
        }

        private void turetmeButonu_Click(object sender, EventArgs e)
        {
            TablorichTextBox.Clear();
            float numara = 0f;
            if(numaraTextBox.Text.Trim()==string.Empty)
            {

                MessageBox.Show("Lütfen herhangi bir sayı giriniz...","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            try
            {
                numara = Convert.ToSingle(numaraTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Geçersiz sayı...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for(int i=1; i<=10; i++)
            {
                TablorichTextBox.Text += numara + " * " + i + " = " + numara * i + " \n ";
            }
        }

        private void sifirlaButonu_Click(object sender, EventArgs e)
        {
            TablorichTextBox.Clear();
            numaraTextBox.Clear();
            numaraTextBox.Focus();
        }

        private void sicaklikDonusturmeButonu_Click(object sender, EventArgs e)
        {
            donusturmeTextBox.Clear();
            float sayi = 0f;
            if(sicaklikTextBox.Text.Trim()==string.Empty)
            {
                MessageBox.Show("Lütfen dönüştürmek istediğiniz bir sıcaklık değeri girin...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                sayi = Convert.ToSingle(sicaklikTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Geçersiz sayı...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(celFahRadioButton.Checked)
            {
                donusturmeTextBox.Text = ((sayi * 9 / 5) + 32).ToString();

            }
            if (fahCelRadioButton.Checked)
            {
                donusturmeTextBox.Text =( (sayi-32)*5/9).ToString();

            }
            if (kelCelRadioButton.Checked)
            {
                donusturmeTextBox.Text = (sayi -273.15) .ToString();

            }
            if (kelFahRadioButton.Checked)
            {
                donusturmeTextBox.Text = ((sayi -273.15)*9/5 + 32).ToString();

            }
        }

        private void sicaklikSifirlamaButonu_Click(object sender, EventArgs e)
        {
            donusturmeTextBox.Clear();
            sicaklikTextBox.Clear();
            sicaklikTextBox.Focus();
        }

        private void bilimselTextBox_TextChanged(object sender, EventArgs e)
        {
            Genel.gecmis.Add(bilimselTextBox.Text);
        }

        private void geçmişiGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gecmis gecmis = new Gecmis();
            gecmis.ShowDialog();
        }
    }
}
