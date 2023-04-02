using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

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
            bool pershenye = checkBox8.Checked;
            bool gorlо_kr = checkBox15.Checked;
            bool sostoyanye_slizistoy = checkBox16.Checked;
            bool kashel = false;
            bool suhoy_kashel = false;
            bool vlagny_kashel = false;
            bool otit = false;
            bool uvelichenye_limfo_uzlov = checkBox9.Checked; ;
            bool shum_v_uhe = checkBox10.Checked;
            bool uhudshenye_sluha = checkBox11.Checked;
            bool otek_uha = checkBox12.Checked;
            bool zidkost_v_uhe = checkBox13.Checked;
            bool rovnovesye = checkBox14.Checked;
        
            string Diagnoz = "";
            for(int i = 0; i < 3; i++) { 

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

            if (otit & shum_v_uhe & zidkost_v_uhe)
            {
                Diagnoz = "евстахиит";
            }   
            if (otit & otek_uha)
            {
                Diagnoz = "мастоидит";
            }

            if (suhoy_kashel & uvelichenye_limfo_uzlov)
            {
                Diagnoz = "фаренгит";
            }
            if (vlagny_kashel & uvelichenye_limfo_uzlov)
            {
                Diagnoz = "тонзиллит";
            }
            if (kashel & !sostoyanye_slizistoy)
            {
                suhoy_kashel = true;
            }
            if (kashel & sostoyanye_slizistoy)
            {
                vlagny_kashel = true;
            }
            if (boli_v_uhe & uhudshenye_sluha)
            {
                otit = true;
            }            
            if (pershenye & gorlо_kr)
            {
                kashel = true;
            }
            }

            label1.Text = Diagnoz;
            if (Diagnoz == "")
            {
                label1.Text = "Нет подходящих";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 secondForm = new Form2();
            secondForm.Show();
        }
    }
}
