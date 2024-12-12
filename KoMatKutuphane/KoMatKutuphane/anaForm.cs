using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KoMatKutuphane
{
    public partial class anaForm : Form
    {
        public anaForm()
        {
            InitializeComponent();
        }

        private void TSMI_diller_Click(object sender, EventArgs e)
        {
            Form[] acikFormlar = this.MdiChildren;//anaForm içerisinde açık olan tüm formların listesi
            bool acikmi = false;
            for (int i = 0; i < acikFormlar.Length; i++)
            {
                //eğer açıkformların herhangi birinin türü bizim açmak istediğimiz formun türü ile eşleşiyorsa form daha önceden açılmış demektir.
                if (acikFormlar[i].GetType() == typeof(dilIslemleri))
                {
                    acikmi = true;
                    acikFormlar[i].Activate();
                    //açık olan formu öne getir
                }
            }
            if (acikmi == false)//eğer form açık değilse
            {
                dilIslemleri frm = new dilIslemleri();
                //açılacak olan formun nesnesini yaratıyoruz
                //dil işlemleri formu ana formun MDI Child'ı olacak
                frm.MdiParent = this;
                //Bu form (anaForm) açılacak olan frm(dilIslemleri) formunun MDI taşıyıcısı(MDIParent) olsun
                frm.Show();//formu aç(anaForm'un içinde)
            }
        }
    }
}
