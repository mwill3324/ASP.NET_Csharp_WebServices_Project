using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace Assignment_5_Final
{
    public class Class1
    {
        //Encryption

        public static string Encryption(string plainString)
        { // encryption using DES 
            byte[] seed = ASCIIEncoding.ASCII.GetBytes("cse44598");
            if (String.IsNullOrEmpty(plainString))
            {
                throw new ArgumentNullException("The input cannot be empty or null!");
            }
            SymmetricAlgorithm saProvider = DES.Create();
            MemoryStream mStream = new MemoryStream();
            CryptoStream cStream = new CryptoStream(mStream,
                saProvider.CreateEncryptor(seed, seed), CryptoStreamMode.Write);
            StreamWriter sWriter = new StreamWriter(cStream);
            // Continued next page
            sWriter.Write(plainString);
            sWriter.Flush(); // Buffer flush is necessary when switching writing modes
            cStream.FlushFinalBlock();
            return Convert.ToBase64String(mStream.GetBuffer(), 0, (int)mStream.Length);
        }

        public static string Decryption(string encryptedString)
        { // decryption using DES 
            try
            {
                byte[] seed = ASCIIEncoding.ASCII.GetBytes("cse44598");
                if (String.IsNullOrEmpty(encryptedString))
                {
                    throw new ArgumentNullException("The string cannot be empty or null!");
                }
                SymmetricAlgorithm saProvider = DES.Create();
                MemoryStream memStream = new MemoryStream
                        (Convert.FromBase64String(encryptedString));
                CryptoStream cStream = new CryptoStream(memStream,
                    saProvider.CreateDecryptor(seed, seed), CryptoStreamMode.Read);
                StreamReader reader = new StreamReader(cStream);
                return reader.ReadLine();
            }
            finally { }
        }


    }
}
