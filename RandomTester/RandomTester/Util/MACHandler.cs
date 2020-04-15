using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace RandomTester.Util
{
    public class MACHandler
    {
        private HMAC myMAC;
        public HMAC GetMacFromInput(string input)
        {
            switch (input)
            {
                case "1":
                    myMAC = new HMACSHA1();
                    return myMAC;
                case "2":
                    myMAC = new HMACMD5();
                    return myMAC;
                case "3":
                    myMAC = new HMACSHA256();
                    return myMAC;
                case "4":
                    myMAC = new HMACSHA384();
                    return myMAC;
                case "5":
                    myMAC = new HMACSHA512();
                    return myMAC;
                case "6":
                    return myMAC;
                default:
                    return myMAC;
            }

        }

        public byte[] ComputeMAC(byte[] message, byte[] key)
        {
            myMAC.Key = key;
            return myMAC.ComputeHash(message);
        }

        public string ByteArrayToString(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:x2}", b);
            return hex.ToString();
        }
    }
}
