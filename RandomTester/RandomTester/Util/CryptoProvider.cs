using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using System.Diagnostics;

namespace RandomTester.Util
{
    public class CryptoProvider
    {
        public int NumOfIterations = 0;
        public byte[] RNGCryptogenerator()
        {
            byte[] data = new byte[4];
            using (StreamWriter w = File.AppendText("Benchmark.txt"))
            {
                Stopwatch stopWatch = new Stopwatch();
                w.WriteLine("RNG Crypto Output:");
                w.WriteLine($"With Iteration Count: {NumOfIterations}");
                stopWatch.Start();
                using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
                {

                    for (int i = 0; i < NumOfIterations; i++)
                    {
                        rng.GetBytes(data);
                    }

                }
                stopWatch.Stop();

                w.WriteLine($"Elapsed Time:{stopWatch.Elapsed}");
                w.WriteLine();
            }
            return data;
        }

        public void RandomGenerator()
        {
            Random random = new Random();
            using (StreamWriter w = File.AppendText("Benchmark.txt"))
            {
                Stopwatch sw = new Stopwatch();
                w.WriteLine("Normal Random");
                w.WriteLine($"With Iteration Count: {NumOfIterations}");
                sw.Start();
                for (int i = 0; i < NumOfIterations; i++)
                {
                    int value = random.Next(0, NumOfIterations);

                }
                sw.Stop();
                w.WriteLine($"Elapsed Time:{sw.Elapsed}");
                w.WriteLine();
            }
        }

    }
}
