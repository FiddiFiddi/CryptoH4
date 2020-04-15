using System;
using System.Collections.Generic;
using System.Text;

namespace RandomTester.Util
{
    public class Encrypter
    {


        public string EncryptString(string input)
        {
            // Fails if input contains Spaces ( to be handled)
            string result = "";
            for (int i = 0; i < input.Length; i++)
            {
                int ASCIValue = input[i] + 1;
                char letter = (char)ASCIValue;           
                result += letter;
            }
            return result;
        }

        public string DecryptString(string input)
        {
            string result = "";
            for (int i = 0; i < input.Length; i++)
            {
                int ASCIValue = input[i] - 1;
                char letter = (char)ASCIValue;
                result += letter;
            }
            return result;
        }

    }
}
