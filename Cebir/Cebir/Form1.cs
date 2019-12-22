using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cebir
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

        private void button2_Click(object sender, EventArgs e)//Çıkartma
        {
            int box11, box12, box13, box21, box22, box23, box31, box32, box33;
            box11 = Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox10.Text);
            box12 = Convert.ToInt32(textBox2.Text) - Convert.ToInt32(textBox11.Text);
            box13 = Convert.ToInt32(textBox3.Text) - Convert.ToInt32(textBox12.Text);
            box21 = Convert.ToInt32(textBox4.Text) - Convert.ToInt32(textBox13.Text);
            box22 = Convert.ToInt32(textBox5.Text) - Convert.ToInt32(textBox14.Text);
            box23 = Convert.ToInt32(textBox6.Text) - Convert.ToInt32(textBox15.Text);
            box31 = Convert.ToInt32(textBox7.Text) - Convert.ToInt32(textBox16.Text);
            box32 = Convert.ToInt32(textBox8.Text) - Convert.ToInt32(textBox17.Text);
            box33 = Convert.ToInt32(textBox9.Text) - Convert.ToInt32(textBox18.Text);

            label3.Text = box11.ToString();
            label4.Text = box12.ToString();
            label5.Text = box13.ToString();
            label6.Text = box21.ToString();
            label7.Text = box22.ToString();
            label8.Text = box23.ToString();
            label9.Text = box31.ToString();
            label10.Text = box32.ToString();
            label11.Text = box33.ToString();
        }

        private void button1_Click(object sender, EventArgs e)//Topama
        {
            int box11, box12, box13, box21, box22, box23, box31, box32, box33;
            box11 = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox10.Text);
            box12 = Convert.ToInt32(textBox2.Text) + Convert.ToInt32(textBox11.Text);
            box13 = Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox12.Text);
            box21 = Convert.ToInt32(textBox4.Text) + Convert.ToInt32(textBox13.Text);
            box22 = Convert.ToInt32(textBox5.Text) + Convert.ToInt32(textBox14.Text);
            box23 = Convert.ToInt32(textBox6.Text) + Convert.ToInt32(textBox15.Text);
            box31 = Convert.ToInt32(textBox7.Text) + Convert.ToInt32(textBox16.Text);
            box32 = Convert.ToInt32(textBox8.Text) + Convert.ToInt32(textBox17.Text);
            box33 = Convert.ToInt32(textBox9.Text) + Convert.ToInt32(textBox18.Text);

            label3.Text = box11.ToString();
            label4.Text = box12.ToString();
            label5.Text = box13.ToString();
            label6.Text = box21.ToString();
            label7.Text = box22.ToString();
            label8.Text = box23.ToString();
            label9.Text = box31.ToString();
            label10.Text = box32.ToString();
            label11.Text = box33.ToString();
            

        }

        private void button4_Click(object sender, EventArgs e)//Kapat Butonu
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)//Çarpma
        {
            //147 258 369  13 14 15
            int box11, box12, box13, box21, box22, box23, box31, box32, box33;
            box11 = Convert.ToInt32(textBox7.Text) * Convert.ToInt32(textBox12.Text) + Convert.ToInt32(textBox4.Text) * Convert.ToInt32(textBox11.Text) + Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox10.Text);
            box12 = Convert.ToInt32(textBox8.Text) * Convert.ToInt32(textBox12.Text) + Convert.ToInt32(textBox5.Text) * Convert.ToInt32(textBox11.Text) + Convert.ToInt32(textBox2.Text) * Convert.ToInt32(textBox10.Text);
            box13 = Convert.ToInt32(textBox9.Text) * Convert.ToInt32(textBox12.Text) + Convert.ToInt32(textBox6.Text) * Convert.ToInt32(textBox11.Text) + Convert.ToInt32(textBox3.Text) * Convert.ToInt32(textBox10.Text);
            box21 = Convert.ToInt32(textBox7.Text) * Convert.ToInt32(textBox15.Text) + Convert.ToInt32(textBox4.Text) * Convert.ToInt32(textBox14.Text) + Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox13.Text);
            box22 = Convert.ToInt32(textBox8.Text) * Convert.ToInt32(textBox15.Text) + Convert.ToInt32(textBox5.Text) * Convert.ToInt32(textBox14.Text) + Convert.ToInt32(textBox2.Text) * Convert.ToInt32(textBox13.Text);
            box23 = Convert.ToInt32(textBox9.Text) * Convert.ToInt32(textBox15.Text) + Convert.ToInt32(textBox6.Text) * Convert.ToInt32(textBox14.Text) + Convert.ToInt32(textBox3.Text) * Convert.ToInt32(textBox13.Text);
            box31 = Convert.ToInt32(textBox7.Text) * Convert.ToInt32(textBox18.Text) + Convert.ToInt32(textBox4.Text) * Convert.ToInt32(textBox17.Text) + Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox16.Text);
            box32 = Convert.ToInt32(textBox8.Text) * Convert.ToInt32(textBox18.Text) + Convert.ToInt32(textBox5.Text) * Convert.ToInt32(textBox17.Text) + Convert.ToInt32(textBox2.Text) * Convert.ToInt32(textBox16.Text);
            box33 = Convert.ToInt32(textBox9.Text) * Convert.ToInt32(textBox18.Text) + Convert.ToInt32(textBox6.Text) * Convert.ToInt32(textBox17.Text) + Convert.ToInt32(textBox3.Text) * Convert.ToInt32(textBox16.Text);
            
            
            label3.Text = box11.ToString();
            label4.Text = box12.ToString();
            label5.Text = box13.ToString();
            label6.Text = box21.ToString();
            label7.Text = box22.ToString();
            label8.Text = box23.ToString();
            label9.Text = box31.ToString();
            label10.Text = box32.ToString();
            label11.Text = box33.ToString();

        }

        private void button5_Click(object sender, EventArgs e)//Sabit Bir Sayı İle Çarpma
        {
            int box11, box12, box13, box21, box22, box23, box31, box32, box33;
            box11 = Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox19.Text);
            box12= Convert.ToInt32(textBox2.Text) * Convert.ToInt32(textBox19.Text);
            box13 = Convert.ToInt32(textBox3.Text) * Convert.ToInt32(textBox19.Text);
            box21 = Convert.ToInt32(textBox4.Text) * Convert.ToInt32(textBox19.Text);
            box22 = Convert.ToInt32(textBox5.Text) * Convert.ToInt32(textBox19.Text);
            box23 = Convert.ToInt32(textBox6.Text) * Convert.ToInt32(textBox19.Text);
            box31 = Convert.ToInt32(textBox7.Text) * Convert.ToInt32(textBox19.Text);
            box32 = Convert.ToInt32(textBox8.Text) * Convert.ToInt32(textBox19.Text);
            box33 = Convert.ToInt32(textBox9.Text) * Convert.ToInt32(textBox19.Text);

            label3.Text = box11.ToString();
            label4.Text = box12.ToString();
            label5.Text = box13.ToString();
            label6.Text = box21.ToString();
            label7.Text = box22.ToString();
            label8.Text = box23.ToString();
            label9.Text = box31.ToString();
            label10.Text = box32.ToString();
            label11.Text = box33.ToString();
        }
        private void button6_Click(object sender, EventArgs e)//Determinant Alma 
        {
            int box11, box12, box13, box21, box22, box23, box31, box32, box33, sonuc;
            box11 = Convert.ToInt32(textBox1.Text);
            box12 = Convert.ToInt32(textBox2.Text);
            box13 = Convert.ToInt32(textBox3.Text);
            box21 = Convert.ToInt32(textBox4.Text);
            box22 = Convert.ToInt32(textBox5.Text);
            box23 = Convert.ToInt32(textBox6.Text);
            box31 = Convert.ToInt32(textBox7.Text);
            box32 = Convert.ToInt32(textBox8.Text);
            box33 = Convert.ToInt32(textBox9.Text);

            sonuc = ((box11 * box22 * box33 + box21 * box32 * box13 + box31 * box12 * box23) - (box13 * box22 * box31 + box23 * box32 * box11 + box12 * box21 * box33));
            label14.Text = sonuc.ToString();



        }
        private void button7_Click(object sender, EventArgs e)//Tersini Alma
        {
            float box11, box12, box13, box21, box22, box23, box31, box32, box33, sonuc;
            box11 = Convert.ToInt32(textBox1.Text);
            box12 = Convert.ToInt32(textBox2.Text);
            box13 = Convert.ToInt32(textBox3.Text);
            box21 = Convert.ToInt32(textBox4.Text);
            box22 = Convert.ToInt32(textBox5.Text);
            box23 = Convert.ToInt32(textBox6.Text);
            box31 = Convert.ToInt32(textBox7.Text);
            box32 = Convert.ToInt32(textBox8.Text);
            box33 = Convert.ToInt32(textBox9.Text);

            sonuc = ((box11 * box22 * box33 + box21 * box32 * box13 + box31 * box12 * box23) - (box13 * box22 * box31 + box23 * box32 * box11 + box12 * box21 * box33));

            if (sonuc == 0)
            {
                MessageBox.Show("Bu matrisin determinantı 0 a eşittir tersi alınamaz.", "HATA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                box11 = ((box22 * box33) - (-box23 * (-box32)));
                box12 = ((-box12 * box33) - (box13 * (-box32)));
                box13 = ((-box12 * (-box23)) - (box13 * box22));
                box21 = ((-box21 * box33) - (-box23 * box32));
                box22 = ((box11 * box33) - (box13 * box31));
                box23 = ((box22 * box33) - (-box23 * (-box32)));
                box31 = ((-box21 * (-box32)) - (box22 * box31));
                box32 = ((box11 * (-box32)) - (-box12 * box31));
                box33 = ((box11 * box22) - (-box12 * (-box21)));

                label3.Text = ((1 / sonuc) * box11).ToString();
                label4.Text = ((1 / sonuc) * box12).ToString();
                label5.Text = ((1 / sonuc) * box13).ToString();
                label6.Text = ((1 / sonuc) * box21).ToString();
                label7.Text = ((1 / sonuc) * box22).ToString();
                label8.Text = ((1 / sonuc) * box23).ToString();
                label9.Text = ((1 / sonuc) * box31).ToString();
                label10.Text = ((1 / sonuc) * box32).ToString();
                label11.Text = ((1 / sonuc) * box33).ToString();

            }
        }
        
        
        private void button8_Click(object sender, EventArgs e)// İnvolutif OLMA OLMAMA SORGULAMA
        {
            int box11, box12, box13, box21, box22, box23, box31, box32, box33;
            box11 = Convert.ToInt32(textBox7.Text) * Convert.ToInt32(textBox7.Text) + Convert.ToInt32(textBox4.Text) * Convert.ToInt32(textBox4.Text) + Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox1.Text);
            box12 = Convert.ToInt32(textBox7.Text) * Convert.ToInt32(textBox8.Text) + Convert.ToInt32(textBox4.Text) * Convert.ToInt32(textBox5.Text) + Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text);
            box13 = Convert.ToInt32(textBox7.Text) * Convert.ToInt32(textBox9.Text) + Convert.ToInt32(textBox4.Text) * Convert.ToInt32(textBox6.Text) + Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox3.Text);
            box21 = Convert.ToInt32(textBox8.Text) * Convert.ToInt32(textBox7.Text) + Convert.ToInt32(textBox5.Text) * Convert.ToInt32(textBox4.Text) + Convert.ToInt32(textBox2.Text) * Convert.ToInt32(textBox1.Text);
            box22 = Convert.ToInt32(textBox8.Text) * Convert.ToInt32(textBox8.Text) + Convert.ToInt32(textBox5.Text) * Convert.ToInt32(textBox5.Text) + Convert.ToInt32(textBox2.Text) * Convert.ToInt32(textBox2.Text);
            box23 = Convert.ToInt32(textBox8.Text) * Convert.ToInt32(textBox9.Text) + Convert.ToInt32(textBox5.Text) * Convert.ToInt32(textBox6.Text) + Convert.ToInt32(textBox2.Text) * Convert.ToInt32(textBox3.Text);
            box31 = Convert.ToInt32(textBox9.Text) * Convert.ToInt32(textBox7.Text) + Convert.ToInt32(textBox6.Text) * Convert.ToInt32(textBox4.Text) + Convert.ToInt32(textBox3.Text) * Convert.ToInt32(textBox1.Text);
            box32 = Convert.ToInt32(textBox9.Text) * Convert.ToInt32(textBox8.Text) + Convert.ToInt32(textBox6.Text) * Convert.ToInt32(textBox5.Text) + Convert.ToInt32(textBox3.Text) * Convert.ToInt32(textBox2.Text);
            box33 = Convert.ToInt32(textBox9.Text) * Convert.ToInt32(textBox9.Text) + Convert.ToInt32(textBox6.Text) * Convert.ToInt32(textBox6.Text) + Convert.ToInt32(textBox3.Text) * Convert.ToInt32(textBox3.Text);

            if(box11==1 & box22==1 & box33==1 & box12 == 0 & box13 == 0 & box21 == 0 & box23 == 0 & box31 == 0 & box32 == 0)
            {
                label16.Text = "Evet involutif.";
            }
            else
            {
                label16.Text = "Hayır involutif değil.";
            }

            label3.Text = box11.ToString();
            label4.Text = box12.ToString();
            label5.Text = box13.ToString();
            label6.Text = box21.ToString();
            label7.Text = box22.ToString();
            label8.Text = box23.ToString();
            label9.Text = box31.ToString();
            label10.Text = box32.ToString();
            label11.Text = box33.ToString();

        }

       
    }
}
