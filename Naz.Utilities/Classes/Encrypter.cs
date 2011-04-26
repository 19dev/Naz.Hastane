using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Naz.Utilities.Classes
{
    public class Encrypter
    {
        private string Matrix = "8x3p5BeabcdfghijklmnoqrstuvwyzACDEFGHIJKLMNOPQRSTUVWXYZ 1246790-.#/\\!@$<>&*()[]{};:,?=+~`^|%_İŞÜĞÇÖışüğçö\r\n\"";
        private string[] strCryptMatrix = new string[108];
        private string _CodeWord;

        public Encrypter()
        {
            strCryptMatrix[0] = Matrix;
            for(int i = 1; i < Matrix.Length; i++)
            {
                strCryptMatrix[i] = strCryptMatrix[i - 1].Substring(1, Matrix.Length - 1) + strCryptMatrix[i - 1].Substring(0, 1);
            }
        }

        public string CodeWord { set { _CodeWord = value;} }

        public string Encrypt(string msText)
        {
            string Str2Encrypt = msText;
            string EncryptedLetter = "";
            string EncryptedString = "";
            string C2E = "";
            string CWL = "";
            int MP = 0;
            int Y = 0;

            for (int i = 0; i < msText.Length; i++)
            {
                C2E = Str2Encrypt.Substring(i, 1);
                MP = Matrix.IndexOf(C2E);
                CWL = _CodeWord.Substring(Y, 1);
                for (int z = 0; z < Matrix.Length; z++)
                {
                    if (strCryptMatrix[z].Substring(MP, 1) == CWL)
                    {
                        EncryptedLetter = strCryptMatrix[z].Substring(0, 1) ;
                        EncryptedString = EncryptedString + EncryptedLetter;
                        break;
                    }
                }
                Y++;
                if (Y >= _CodeWord.Length) Y = 0;
            }

            return EncryptedString;
        }

    }
}
