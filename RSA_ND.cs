using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security;
using System.Security.Cryptography;
using System.Xml;
using System.IO;
using System.Numerics;

namespace GR15_Detyra2
{
    class RSA_ND
    {
        private BigInteger Eksponenti;
        private BigInteger D;
        private BigInteger Moduli;
        RSACryptoServiceProvider objRSA = new RSACryptoServiceProvider();

        public void TeDhenatPublikeXML(string file)
        {
            if (!File.Exists(file))
            {
                throw new FileNotFoundException("Fajlli ne filen:" + file + " nuk ekziston!");
            
            }
            try
            {
                objRSA.FromXmlString(File.ReadAllText(file));
                RSAParameters Parametrat = objRSA.ExportParameters(false);

                ///// EKSPONENTI //////
                byte[] eksponent = Parametrat.Exponent;
                Array.Reverse(eksponent);
                Eksponenti = new BigInteger(eksponent.Concat(new byte[] { 0 }).ToArray());

                /////MODULI///////
                byte[] modul = Parametrat.Modulus;
                Array.Reverse(modul);
                Moduli = new BigInteger(modul.Concat(new byte[] { 0 }).ToArray());

            }
            catch(XmlSyntaxException xE)
            {
                string arsye = "Fajlli i dhene nuk eshte fajll valid XML ";
                throw new Exception(arsye, xE);
 
            }
            catch(CryptographicException cE)
            {
                string arsye = "Fajlli i dhene nuk eshte fajll valid i celesave";
                throw new Exception(arsye, cE);

            }
            catch(Exception m )
            {
                string arsye = "Ka ndodhur gabim ne ekzekutimin e programt";
                throw new Exception(arsye, m);

            }
 
        }
        public void TeDhenatPrivateXML(string file)
        {
            if (!File.Exists(file))
            {
                throw new FileNotFoundException("Fajlli ne filen:" + file + " nuk ekziston!");
            }
            try
            {
                objRSA.FromXmlString(File.ReadAllText(file));
                RSAParameters parametrat = objRSA.ExportParameters(true);

                ///// EKSPONENTI //////
                byte[] eksponent = parametrat.Exponent;
                Array.Reverse(eksponent);
                Eksponenti = new BigInteger(eksponent.Concat(new byte[] { 0 }).ToArray());

                /////MODULI///////
                byte[] modul = parametrat.Modulus;
                Array.Reverse(modul);
                Moduli = new BigInteger(modul.Concat(new byte[] { 0 }).ToArray());
                byte[] dparam = parametrat.D;
                Array.Reverse(dparam);
                D = new BigInteger(dparam.Concat(new byte[] { 0 }).ToArray());

            }
            catch (Exception m)
            {
                string arsye = "Ka ndodhur gabim gjate ekzekutimit";
                throw new Exception(arsye, m);
            }
        }
        public byte[] Enkriptimi(byte [] plain)
        {
            BigInteger plaintexti = new BigInteger(plain);
            BigInteger ciphertexti = BigInteger.ModPow(plaintexti, Eksponenti, Moduli);
            return ciphertexti.ToByteArray();
 
        }
        public byte[] Dekriptimi(byte[] cipher)
        {
            BigInteger ciphertexti = new BigInteger(cipher);
            BigInteger plaintexti = BigInteger.ModPow(ciphertexti, D, Moduli);
            return plaintexti.ToByteArray();
        }
        public byte[] NenshkrimiDigjital(byte[] plaintexti)
        {
            SHA1CryptoServiceProvider objhash = new SHA1CryptoServiceProvider();
            byte[] Hashi = objhash.ComputeHash(plaintexti);

            BigInteger HASH = new BigInteger(Hashi);
            BigInteger Nenshkrimi = BigInteger.ModPow(HASH, D, Moduli);
            return Nenshkrimi.ToByteArray();
        }
        public byte []  VerifikimiNenshkrimit(byte[] Nenshkrimi, byte [] plaintexti)
        {
            SHA1CryptoServiceProvider objhashi = new SHA1CryptoServiceProvider();
            BigInteger bg_Nenshkrimi =BigInteger.ModPow(new BigInteger (Nenshkrimi),Eksponenti,Moduli);
            byte[] byte_Nenshkrimi = bg_Nenshkrimi.ToByteArray();
            byte[] hashi_plain = objhashi.ComputeHash(plaintexti);

            if (hashi_plain.SequenceEqual(byte_Nenshkrimi))
            {
                MessageBox.Show("Verifikimi perfundoi me sukses!");
            }
            else
            {
                MessageBox.Show("Verifikimi deshtoi!");
            }
            return bg_Nenshkrimi.ToByteArray();
            
 
        }
        public void Dispose()
        {
            objRSA.Clear();
        }


    }

}
