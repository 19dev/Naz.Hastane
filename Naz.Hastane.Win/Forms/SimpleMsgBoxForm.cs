using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Naz.Hastane.Data.Services;
using Naz.Hastane.Data.Entities.LookUp.Special;
using Naz.Utilities.Classes;

namespace Naz.Hastane.Win.Forms
{
    public partial class SimpleMsgBoxForm : DevExpress.XtraEditors.XtraForm
    {
        public DialogResult Result;

        private SimpleMsgBoxForm()
        {
            InitializeComponent();
        }

        public SimpleMsgBoxForm(string aMessage, string aTitle, bool aError = true)
            : this()
        {
            this.Text = aTitle;
            this.labelControl1.Text = aMessage;
            if (aError)
                this.labelControl1.BackColor = Color.Red;
            else
                this.labelControl1.BackColor = Color.Lime;
            this.ShowDialog();
        }

        private void sbOK_Click(object sender, EventArgs e)
        {
            Result = DialogResult.Yes;
            Close();
        }


        public static void ShowMsgBox(string aMessage, string aTitle = "Uyarı Ekranı", bool aError = true)
        {
            using (SimpleMsgBoxForm frm = new SimpleMsgBoxForm(aMessage, aTitle, aError))
            {
            }
        }
        public static DialogResult ShowYesNo(string aMessage, string aTitle = "Uyarı Ekranı", bool aError = true)
        {
            using (SimpleMsgBoxForm frm = new SimpleMsgBoxForm())
            {
                frm.sbNo.Text = "Hayır";
                frm.sbOK.Text = "Evet";
                frm.sbNo.Visible = true;
                frm.lciNo.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                frm.Text = aTitle;
                frm.labelControl1.Text = aMessage;
                if (aError)
                    frm.labelControl1.BackColor = Color.Red;
                else
                    frm.labelControl1.BackColor = Color.Lime;
                frm.ShowDialog();
                return frm.Result;
            }
        }

        private void sbNo_Click(object sender, EventArgs e)
        {
            Result = DialogResult.No;
            Close();
        }
    }
}
