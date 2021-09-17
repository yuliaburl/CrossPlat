using System;
using System.IO;

namespace CrossPlat
{
    class Program
    {
        static bool Is(int k)
        {
            while (k % 2 == 0)
                k /= 2;
            while (k % 3 == 0)
                k /= 3;
            while (k % 5 == 0)
                k /= 5;
            return k == 1;
        }

        static int Run(int In)
        {
            int n = 0;     
            int Out = 1;  
            while (n != In)
            {
                if (Is(Out++)) n++; 
            }
            Out--;

            return Out;
        }
        static void Main(string[] args)
        {

            string PATH = @"C:\Users\Юлия\source\repos\CrossPlat\bin\Debug\netcoreapp3.1\";

            string INPUT_FILENAME = "input.txt";
            string OUTPUT_FILENAME = "output.txt";


            if (!File.Exists(PATH + INPUT_FILENAME))
            {
                using (StreamWriter sw = File.CreateText(PATH + INPUT_FILENAME))
                {
                    sw.WriteLine("9");
                }
            }

           

            int In;

            using (StreamReader sr = File.OpenText(PATH + INPUT_FILENAME))
            {
                In = Convert.ToInt32(sr.ReadLine());
            }

            int Out = Run(In);

           
            using (StreamWriter sw = File.CreateText(PATH + OUTPUT_FILENAME))
            {
                sw.WriteLine(Out.ToString());
            }

            Console.WriteLine("DONE :)");
        }
    }
}
