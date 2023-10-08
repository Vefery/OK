using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class AlphabetShuffler
    {
        public static string GetShuffledAlphabet()
        {
            char[] alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя".ToCharArray();
            int j;
            for (int i = alphabet.Length - 1; i > 0; i--)
            {
                j = new Random().Next(0, i + 1);
                (alphabet[i], alphabet[j]) = (alphabet[j], alphabet[i]);
            }
            return new string(alphabet);
        }
    }
}