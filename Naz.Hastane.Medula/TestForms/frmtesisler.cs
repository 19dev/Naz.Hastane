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

namespace Naz.Hastane.Medula.TestForms
{
    public partial class frmtesisler : Form
    {
        public string stesis;
        public bool selectx=false;

        public frmtesisler()
        {
            InitializeComponent();
        }

        private void frmtesisler_Load(object sender, EventArgs e)
        {
            DataSet dbiller = new DataSet();
            dbiller.ReadXml(GlobalClass.GetAxPath() + @"\st_iller.xml");
            cb_iller.DataSource = dbiller.Tables[0];

            DataSet dbko = new DataSet();
            dbko.ReadXml(GlobalClass.GetAxPath() + @"\st_kamu_ozel.xml");
            cb_kamoz.DataSource = dbko.Tables[0];

            DataSet dbtetu = new DataSet();
            dbtetu.ReadXml(GlobalClass.GetAxPath() + @"\st_tesis_turleri.xml");
            cb_tesisturu.DataSource = dbtetu.Tables[0];

            DataSet dbtesx = new DataSet();            
            dbtesx.ReadXml(GlobalClass.GetAxPath() + @"\st_tesisler.xml");                        
            sttesislerBindingSource.DataSource = dbtesx.Tables[0];
            Searcx();
            button2.Visible = selectx;
        }

        void Searcx()
        {
            string esx = "";
            if (txttesisadi.Text.Trim() != "")
            {
                if (mn1x.Checked)
                    esx = " and ADI LIKE '" + txttesisadi.Text + "%'";
                else if (mn2x.Checked)
                    esx = " and ADI LIKE '%" + txttesisadi.Text + "%'";
                else esx = " and ADI = '" + txttesisadi.Text + "'";
            }

            sttesislerBindingSource.Filter = "ILI = " + cb_iller.SelectedValue.ToString() + " and TESISTURU = " + cb_tesisturu.SelectedValue.ToString() + " and KAMOZ = " + cb_kamoz.SelectedValue.ToString() + esx;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Searcx();
        }

        private void mn1x_Click(object sender, EventArgs e)
        {
            mn1x.Checked = false;
            mn2x.Checked = false;
            mn3x.Checked = false;
            (sender as ToolStripMenuItem).Checked = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sttesislerBindingSource.Count == 0) return;
            DataRowView RowText;
            RowText = (DataRowView)sttesislerBindingSource.Current;
            stesis = RowText[0].ToString().Trim();
            this.Close();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (button2.Visible)
                button2_Click(button2,new System.EventArgs());
        }
    }
}