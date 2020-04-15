using RandomTester.Models.Enums;
using RandomTester.Util;
using System;
using System.IO;

namespace RandomTester
{
    class Program
    {
        static void Main(string[] args)
        {
            // // // // RANDOM TASKS
            // Make a Provider
            //CryptoProvider crypto = new CryptoProvider();
            //Console.WriteLine("How many Iterations??");
            //var input = Console.ReadLine();
            //crypto.NumOfIterations = 10; // Set this to input

            //byte[] result = crypto.RNGCryptogenerator();
            //crypto.RandomGenerator();

            //int value = BitConverter.ToInt32(result, 0);

            //Console.WriteLine("RNG Crypto Provider Random Number:");
            //Console.WriteLine(value);
            // // // // RANDOM TASKS


            // ENCRYPTOR
            //Encrypter encrypt = new Encrypter();
            //var input = "Hola Viola";
            //Console.WriteLine($"Input is: {input}");
            //var newWord = encrypt.EncryptString(input);
            //Console.WriteLine($"Result was: {newWord}");
            //// ENCRYPTOR

            //// DESCRYPTOR
            //Console.WriteLine($"Decrypting: {newWord}");
            //var res = encrypt.DecryptString(newWord);
            //Console.WriteLine($"Result: {res}");
            // DECRYPTOR


            // Hash Helper
            while (true)
            {
                Console.WriteLine("Choose an Algorithm to Compute a MAC");
                var num = 1;
                foreach (var item in Enum.GetValues(typeof(Algorithms)))
                {
                    Console.WriteLine($"{num}. {item}");
                    num++;
                }

                var algoChoice = Console.ReadLine();
                if (algoChoice == "6") { Environment.Exit(0); }
                MACHandler macHandler = new MACHandler();
                macHandler.GetMacFromInput(algoChoice);


                Console.WriteLine("ASCII Key:");
                var key = Console.ReadLine();

                Console.WriteLine("Message: ");
                var message = Console.ReadLine();

                //Convert inputs to byte arrays
                byte[] byteKey     =    System.Text.Encoding.ASCII.GetBytes(key);
                byte[] byteMessage =    System.Text.Encoding.ASCII.GetBytes(message);

                var result = macHandler.ComputeMAC(byteMessage, byteKey);

                var resText = macHandler.ByteArrayToString(result);
                Console.WriteLine();
                Console.WriteLine("MAC OUPUTS:");
                Console.WriteLine($"ASCII: {resText}");

                Console.ReadLine();
            }



        }
    }
}
