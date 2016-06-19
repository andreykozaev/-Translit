using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();//
        }
        public static bool CyrToLat = true;


        private void tbCyr_TextChanged(object sender, EventArgs e)
        {
            Convert();
        }

        private void tbLat_TextChanged(object sender, EventArgs e)
        {
            Convert();
        }

        private void rbVaso_CheckedChanged(object sender, EventArgs e)
        {
            Convert();
        }

        private void rbSoviet_CheckedChanged(object sender, EventArgs e)
        {
            Convert();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Convert();
        }
        private void Convert()
        {
            if (rbSoviet.Checked)
                tbLat.Text = ir.Convert.toSoviet(tbCyr.Text);
            if (rbVaso.Checked)
                tbLat.Text = ir.Convert.toVaso(tbCyr.Text);
            if (rbKudar.Checked)
                tbLat.Text = ir.Convert.toKudar(tbCyr.Text);
        }
     

        #region Контекстное меню
        private void tsCopyCyr_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbCyr.SelectedText);
            // скопировать выделенный текст Cyr
        }

        private void tsCopyLat_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbLat.SelectedText);
            // скопировать выделенный текст Lat
        }
        #endregion


        #region Стилизация (возможно некоторые функции уже не нужны)
        private void кириллагæйЛатинагмToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CyrToLat == false)
            {
                gbCyr.Text = "Кириллаг текстæй";
                gbCyr.Font = new Font(gbCyr.Font, FontStyle.Bold | FontStyle.Italic);
                gbLat.Text = "Latinag tekstmæ";
                gbLat.Font = new Font(gbCyr.Font, FontStyle.Regular | FontStyle.Italic);
                tbCyr.Focus();
                // стилизация

                tbLat.Clear();
                tbCyr.Focus();
                // очистить и переставить фокус

                tbLat.ReadOnly = true;
                tbCyr.ReadOnly = false;
                // ReadOnly

                CyrToLat = true;

            }
        }

        private void латинагæйКириллагмæToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CyrToLat == true)
            {
                gbLat.Text = "Latinag tekstæj";
                gbLat.Font = new Font(gbLat.Font, FontStyle.Bold | FontStyle.Italic);
                gbCyr.Text = "Кириллаг текстмæ";
                gbCyr.Font = new Font(gbCyr.Font, FontStyle.Regular | FontStyle.Italic);
                // стилизация

                tbCyr.Clear();
                tbLat.Focus();
                // очистить и переставить фокус

                tbLat.ReadOnly = false;
                tbCyr.ReadOnly = true;
                // ReadOnly

                CyrToLat = false;
                // флаг
            }
        }
        #endregion

        private void истыТекстСæвæрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CyrToLat == true) tbCyr.Text = @"Ныры дуджы адæймаг компьютертæй пайда кæны йæ алы куысты дæр. Адон алы дæсныйæдты специалистты архайд уыйбæрц фенцондæр кодтой, æмæ сæм афтæ фæкæсы, цыма æнæ уыдон цæрын дæр нал базониккой. Уыдоны фæрцы дзæвгар фылдæр кæны фæллойы æнтысындзинад, цы æрмæг дзы бавæрæм, уый кусы автоматикон æгъдауæй, мах бæсты рæвдз æххæст кæны дæргъвæтин рæстæг кæмæн хъæуы, ахæм процесстæ, специалистты сфæлдыстадон куыст кæнынц цæстуынгæ, бирæвæрсыг æмæ бирæ æнтыстджындæр. Абон куыстдæтджыты домæнты компьютеримæ арæхсын ссис æнæмæнг хъуыддаг.";
            else tbLat.Text = @"Nyry dudžy adæjmag kompjutertæj pajda kæny jæ aly kuysty dær. Adon aly dæsnyjædty specialistty arxajd uyjbærc fencondær kodtoj, æmæ sæm aftæ fækæsy, cyma ænæ uydon cæryn dær nal bazonikkoj. Uydony færcy dzævgar fyldær kæny fællojy æntysyndzinad, cy ærmæg dzy baværæm, uyj kusy avtomatikon æhdauæj, max bæsty rævdz æxxæst kæny dærhvætin ræstæg kæmæn qæuy, axæm processtæ, specialistty sfældystadon kuyst kænync cæstuyngæ, biræværsyg æmæ biræ æntystdžyndær. Abon kuystdætdžyty domænty kompjuterimæ aræxsyn ssis ænæmæng quyddag.";
        }

        private void бæрæг_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Æфтуан: ИрTranslit v 1.0\n\nСфæлдисæг: Козаты Андрей\n\ne-mail: andrey_kozaev@mail.ru");
        }
 
        private void æддæмæToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuVaso_Click(object sender, EventArgs e)
        {
            rbVaso.Checked = true;
        }

        private void menuSoviet_Click(object sender, EventArgs e)
        {
            rbSoviet.Checked = true;
        }

        private void menuKudar_Click(object sender, EventArgs e)
        {
            rbKudar.Checked = true;
        }

    






   


  
    }
}
