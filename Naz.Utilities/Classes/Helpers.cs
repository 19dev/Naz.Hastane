using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Naz.Utilities.Classes
{
    public static class Helpers
    {
        public static string GetMoneyToTrString(string number)
        {
            int pos = 0;
            string sol = "";
            while (pos < number.Length && char.IsNumber(number[pos]))
            {
                sol += number[pos];
                pos++;
            }
            pos++;
            string sag = "";
            while (pos < number.Length && char.IsNumber(number[pos]))
            {
                sag += number[pos];
                pos++;
            }
            if (sag.Length != 0)
            {
                sag = sag + "0";
                sag = sag.Substring(0, 2);
            }
            int arraysize = 0;
            if (sol.Length % 3 == 0)
                arraysize = sol.Length / 3;
            else
                arraysize = (sol.Length / 3) + 1;
            int kalan = sol.Length % 3;
            int[] array = new int[arraysize];
            int arraypos = 0;
            if (kalan != 0)
            {
                array[0] = int.Parse(sol.Substring(0, kalan));
                arraypos = 1;
            }
            for (int i = kalan; i + 2 < sol.Length; i = i + 3)
            {
                array[arraypos] = int.Parse(sol.Substring(i, 3));
                arraypos++;
            }
            string result = "";
            string[] sayi = { "", "BİR", "İKİ", "ÜÇ", "DÖRT", "BEŞ", "ALTI", "YEDİ", "SEKİZ", "DOKUZ" };
            string[] birim = { "", "ON", "YİRMİ", "OTUZ", "KIRK", "ELLİ", "ALTMIŞ", "YETMİŞ", "SEKSEN", "DOKSAN", "YÜZ" };
            string[] birim2 = { "", "BİN", "MİLYON", "MİLYAR", "TRİLYON" };
            //string[] sayi = { "", "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz" };
            //string[] birim = { "", "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan", "yüz" };
            //string[] birim2 = { "", "bin", "milyon", "milyar", "trilyon" };
            string[] birim3 = { "TL", "KURUŞ" };
            for (int i = array.Length - 1; i >= 0; i--)
            {
                int mod = 0;
                string tmp = "";
                if (array[i] / 100 != 0)
                {
                    mod = 1000;
                    if ((array[i] % mod) / 100 == 1)
                        tmp += birim[10];
                    else
                        tmp += sayi[(array[i] % mod) / 100] + birim[10];
                }
                if (array[i] / 10 != 0)
                {
                    mod = 100;
                    tmp += birim[(array[i] % mod) / 10];
                }
                mod = 10;
                tmp += sayi[(array[i] % mod)];
                result = tmp + birim2[array.Length - 1 - i] + result;
            }
            result += " " + birim3[0];
            if (sag != "")
            {
                if (int.Parse(sag) / 10 != 0)
                    result += birim[(int.Parse(sag) % 100) / 10];
                result += sayi[(int.Parse(sag) % 10)];
                result += " " + birim3[1];
            }
            result = "# " + result + "#";
            return result;
        }

    }

}
