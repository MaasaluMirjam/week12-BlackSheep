using System;
using System.IO;

namespace Seasons
{
    class Program
    {
        static void Main(string[] args)
        {
            //Loo programm, mis loeks winter.txt ja autumn.txt failide sisu maha, ja siis kirjutaks talvekuude loetelu winter.txt 
            //failisse ja sügiskuude loetelu autumn.txt failisse.

            string autumnFile = @"C:\Users\opilane\samples\autumn.txt";
            string winterFile = @"C:\Users\opilane\samples\winter.txt";

            string[] winterData = File.ReadAllLines(autumnFile);
            string[] autumnData = File.ReadAllLines(winterFile);

            File.WriteAllLines(autumnFile, autumnData);
            File.WriteAllLines(winterFile, winterData);
        }
    }
}
