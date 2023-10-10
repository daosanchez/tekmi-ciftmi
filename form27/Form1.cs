using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int Sayi =Convert.ToInt32(txtSayi.Text);
            if (Sayi % 2 == 0)
            {
                lbCift.Items.Add(Sayi);
            }
            else
            {
                lbTek.Items.Add(Sayi);
            }
        }
       
       
        
    }
}
    
