/*
    Bu yaz�l�m�n tasar�m� ve kaynak kodlar� Datakent'e aittir.
    istenildi�i gibi geli�tirilebilir, tasar�m� de�i�tirilebilir.
    yaz�l�mdaki kodlar ve tasar�m referans g�sterilerek kullan�labilir.
    �cretle VEYA dengi nesne kar��l���nda SATILMAMALIDIR.
    g�nl�m bu yaz�l�m�n insanlar taraf�ndan serbest�e kullan�lmas�ndan yanad�r.
    eme�e haks�zl�k yapmak istemiyorsan�z yaz�l�mdaki DATAKENT'e ait bilgileri KALDIRMAYINIZ.
    yok ben eme�i �nemsemem, enayi gibi kodlar� yay�nlamasayd�n�z diyorsan�z �STED���N�Z� yapabilirsiniz.
 
    http://www.datakent.com
    http://forum.datakent.com
    14-06-07
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace meno
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            GlobalClass.appStng();//??buras� de�i�ecek
            if (GlobalClass.xuserpass != "")
            {
                uLogin uloginx = new uLogin();
                uloginx.ShowDialog();
                if (uloginx.Upassx != GlobalClass.xuserpass)
                    GlobalClass.LoinErr = true;
            }
            if (GlobalClass.xuserID == "")
            {
                appstng apsx = new appstng();
                apsx.MdiParent = this;
                apsx.Show();
            }
        }

        private void genelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            A00 mxf = new A00();
            mxf.MdiParent = this;
            mxf.Show();
        }

        private void genelToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            B00 mxf = new B00();
            mxf.MdiParent = this;
            mxf.Show();
        }

        private void genelToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            C00 mxf = new C00();
            mxf.MdiParent = this;
            mxf.Show();
        }

        private void takipNumaras�OlmayanSevkiKabulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            A00_2 mxf = new A00_2();
            mxf.MdiParent = this;
            mxf.Show();

        }

        private void takipOkuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            A00_3 mxf = new A00_3();
            mxf.MdiParent = this;
            mxf.Show();
        }

        private void hastaninTakipleriniBulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            A00_4 mxf = new A00_4();
            mxf.MdiParent = this;
            mxf.Show();
        }

        private void takipSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            A00_5 mxf = new A00_5();
            mxf.MdiParent = this;
            mxf.Show();
        }

        private void ��k��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void g�venlik��lemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            appstng appstx = new appstng();
            appstx.MdiParent = this;
            appstx.Show();
        }

        private void �demeBilgisiOkuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            C00_3 C003x = new C00_3();
            C003x.MdiParent = this;
            C003x.Show();
        }

        private void �demeDurumKontrolC01ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            C01 mxf = new C01();
            mxf.MdiParent = this;
            mxf.Show();
        }

        private void faturaBilgisiKay�tToolStripMenuItem_Click(object sender, EventArgs e)
        {
            E00 mxf = new E00();
            mxf.MdiParent = this;
            mxf.Show();
        }

        private void icmalFaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            E00_3 mxf = new E00_3();
            mxf.MdiParent = this;
            mxf.Show();

        }

        private void faturaBilgisiSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            E00_5 mxf = new E00_5();
            mxf.MdiParent = this;
            mxf.Show();            
        }

        private void faturaBilgisiOkuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            E00_7 mxf = new E00_7();
            mxf.MdiParent = this;
            mxf.Show();
        }

        private void saglikTesisiAraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            other_1 mxf = new other_1();
            mxf.MdiParent = this;
            mxf.Show();
        }

        private void tan�ml�Sa�l�kTesisleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtesisler mxf = new frmtesisler();
            mxf.MdiParent = this;
            mxf.Show();            
        }

        private void doktorAraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDr mxf = new frmDr();
            mxf.MdiParent = this;
            mxf.Show();            

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (GlobalClass.LoinErr)
                Application.Exit();

            this.Text = GlobalClass.menotitle;
        }

        private void lisansBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void mnf001_Click(object sender, EventArgs e)
        {            
            F00_1 mxf = new F00_1();
            mxf.MdiParent = this;
            if ((string)(sender as ToolStripMenuItem).Tag == "1")
                mxf.RapBlgKydtTkpNoDan_mi = false;
            else mxf.RapBlgKydtTkpNoDan_mi = true;
            mxf.Show();            
        }

        private void mnf002_Click(object sender, EventArgs e)
        {
            F00_2 mxf = new F00_2();
            mxf.MdiParent = this;
            if ((string)(sender as ToolStripMenuItem).Tag == "1")
                mxf.RapBlgKydtTkpNoDan_mi = false;
            else mxf.RapBlgKydtTkpNoDan_mi = true;
            mxf.Show();            
        }

        private void mnf003_Click(object sender, EventArgs e)
        {
            F00_3 mxf = new F00_3();
            mxf.MdiParent = this;
            if ((string)(sender as ToolStripMenuItem).Tag == "1")
                mxf.RapBlgKydtTkpNoDan_mi = false;
            else mxf.RapBlgKydtTkpNoDan_mi = true;
            mxf.Show();            
        }

        private void mnf004_Click(object sender, EventArgs e)
        {            
            F00_4 mxf = new F00_4();
            mxf.MdiParent = this;
            if ((string)(sender as ToolStripMenuItem).Tag == "1")
                mxf.RapBlgKydtTkpNoDan_mi = false;
            else mxf.RapBlgKydtTkpNoDan_mi = true;
            mxf.Show();            
        }

        private void mnf005_Click(object sender, EventArgs e)
        {
            F00_5 mxf = new F00_5();
            mxf.MdiParent = this;
            if ((string)(sender as ToolStripMenuItem).Tag == "1")
                mxf.RapBlgKydtTkpNoDan_mi = false;
            else mxf.RapBlgKydtTkpNoDan_mi = true;
            mxf.Show();            
        }

        private void mnf006_Click(object sender, EventArgs e)
        {
            F00_6 mxf = new F00_6();
            mxf.MdiParent = this;
            if ((string)(sender as ToolStripMenuItem).Tag == "1")
                mxf.RapBlgKydtTkpNoDan_mi = false;
            else mxf.RapBlgKydtTkpNoDan_mi = true;
            mxf.Show();            
        }

        private void mnf007_Click(object sender, EventArgs e)
        {
            F00_7 mxf = new F00_7();
            mxf.MdiParent = this;
            if ((string)(sender as ToolStripMenuItem).Tag == "1")
                mxf.RapBlgKydtTkpNoDan_mi = false;
            else mxf.RapBlgKydtTkpNoDan_mi = true;
            mxf.Show();            
        }

        private void mnf008_Click(object sender, EventArgs e)
        {
            F00_8 mxf = new F00_8();
            mxf.MdiParent = this;
            if ((string)(sender as ToolStripMenuItem).Tag == "1")
                mxf.RapBlgKydtTkpNoDan_mi = false;
            else mxf.RapBlgKydtTkpNoDan_mi = true;
            mxf.Show();            
        }

        private void raporBilgisiBulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F00_9 mxf = new F00_9();
            mxf.MdiParent = this;
            mxf.DelReport = false;
            mxf.Show();            
        }

        private void raporBilgisiSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F00_9 mxf = new F00_9();
            mxf.MdiParent = this;
            mxf.DelReport = true;
            mxf.Show();            

        }

        private void raporUzatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F00_B mxf = new F00_B();
            mxf.MdiParent = this;
            mxf.Show();                        
        }

        private void hakk�ndaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process Proc = new System.Diagnostics.Process();            
            Proc.StartInfo.FileName = GlobalClass.GetAxPath() + @"\about.exe";
            Proc.Start();

            //appabout apx = new appabout();
            //apx.MdiParent = this;
            //apx.Show();
        }

        private void hataVe�stekBildirimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Feedback fbck = new Feedback();
            fbck.MdiParent = this;
            fbck.Show();
        }

        private void yak�nl�kKodlar�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process Proc = new System.Diagnostics.Process();
            Proc.StartInfo.FileName = GlobalClass.GetAxPath() + @"\yakinlik_kodlari.htm";
            Proc.Start();
        }
    }
}