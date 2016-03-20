using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace RSA_code
{
    public class RSA_vs
    {
        public static RSACryptoServiceProvider rsa;

        public static void AssignParameter()
        {
            const int PROVIDER_RSA_FULL = 1;
            const string CONTAINER_NAME = "SpiderContainer";
            CspParameters cspParams;
            cspParams = new CspParameters(PROVIDER_RSA_FULL);
            cspParams.KeyContainerName = CONTAINER_NAME;
            cspParams.Flags = CspProviderFlags.UseMachineKeyStore;
            cspParams.ProviderName = "Microsoft Strong Cryptographic Provider";
            rsa = new RSACryptoServiceProvider(cspParams);
        }

        public static string EncryptData(string data2Encrypt)
        {
            AssignParameter();
            byte[] plainbytes = System.Text.Encoding.UTF8.GetBytes(data2Encrypt);
            byte[] cipherbytes = rsa.Encrypt(plainbytes, false);
            return Convert.ToBase64String(cipherbytes);
        }

        public static void AssignNewKey()
        {
            AssignParameter();
            string publicPrivateKeyXML = rsa.ToXmlString(true);
            string publicOnlyKeyXML = rsa.ToXmlString(false);
        }

        public static string DecryptData(string data2Decrypt)
        {
            AssignParameter();
            byte[] getpassword = Convert.FromBase64String(data2Decrypt);
            byte[] plain = rsa.Decrypt(getpassword, false);
            return System.Text.Encoding.UTF8.GetString(plain);

        }
    }
}
