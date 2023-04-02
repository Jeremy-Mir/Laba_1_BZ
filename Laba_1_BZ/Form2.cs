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
    public partial class Form2 : Form
    {
        int boli_v_uhe = 0;
        int cheshuiki = 0;
        int pokrasnenya_glaz = 0;
        int pokrasnenye_kraev_veka = 0;
        int pokrasnenye_na_krayah_veka = 0;
        int slezotochenye = 0;
        int zasorenye = 0;
        int pershenye = 0;
        int gorlо_kr = 0;
        int sostoyanye_slizistoy = 0;
        int kashel = 0;
        int suhoy_kashel = 0;
        int vlagny_kashel = 0;
        int otit = 0;
        int uvelichenye_limfo_uzlov = 0;
        int shum_v_uhe = 0;
        int uhudshenye_sluha = 0;
        int otek_uha = 0;
        int zidkost_v_uhe = 0;
        int rovnovesye = 0;
        int diagnoz_prov = 0;
        string Diagnoz = "фаренгит";
        public Form2()
        {
            InitializeComponent();
            
            string Diagnoz = "фаренгит";
            if (Diagnoz == "фаренгит")
            {
                if (suhoy_kashel == 0)
                {
                    if (kashel == 0)
                    {
                        if (pershenye == 0)
                        {
                            label2.Text = "Першение в горле?";
                  
                        }
                        if (gorlо_kr == 0)
                        {
                            label2.Text = "Горло красное?";
                        }
                        if(pershenye==2 && gorlо_kr==2)
                        {
                            kashel = 2;
                        }
                    }
                }
                if (uvelichenye_limfo_uzlov == 0)
                {
                    label2.Text = "Лимфоузлы увеличены?";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label2.Text == "Горло красное?")
            {
                gorlо_kr = 2;
            }
            if (label2.Text == "Першение в горле?")
            {
                pershenye = 2;
            }
            if (label2.Text == "Лимфоузлы увеличены?")
            {
                uvelichenye_limfo_uzlov = 2;
            }
            if (label2.Text == "Чрезмерная влажность слизистой?")
            {
                sostoyanye_slizistoy = 2;
            }
            if (label2.Text == "Есть боли в ухе?")
            {
                boli_v_uhe = 2;
            }
            if (label2.Text == "Есть ухудшение слуха?")
            {
                uhudshenye_sluha = 2;
            }
            if (label2.Text == "Есть отёк уха?")
            {
                otek_uha = 2;
            }
            if (label2.Text == "Есть шум в ухе?")
            {
                shum_v_uhe = 2;
            }
            if (label2.Text == "Есть чувство жидкости в ухе?")
            {
                zidkost_v_uhe = 2;
            }
            if (label2.Text == "Есть покраснение на краю века?")
            {
                pokrasnenye_na_krayah_veka = 2;
            }
            if (label2.Text == "Есть покраснение глаз?")
            {
                pokrasnenya_glaz = 2;
            }
            if (label2.Text == "Есть сильное слезоточение?")
            {
                slezotochenye = 2;
            }
            if (label2.Text == "Есть чувство зассорения в глазу?")
            {
                zasorenye = 2;
            }
            if (label2.Text == "Есть чашуйки на веках?")
            {
                cheshuiki = 2;
            }
            cicle();
        }
        private void cicle()
        {
            if (Diagnoz == "фаренгит")
            {
                if (suhoy_kashel == 0)
                {
                    if (kashel == 0)
                    {
                        if (pershenye == 0)
                        {
                            label2.Text = "Першение в горле?";
                        }
                        if (pershenye == 1)
                        {
                            Diagnoz = "тонзиллит";
                        }
                        if (gorlо_kr == 0)
                        {
                            label2.Text = "Горло красное?";
                        }
                        if (gorlо_kr == 1)
                        {
                            Diagnoz = "тонзиллит";
                        }
                        if (pershenye == 2 && gorlо_kr == 2)
                        {
                            kashel = 2;
                        }
                    }
                    if (sostoyanye_slizistoy == 0)
                    {
                        label2.Text = "Чрезмерная влажность слизистой?";
                    }
                    if (sostoyanye_slizistoy == 2)
                    {
                        Diagnoz = "тонзиллит";
                    }

                    if (kashel == 2 & sostoyanye_slizistoy == 1)
                    {
                        suhoy_kashel = 2;
                    }
                }
                if (uvelichenye_limfo_uzlov == 0)
                {
                    label2.Text = "Лимфоузлы увеличены?";
                }
                if (uvelichenye_limfo_uzlov == 1)
                {
                    Diagnoz = "тонзиллит";
                }
                if (suhoy_kashel == 2 & uvelichenye_limfo_uzlov == 2)
                {
                    label1.Text = "Ваш диагоз";
                    label2.Text = Diagnoz;
                }
            }
            if (Diagnoz == "тонзиллит")
            {
                if (vlagny_kashel == 0)
                {
                    if (kashel == 0)
                    {
                        if (pershenye == 0)
                        {
                            label2.Text = "Першение в горле?";
                        }
                        if (pershenye == 1)
                        {
                            Diagnoz = "мастоидит";
                        }
                        if (gorlо_kr == 0)
                        {
                            label2.Text = "Горло красное?";
                        }
                        if (gorlо_kr == 1)
                        {
                            Diagnoz = "мастоидит";
                        }
                        if (pershenye == 2 && gorlо_kr == 2)
                        {
                            kashel = 2;
                        }
                    }
                    if (sostoyanye_slizistoy == 0)
                    {
                        label2.Text = "Чрезмерная влажность слизистой?";
                    }
                    if (sostoyanye_slizistoy == 1)
                    {
                        Diagnoz = "мастоидит";
                    }

                    if (kashel == 2 & sostoyanye_slizistoy == 2)
                    {
                        vlagny_kashel = 2;
                    }
                }
                if (uvelichenye_limfo_uzlov == 0)
                {
                    label2.Text = "Лимфоузлы увеличены?";
                }
                if (uvelichenye_limfo_uzlov == 1)
                {
                    Diagnoz = "мастоидит";
                }
                if (vlagny_kashel == 2 & uvelichenye_limfo_uzlov == 2)
                {
                    label1.Text = "Ваш диагоз";
                    label2.Text = Diagnoz;
                }
            }
            if (Diagnoz == "мастоидит")
            {
                if (otit == 0)
                {
                    if (boli_v_uhe == 0)
                    {
                            label2.Text = "Есть боли в ухе?";
                    }
                    if (boli_v_uhe == 1)
                    {
                        Diagnoz = "евстахиит";
                    }
                    if (uhudshenye_sluha == 0)
                    {
                        label2.Text = "Есть ухудшение слуха?";
                    }
                    if (uhudshenye_sluha == 1)
                    {
                        Diagnoz = "евстахиит";
                    }

                    if (boli_v_uhe == 2 & uhudshenye_sluha == 2)
                    {
                        otit = 2;
                    }
                }
                if (otek_uha == 0)
                {
                    label2.Text = "Есть отёк уха?";
                }
                if (otek_uha == 1)
                {
                    Diagnoz = "евстахиит";
                }
                if (otit == 2 & otek_uha == 2)
                {
                    label1.Text = "Ваш диагоз";
                    label2.Text = Diagnoz;
                }
            }
            if (Diagnoz == "евстахиит")
            {
                if (otit == 0)
                {
                    if (boli_v_uhe == 0)
                    {
                        label2.Text = "Есть боли в ухе?";
                    }
                    if (boli_v_uhe == 1)
                    {
                        Diagnoz = "конъюнктивит";
                    }
                    if (uhudshenye_sluha == 0)
                    {
                        label2.Text = "Есть ухудшение слуха?";
                    }
                    if (uhudshenye_sluha == 1)
                    {
                        Diagnoz = "конъюнктивит";
                    }

                    if (boli_v_uhe == 2 & uhudshenye_sluha == 2)
                    {
                        otit = 2;
                    }
                }
                if (shum_v_uhe == 0)
                {
                    label2.Text = "Есть шум в ухе?";
                }
                if (shum_v_uhe == 1)
                {
                    Diagnoz = "конъюнктивит";
                }
                if (zidkost_v_uhe == 0)
                {
                    label2.Text = "Есть чувство жидкости в ухе?";
                }
                if (zidkost_v_uhe == 1)
                {
                    Diagnoz = "конъюнктивит";
                }
                if (otit == 2 & shum_v_uhe == 2 & zidkost_v_uhe == 2)
                {
                    label1.Text = "Ваш диагоз";
                    label2.Text = Diagnoz;
                }
            }
           
            if (Diagnoz == "конъюнктивит")
            {
                if (pokrasnenya_glaz == 0)
                {

                    label2.Text = "Есть покраснение глаз?";

                }
                if (pokrasnenya_glaz == 1)
                {
                    Diagnoz = "блефарит";
                }
                if (slezotochenye == 0)
                {

                    label2.Text = "Есть сильное слезоточение?";

                }
                if (slezotochenye == 1)
                {
                    Diagnoz = "блефарит";
                }
                if (zasorenye == 0)
                {

                    label2.Text = "Есть чувство зассорения в глазу?";

                }
                if (zasorenye == 1)
                {
                    Diagnoz = "блефарит";
                }
                if (zasorenye == 2 & slezotochenye ==2 & pokrasnenya_glaz == 2)
                {
                    label1.Text = "Ваш диагоз";
                    label2.Text = Diagnoz;
                }
            }
            if (Diagnoz == "блефарит")
            {
                if (cheshuiki == 0)
                {

                    label2.Text = "Есть чашуйки на веках?";

                }
                if (cheshuiki == 1)
                {
                    Diagnoz = "ячмень";
                }
                if (pokrasnenya_glaz == 0)
                {

                    label2.Text = "Есть покраснение глаз?";

                }
                if (pokrasnenya_glaz == 1)
                {
                    Diagnoz = "ячмень";
                }
                if (pokrasnenya_glaz == 2 & cheshuiki == 2)
                {
                    label1.Text = "Ваш диагоз";
                    label2.Text = Diagnoz;
                }
            }
            if (Diagnoz == "ячмень")
            {
                if (pokrasnenye_na_krayah_veka == 0)
                {

                    label2.Text = "Есть покраснение на краю века?";

                }
                if (pokrasnenye_na_krayah_veka == 1)
                {
                    Diagnoz = "нет подходящих";
                    label1.Text = "Ваш диагоз";
                    label2.Text = Diagnoz;
                    
                }
                if (pokrasnenye_na_krayah_veka == 2)
                {
                    label1.Text = "Ваш диагоз";
                    label2.Text = Diagnoz;
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (label2.Text == "Горло красное?")
            {
                gorlо_kr = 1;
            }
            if (label2.Text == "Першение в горле?")
            {
                pershenye = 1;
            }
            if (label2.Text == "Лимфоузлы увеличены?")
            {
                uvelichenye_limfo_uzlov = 1;
            }
            if (label2.Text == "Чрезмерная влажность слизистой?")
            {
                sostoyanye_slizistoy = 1;
            }
            if (label2.Text == "Есть боли в ухе?")
            {
                boli_v_uhe = 1;
            }
            if (label2.Text == "Есть ухудшение слуха?")
            {
                uhudshenye_sluha = 1;
            }
            if (label2.Text == "Есть отёк уха?")
            {
                otek_uha = 1;
            }
            if (label2.Text == "Есть шум в ухе?")
            {
                shum_v_uhe = 1;
            }
            if (label2.Text == "Есть чувство жидкости в ухе?")
            {
                zidkost_v_uhe = 1;
            }
            if (label2.Text == "Есть покраснение на краю века?")
            {
                pokrasnenye_na_krayah_veka = 1;
            }
            if (label2.Text == "Есть покраснение глаз?")
            {
                pokrasnenya_glaz = 1;
            }
            if (label2.Text == "Есть сильное слезоточение?")
            {
                slezotochenye = 1;
            }
            if (label2.Text == "Есть чувство зассорения в глазу?")
            {
                zasorenye = 1;
            }
            if (label2.Text == "Есть чашуйки на веках?")
            {
                cheshuiki = 1;
            }
            
            cicle();
        }
    }
}
