using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yazılım_Yapımı
{
    public partial class frm_ıstatistik : Form
    {
        public frm_ıstatistik()
        {
            InitializeComponent();
        }
        Ezberlenecek ezberle = new Ezberlenecek();
        private void button1_Click(object sender, EventArgs e)
        {
            
                lstbx_istatistik.Items.Clear();
                List<string> istatistikGörüntüle = new List<string>();
            if (rdb_ay.Checked == true && cmb_Aylar.Text != null && cmb_yillar.Text != null)
            {
                ezberle.ay = cmb_Aylar.SelectedIndex + 1;
                ezberle.yil = int.Parse(cmb_yillar.Text);
            }
            else if (rdb_yil.Checked == true && cmb_yillar.Text !="")
            {
                ezberle.yil = int.Parse(cmb_yillar.Text);
            }
                istatistikGörüntüle = ezberle.IstatistikTut();
                for (int i = 0; i < istatistikGörüntüle.Count; i++)
                {
                    lstbx_istatistik.Items.Add(istatistikGörüntüle[i]);
                }
                lbl_kelimesaybilgi.Visible = true;
                lbl_ogrenilenkelsayısı.Text = lstbx_istatistik.Items.Count.ToString();
            progressBar1.Value = lstbx_istatistik.Items.Count;


        }

        private void rdb_ay_CheckedChanged(object sender, EventArgs e)
        {
            cmb_Aylar.Visible = true;
            cmb_yillar.Visible = true;
            ezberle.aysecimi = true;
        }

        private void rdb_yil_CheckedChanged(object sender, EventArgs e)
        {
            cmb_Aylar.Visible = false;
            cmb_yillar.Visible = true;
            ezberle.aysecimi = false;

        }

      
    }
}
