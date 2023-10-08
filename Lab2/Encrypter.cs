using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Encrypter
    {
        readonly static string alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        public static string EncryptMessage(string message, string key)
        {
            message = message.ToLower();
            string encryptedMessage = "";
            int index;
            for (int i = 0; i < message.Length; i++) 
            {
                if ((index = alphabet.IndexOf(message[i])) < 0)
                    continue;
                encryptedMessage += key[index];
            }
            return encryptedMessage;
        }
    }
}
