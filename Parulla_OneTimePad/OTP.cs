using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parulla_OneTimePad
{
    class OTP
    {
        public StringBuilder Enkriptimi(StringBuilder Mesazhi, StringBuilder Key)
        {
            StringBuilder Rezultati = new StringBuilder(Mesazhi.ToString());

            for (int i = 0; i < Mesazhi.Length; i++)
            {
                Rezultati[i] = (char)(Mesazhi[i] ^ Key[i]);

            }

            return Rezultati;
        }

        public string GjeneroCelesin(int gjatesia)
        {
            string karakteret = "ABCDEFGHIJKLMNOPQRSTUVXYZabcdefghijklmnopqrstuvxyz0123456789";
            char[] stringu = new char[gjatesia];

            var random = new Random();

            for (int i = 0; i < stringu.Length; i++)
            {
                stringu[i] = karakteret[random.Next(karakteret.Length)];
            }

            string key = new string(stringu);

            return key;
        }
    }
}
