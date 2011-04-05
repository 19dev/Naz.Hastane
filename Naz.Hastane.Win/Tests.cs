using Naz.Hastane.Data.Services;
using Naz.Utilities.Classes;
using Naz.Hastane.Data.Entities.LookUp.Special;
using System.Windows.Forms;

namespace Naz.Hastane.Win
{
    public static class Tests
    {
        public static void TestUsers()
        {
            Encrypter en = new Encrypter();
            var users = LookUpServices.Users;

            foreach (User user in users)
            {
                if (user.USER_PASS.Length == 1)
                {
                    en.CodeWord = user.USER_ID;
                    string s = en.Encrypt("1");
                    if (s != user.USER_PASS)
                    {
                        MessageBox.Show(user.USER_ID + " Hatalı Password!");
                    }
                }
            }
        }

        public static void TestNewIDGenerators()
        {
            LookUpServices.GetNewTellerInvoiceNo(UIUtilities.CurrentUser);
            LookUpServices.GetNewTellerVoucherNo(UIUtilities.CurrentUser);
            LookUpServices.GetNewAdvancePaymentNo();
            LookUpServices.GetNewVoucherNo();
            LookUpServices.GetNewInvoiceNo();
        }
    }
}
