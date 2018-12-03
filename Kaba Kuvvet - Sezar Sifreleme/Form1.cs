using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kaba_Kuvvet___Sezar_Sifreleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            for(int anahtar = 0; anahtar < 26; anahtar++)
            {

                rctx_acikmesaj.Text += anahtar.ToString() + " >> ";
                foreach(char karekter in tx_sifrelimesaj.Text)
                {
                    int alfabe_sirasi = (int)karekter - 97;

                    while(alfabe_sirasi - anahtar < 0) // eksi bir deger varsa
                        alfabe_sirasi += 26;  // a = 0 , 0 - 1 = -1 , -1 + 26 = 25 = z

                    rctx_acikmesaj.Text += (char)(alfabe_sirasi - anahtar + 97);
                }
                rctx_acikmesaj.Text += Environment.NewLine;

            }
        }
    }
}
