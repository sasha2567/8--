using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class DigitalSignatureHelper
    {
        private RSAParameters m_public;	 
        public byte[] CreateSignature(byte[] hash)
	    {
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            RSAPKCS1SignatureFormatter RSAFormatter = new RSAPKCS1SignatureFormatter(RSA);
            RSAFormatter.SetHashAlgorithm("MD5");
            m_public = RSA.ExportParameters(false);
            return RSAFormatter.CreateSignature(hash);
        }

        public bool VerifySignature(byte[] hash, byte[] signedhash)
        {
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            RSAParameters RSAKeyInfo = new RSAParameters();
            RSAKeyInfo.Modulus = m_public.Modulus;
            RSAKeyInfo.Exponent = m_public.Exponent;
            RSA.ImportParameters(RSAKeyInfo);
            RSAPKCS1SignatureDeformatter RSADeformatter = new RSAPKCS1SignatureDeformatter(RSA);
            RSADeformatter.SetHashAlgorithm("MD5");
            return RSADeformatter.VerifySignature(hash, signedhash);
        }
    }
}
