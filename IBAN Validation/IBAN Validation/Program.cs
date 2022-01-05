using System;
using System.Text.RegularExpressions;
using System.Text;

namespace IBAN_Validation
{
    class Program
    {
        static void Main(string[] args)
        {
            string iban = Console.ReadLine();
            Console.WriteLine(checkIban(iban));

           

        }
        static bool checkIban(string iban) {

           

            string pattern = "^BG[0-9A-Z]{20}$";

            Regex regex = new Regex(pattern);
            Match match = regex.Match(iban);

            if (!match.Success)
            {
                return false;
            }

            String bank = iban.Substring(4) + iban.Substring(0, 4);
            StringBuilder sb = new StringBuilder();
            foreach (char sym in iban)
            {
                if (char.IsDigit(sym))
                {
                    sb.Append(sym);
                }
                else
                {

                    sb.Append(sym - 'A' + 10);
                }
            }
            if (true)
            {

            }
            return true;
        }
    }

    




    }
}
