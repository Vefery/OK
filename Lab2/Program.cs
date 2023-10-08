using Lab2;

class Program
{

    public static void Main()
    {
        string shuffledAlphabet = AlphabetShuffler.GetShuffledAlphabet();
        string message;
        Console.WriteLine(shuffledAlphabet);
        message = Console.ReadLine();
        Console.WriteLine(Encrypter.EncryptMessage(message, shuffledAlphabet));
    }
}