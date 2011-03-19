/*
    Bu yazýlýmýn tasarýmý ve kaynak kodlarý Datakent'e aittir.
    istenildiði gibi geliþtirilebilir, tasarýmý deðiþtirilebilir.
    yazýlýmdaki kodlar ve tasarým referans gösterilerek kullanýlabilir.
    ücretle VEYA dengi nesne karþýlýðýnda SATILMAMALIDIR.
    gönlüm bu yazýlýmýn insanlar tarafýndan serbestçe kullanýlmasýndan yanadýr.
    emeðe haksýzlýk yapmak istemiyorsanýz yazýlýmdaki DATAKENT'e ait bilgileri KALDIRMAYINIZ.
    yok ben emeði önemsemem, enayi gibi kodlarý yayýnlamasaydýnýz diyorsanýz ÝSTEDÝÐÝNÝZÝ yapabilirsiniz.
 
    http://www.datakent.com
    http://forum.datakent.com
    14-06-07
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Microsoft.Win32;

namespace meno
{
    static class GlobalClass
    {
        //static string nbs = "0123456789";
        //43000111000 - deneme kullanýcý adý ve þifre
        static public string WSDLUserName;

        static public string WSDLUserPassword ="";
        static public string xuserpass = "";
        static public string xuserID = "";
        static public string xtesiskodu = "";
        static public bool LoinErr = false;        


        static public string rgsk1 = "Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings\\ZoneMap\\AppSec";
        static public string rgsk0 = "App00";//MedulaUsername
        static public string rgsk2 = "App01";//medula pass
        static public string rgsk3 = "App02";//app pass
        static public string rgsk4 = "App03";//tesis kodu
        static public string rgsk5 = "App04";//UserID
        static public string menotitle = @"MENO v1.0 Beta1 [ Build on Medula ] - http://www.datakent.com'dan Ücretsiz ve Sýnýrsýz";

        
        static public string msg01 = "Ýþlem yapýlýyor... Lütfen bekleyiniz...";
        static public string msg02 = "Ýþlem baþarýyla tamamlandý.";
        static public string msg03 = "Hata oluþtu! Ýþlem baþarýsýz.";

        static public string GetAxPath()
        {
            return Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetModules()[0].FullyQualifiedName);
        }

        static public bool CheckDouble(string dt)
        {
            try
            {
                double i = Convert.ToDouble(dt);
                return true;
            }
            catch
            {
                return false;
            }
        }

        static public bool CheckInt(string dt)
        {
            try
            {
                int i = Convert.ToInt32(dt);
                return true;
            }
            catch
            {
                return false;
            }
        }

        static public bool CheckTime(string dt)
        {
            int hh = 0, mm = 0, ss = 10;
            if (dt.Trim().Length == 5)
            {
                int ix = dt.IndexOf(":");
                if (ix > 0)
                {
                    try
                    {
                        hh = Convert.ToInt32(dt.Substring(0, ix));
                        mm = Convert.ToInt32(dt.Substring(ix + 1, dt.Length - ix - 1));
                    }
                    catch
                    {
                        return false;
                    }
                    try
                    {
                        DateTime dtx = new DateTime(2007, 10, 9, hh, mm, ss);
                        return true;
                    }
                    catch
                    {
                        return false;
                    }
                }
                else return false;
            }
            return false;
        }

        static public bool CheckDate(string dt)
        {
            if (dt.Trim().Length == 10)
            {
                int yy = 0, dd = 0, mm = 0;
                int ix = dt.IndexOf(".");

                if (ix > 0)
                {
                    try
                    {
                        dd = Convert.ToInt32(dt.Substring(0, ix));
                        int iy = dt.IndexOf(".", ix + 1);
                        mm = Convert.ToInt32(dt.Substring(ix + 1, dt.Length - iy - ix - 1));
                        yy = Convert.ToInt32(dt.Substring(iy + 1, dt.Length - iy - 1));
                    }
                    catch
                    {
                        return false;
                    }

                    try
                    {
                        DateTime dtx = new DateTime(yy, mm, dd);
                        return true;
                    }
                    catch
                    {
                        return false;
                    }
                }
                else return false;
            }
            else return false;
        }

        static public void appStng()
        {
            try
            {
                RegistryKey hcr = Registry.CurrentUser;
                hcr = hcr.OpenSubKey(GlobalClass.rgsk1, true);
                if (hcr != null)
                {
                    WSDLUserPassword = (string)hcr.GetValue(GlobalClass.rgsk2, (string)"");
                    WSDLUserName = (string)hcr.GetValue(GlobalClass.rgsk0, (string)"");
                    xuserpass = (string)hcr.GetValue(GlobalClass.rgsk3, (string)"");
                    xtesiskodu = (string)hcr.GetValue(GlobalClass.rgsk4, (string)"");
                    xuserID = (string)hcr.GetValue(GlobalClass.rgsk5, (string)"");
                    //get user MEDULA USER NAME AND OTHERS                    
                    if (hcr != null)
                        hcr.Close();
                }
            }
            catch (Exception ex)
            {
                LoinErr = true;
                ErrFrm erxf = new ErrFrm();
                erxf.ermessage = ex.Message;
                erxf.ShowDialog();
                erxf.Dispose();
                System.Windows.Forms.Application.Exit();
            }
        }
    }
}