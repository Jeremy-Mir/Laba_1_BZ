using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_1_BZ
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool boli_v_uhe = checkBox1.Checked;
            bool cheshuiki = checkBox2.Checked;
            bool pokrasnenya_glaz = checkBox3.Checked;
            bool pokrasnenye_kraev_veka = checkBox4.Checked;
            bool pokrasnenye_na_krayah_veka = checkBox5.Checked;
            bool slezotochenye = checkBox6.Checked;
            bool zasorenye = checkBox7.Checked;

            string Diagnoz = "";

            if (cheshuiki & pokrasnenye_kraev_veka)
            {
                Diagnoz = "блефарит";
            }
            if (pokrasnenya_glaz & slezotochenye & zasorenye)
            {
                Diagnoz = "конъюнктивит";
            }
            if (pokrasnenye_na_krayah_veka)
            {
                Diagnoz = "ячмень";
            }
            if (boli_v_uhe)
            {
                Diagnoz = "отит";
            }
            label1.Text = Diagnoz;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
