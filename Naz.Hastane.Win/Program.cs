using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Nini.Config;

using Naz.Hastane.Data;
using Naz.Hastane.Win.Properties;
using Naz.Utilities.Classes;
using Naz.Hastane.Data.Services;
using Naz.Hastane.Data.Entities;

namespace Naz.Hastane.Win {
    static class Program {
        [STAThread]
        static void Main() {

            IConfigSource cs = new IniConfigSource("Naz.Hastane.ini");

            NHibernateSessionManager.Instance.DatabaseName = cs.Configs["Database"].Get("Name", "TIPDATA");
            NHibernateSessionManager.Instance.DatabasePassword = cs.Configs["Database"].Get("Password");
            NHibernateSessionManager.Instance.DatabaseServer = cs.Configs["Database"].Get("Server", "AydinLaptop");
            NHibernateSessionManager.Instance.DatabaseUserName = cs.Configs["Database"].Get("UserName", "sa");

            DevExpress.UserSkins.OfficeSkins.Register();
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new frmMain());
        }

    }
}