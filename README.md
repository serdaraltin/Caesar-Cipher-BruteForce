# Caesar-Cipher-BruteForce
**Kaba Kuvvet Saldırı Tekniği ile Sezar Şifreleme Algoritması ile şifrelenmiş metni deşifre eden yazılım.**

------------


- [YOUTUBE](https://www.youtube.com/channel/UCltJlvbcFATfBm0qHttpZNg?view_as=subscriber "YOUTUBE") kanalında verilen eğitime katkıda bulunması amacıyla hazırlanmıştır.
- **VISUAL STUDIO 2015** editörü kullanılarak hazırlanan uygulama görsel bir arayüze sahiptir.


------------
<br>




------------
### [Meyta - Kriptoloji 2 - Kriptoanaliz - Kaba Kuvvet(Brute Force)](https://www.youtube.com/watch?v=nZwcoATMVdo "Kriptoloji 2 - Kriptoanaliz - Kaba Kuvvet(Brute Force)")
![Meyta - Kriptoloji 2 - Sezar Şifreleme](https://github.com/serdaraltin/Caesar-Cipher/blob/master/Sezar%20Sifreleme/bin/Debug/On%20Izleme.jpg)

------------

**Tasarım - Form1.Designer.cs**

![Form1](https://github.com/serdaraltin/Caesar-Cipher/blob/master/Sezar%20Sifreleme/obj/Debug/ScreenShot.PNG)

------------



**Kod - Form1.cs**

```csharp
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
```

**Powered By DeadSound**
