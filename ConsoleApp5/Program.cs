using System;
using System.Text;

namespace ConsoleApp5
{
    class Program
    {
        /// Encode Shift Cipher
        public static void EncodeShiftCipher(string str, int k) 
        {
            Console.Write("k = " + k + " --> ");
            byte[] ASCIIvalues = Encoding.ASCII.GetBytes(str);
            foreach (var value in ASCIIvalues)
            {
                int tmp = 0;
                if (value >= 65 && value <= 90)
                    tmp = (value + k - 65) % 26 + 65;
                else if (value >= 97 && value <= 122)
                    tmp = (value + k - 97) % 26 + 97;
                else
                    tmp = value;
                Console.Write(Convert.ToChar(tmp));
            }
            Console.WriteLine();
        }

        /// Decode Shift Cipher with key
        public static void DecodeShiftCipher(string str, int k)
        {
            Console.Write("k = " + k);
            if (k > 26)
                k %= 26;
            int Dkey = 26 - k;
            byte[] ASCIIvalues = Encoding.ASCII.GetBytes(str);

            Console.Write(" --> Decode key = " + Dkey + " --> " );

            foreach (var value in ASCIIvalues)
            {
                int tmp = 0;
                if (value >= 65 && value <= 90)
                    tmp = (value + Dkey - 65) % 26 + 65;
                else if (value >= 97 && value <= 122)
                    tmp = (value + Dkey - 97) % 26 + 97;
                else
                    tmp = value;
                Console.Write(Convert.ToChar(tmp));
            }
            Console.WriteLine();
        }

        /// Decode Shift Cipher without key
        public static void DecodeShiftCipher(string str)
        {
            for (int i = 1; i <= 26; i++)
                DecodeShiftCipher(str, i);
        }

        static void Main(string[] args)
        {
            string str1 = "Xin chao cac Ban";
            string str2 = "Tej ydwk ywy Xwj";

            Console.WriteLine("Encode: " + str1);
            EncodeShiftCipher(str1, 100);
            Console.WriteLine();

            Console.WriteLine("Decode with known key ");
            DecodeShiftCipher(str2, 100);
            Console.WriteLine();

            Console.WriteLine("Decode without key ");
            DecodeShiftCipher(str2);
            Console.WriteLine();
        }
    }
}
