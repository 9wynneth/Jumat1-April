using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jumat1_April
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string AngkaPenyimpan1 = "";
        public string AngkaPenyimpan2 = "";
        public double Hasil;
        public string Operasi = "";
        public bool MathProcess = false;
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_persentage_Click(object sender, EventArgs e)
        {

        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            if (MathProcess == false)
            {
                AngkaPenyimpan1 += 0;
                txtBoxInput.Text = AngkaPenyimpan1;
            }
            else
            {
                AngkaPenyimpan2 += 0;
                txtBoxInput.Text = AngkaPenyimpan1 + Operasi + AngkaPenyimpan2;
            }
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            if (MathProcess == false)
            {
                AngkaPenyimpan1 += 1;
                txtBoxInput.Text = AngkaPenyimpan1;
            }
            else
            {
                AngkaPenyimpan2 += 1;
                txtBoxInput.Text = AngkaPenyimpan1 + Operasi + AngkaPenyimpan2;
            }
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            if (MathProcess == false)
            {
                AngkaPenyimpan1 += 2;
                txtBoxInput.Text = AngkaPenyimpan1;
            }
            else
            {
                AngkaPenyimpan2 += 2;
                txtBoxInput.Text = AngkaPenyimpan1 + Operasi + AngkaPenyimpan2;
            }
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (MathProcess == false)
            {
                AngkaPenyimpan1 += 3;
                txtBoxInput.Text = AngkaPenyimpan1;
            }
            else
            {
                AngkaPenyimpan2 += 3;
                txtBoxInput.Text = AngkaPenyimpan1 + Operasi + AngkaPenyimpan2;
            }
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (MathProcess == false)
            {
                AngkaPenyimpan1 += 4;
                txtBoxInput.Text = AngkaPenyimpan1;
            }
            else
            {
                AngkaPenyimpan2 += 4;
                txtBoxInput.Text = AngkaPenyimpan1 + Operasi + AngkaPenyimpan2;
            }
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (MathProcess == false)
            {
                AngkaPenyimpan1 += 5;
                txtBoxInput.Text = AngkaPenyimpan1;
            }
            else
            {
                AngkaPenyimpan2 += 5;
                txtBoxInput.Text = AngkaPenyimpan1 + Operasi + AngkaPenyimpan2;
            }
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (MathProcess == false)
            {
                AngkaPenyimpan1 += 6;
                txtBoxInput.Text = AngkaPenyimpan1;
            }
            else
            {
                AngkaPenyimpan2 += 6;
                txtBoxInput.Text = AngkaPenyimpan1 + Operasi + AngkaPenyimpan2;
            }
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (MathProcess == false)
            {
                AngkaPenyimpan1 += 7;
                txtBoxInput.Text = AngkaPenyimpan1;
            }
            else
            {
                AngkaPenyimpan2 += 7;
                txtBoxInput.Text = AngkaPenyimpan1 + Operasi + AngkaPenyimpan2;
            }
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (MathProcess == false)
            {
                AngkaPenyimpan1 += 8;
                txtBoxInput.Text = AngkaPenyimpan1;
            }
            else
            {
                AngkaPenyimpan2 += 8;
                txtBoxInput.Text = AngkaPenyimpan1 + Operasi + AngkaPenyimpan2;
            }
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (MathProcess == false)
            {
                AngkaPenyimpan1 += 9;
                txtBoxInput.Text = AngkaPenyimpan1;
            }
            else
            {
                AngkaPenyimpan2 += 9;
                txtBoxInput.Text = AngkaPenyimpan1 + Operasi + AngkaPenyimpan2;
            }
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            txtBoxInput.Clear();
            txtBoxInput.Text = "0";
            AngkaPenyimpan1 = "";
            MathProcess = false;
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            Operasi = "-";
            txtBoxInput.Text = AngkaPenyimpan1 + Operasi;
            MathProcess = true;
        }

        private void btn_samadengan_Click(object sender, EventArgs e)
        {
            if (Operasi == "-")
            {
                Hasil = Convert.ToDouble(AngkaPenyimpan1) - Convert.ToDouble(AngkaPenyimpan2);
            }
            else if (Operasi=="+")
            {
                Hasil = Convert.ToDouble(AngkaPenyimpan1) + Convert.ToDouble(AngkaPenyimpan2);
            }
            else if (Operasi == "*")
            {
                Hasil = Convert.ToDouble(AngkaPenyimpan1) * Convert.ToDouble(AngkaPenyimpan2);
            }
            else if (Operasi == "/")
            {
                Hasil = Convert.ToDouble(AngkaPenyimpan1) / Convert.ToDouble(AngkaPenyimpan2);
            }
            txtBoxInput.Text = Convert.ToString(Hasil);
            MathProcess = false;
            AngkaPenyimpan1 = Convert.ToString(Hasil);
            AngkaPenyimpan2 = "";

        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            Operasi = "+";
            txtBoxInput.Text = AngkaPenyimpan1 + Operasi;
            MathProcess = true;
        }

        private void btn_pembagian_Click(object sender, EventArgs e)
        {
            Operasi = "/";
            txtBoxInput.Text = AngkaPenyimpan1 + Operasi;
            MathProcess = true;
        }

        private void btn_perkalian_Click(object sender, EventArgs e)
        {
            Operasi = "*";
            txtBoxInput.Text = AngkaPenyimpan1 + Operasi;
            MathProcess = true;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (MathProcess == false)
            {
                if (AngkaPenyimpan1.Length > 0)
                {
                    AngkaPenyimpan1 = AngkaPenyimpan1.Remove(AngkaPenyimpan1.Length - 1);
                    txtBoxInput.Text = AngkaPenyimpan1;
                }
            }
            else
            {
                if (AngkaPenyimpan2.Length > 0)
                {
                    AngkaPenyimpan2 = AngkaPenyimpan2.Remove(AngkaPenyimpan2.Length - 1);
                    txtBoxInput.Text = AngkaPenyimpan1 + Operasi + AngkaPenyimpan2;
                }
            }

        }

            private void btn_CE_Click(object sender, EventArgs e)
        {
            if (MathProcess == false)
            {
                AngkaPenyimpan1 = "";
                txtBoxInput.Text = AngkaPenyimpan1;
            }
            else
            {
                AngkaPenyimpan2 = "";
                txtBoxInput.Text = AngkaPenyimpan1 + Operasi;
            }
            //txtBoxInput.Text = AngkaPenyimpan2.Remove
        }

        private void btn_fraction_Click(object sender, EventArgs e)
        {
            if (MathProcess==false)
            {
                AngkaPenyimpan1 = $"{1 / Convert.ToDouble(AngkaPenyimpan1)}";
                txtBoxInput.Text = AngkaPenyimpan1;
            }
            else
            {
                AngkaPenyimpan2= $"{1 / Convert.ToDouble(AngkaPenyimpan2)}";
                txtBoxInput.Text = AngkaPenyimpan1 + Operasi+AngkaPenyimpan2;
            }
        }

        private void btn_kuadrat_Click(object sender, EventArgs e)
        {
            if (MathProcess == false)
            {
                AngkaPenyimpan1 = Convert.ToString(Convert.ToDouble(AngkaPenyimpan1 )* Convert.ToDouble(AngkaPenyimpan1));
                txtBoxInput.Text = AngkaPenyimpan1;
            }
            else
            {
                AngkaPenyimpan2 = Convert.ToString(Convert.ToDouble(AngkaPenyimpan2) * Convert.ToDouble(AngkaPenyimpan2));
                txtBoxInput.Text = AngkaPenyimpan1 + Operasi + AngkaPenyimpan2;
            }
        }

        private void btn_akar2_Click(object sender, EventArgs e)
        {
            if (MathProcess == false)
            {
                AngkaPenyimpan1 = Convert.ToString(Math.Sqrt(Convert.ToDouble(AngkaPenyimpan1)));
                txtBoxInput.Text = AngkaPenyimpan1;
            }
            else
            {
                AngkaPenyimpan2 = Convert.ToString(Math.Sqrt(Convert.ToDouble(AngkaPenyimpan2)));
                txtBoxInput.Text = AngkaPenyimpan2 + Operasi + AngkaPenyimpan2;
            }
        }

        private void btn_plusatomin_Click(object sender, EventArgs e)
        {
            if (AngkaPenyimpan1[0]!='-')
            {
                AngkaPenyimpan1=AngkaPenyimpan1.Insert(0, "-");
                txtBoxInput.Text = AngkaPenyimpan1;
            }
            else if (AngkaPenyimpan1[0]=='-')
            {
                AngkaPenyimpan1 = AngkaPenyimpan1.Remove('-');
                txtBoxInput.Text = AngkaPenyimpan1;
            }
        }
    }
}
