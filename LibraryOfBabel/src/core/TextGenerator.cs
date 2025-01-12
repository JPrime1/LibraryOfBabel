using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryOfBabel.src.core
{
    internal class TextGenerator
    {
        //some constants
        private const int PageLength = 3200;
        private const string Alphabet = "abcdefghijklmnopqrstuvwxyz, .";

        public TextGenerator() { }

        public static string GenerateText(int seed)
        {
            Random rng = new Random(seed);
            char[] text = new char[PageLength];

            for (int i = 0; i < PageLength; i++)
            {
                int index = rng.Next(Alphabet.Length);
                text[i] = Alphabet[index];
            }

            return new string(text);
        }
    }
}
