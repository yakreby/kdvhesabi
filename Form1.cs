using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        //Hesapla Butonu
        private void Button1_Click(object sender, EventArgs e)
        {
            double fiyat = Convert.ToDouble(textBox1.Text);
            int adet = Convert.ToInt32(textBox2.Text);
            double toplam_fiyat;
            double kdv_tutar;

            //%1 KDV
            if (radioButton1.Checked == true)
            {
                kdv_tutar = (fiyat * adet) * 0.01;
                toplam_fiyat = kdv_tutar + fiyat * adet;

                //Yazdırma
                textBox3.Text = kdv_tutar.ToString() + " ₺'dir.";
                textBox5.Text = (toplam_fiyat - kdv_tutar).ToString() + " ₺'dir.";
                textBox4.Text = toplam_fiyat.ToString() + " ₺'dir.";
            }
            //%8 KDV
            else if (radioButton2.Checked == true)
            {
                kdv_tutar = (fiyat * adet) * 0.08;
                toplam_fiyat = kdv_tutar + fiyat * adet;

                //Yazdırma
                textBox3.Text = kdv_tutar.ToString() + " ₺'dir.";
                textBox5.Text = (toplam_fiyat - kdv_tutar).ToString() + " ₺'dir.";
                textBox4.Text = toplam_fiyat.ToString() + " ₺'dir.";
            }
            //%18 KDV
            else if (radioButton3.Checked == true)
            {
                kdv_tutar = (fiyat * adet) * 0.18;
                toplam_fiyat = kdv_tutar + fiyat * adet;

                //Yazdırma
                textBox3.Text = kdv_tutar.ToString() + " ₺'dir.";
                textBox5.Text = (toplam_fiyat - kdv_tutar).ToString() + " ₺'dir.";
                textBox4.Text = toplam_fiyat.ToString() + " ₺'dir.";
            }
            //Hatalı İşlem
            else
            {
                MessageBox.Show("Hatalı İşlem.");
            }
        }

        //Temizle Butonu
        private void Button2_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {   
                if (item is TextBox)
                {
                    TextBox tbox = (TextBox)item;
                 
                tbox.Clear();
                   
                }  
            }
        }
    }
}
