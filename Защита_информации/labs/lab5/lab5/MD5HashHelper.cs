using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class MD5HashHelper
    {
        public byte[] GetHash(string message)
        {
	        byte[] data;
	        data = UTF8Encoding.ASCII.GetBytes(message);
	        MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
	        return md5.ComputeHash(data, 0, data.Length);
	    }

        public bool VerifyHash(string message, byte[] hash)
        {
            byte[] data;
            data = UTF8Encoding.ASCII.GetBytes(message);
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] hashTemp = md5.ComputeHash(data, 0, data.Length);

            for (Int32 counter = 0; counter <= hash.Length - 1; counter += 1)
            {
	            if (hash[counter] != hashTemp[counter])
	            {
	            return false;
	            }
            }
            return true;
        }
    }
}
