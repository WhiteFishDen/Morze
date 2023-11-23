
using Morse;
internal class Program
{


    private static void Main(string[] args)
    {
        decryptor decryptor = new();
        Console.Write("Введите фразу для шифровки: ");
        string? inputLetter = Console.ReadLine();
        if(inputLetter is not null)
            Console.WriteLine("\tШифровка по коду Морзе: "+decryptor.ToMorse(inputLetter));

        Console.Write("Введите код Морзе для расшифровки: ");
        string? inputMorse = Console.ReadLine();
        if(inputMorse is not null)
            Console.WriteLine("\tРасшифровка с кода Морзе: "+decryptor.ToLetter(inputMorse));
    }
}