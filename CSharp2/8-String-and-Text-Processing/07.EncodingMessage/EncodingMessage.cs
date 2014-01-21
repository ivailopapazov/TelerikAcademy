using System;
using System.Text;

class EncodingMessage
{
    static string EncodeDecodeMessage(string message, string cipher)
    {
        // Variable declaration
        StringBuilder encryptedMessage = new StringBuilder();
        char encryptedCharacter = new char();

        // Encode
        for (int i = 0, j = 0; i < message.Length; i++, j %= cipher.Length)
        {
            // Character encryption
            encryptedCharacter = (char)(message[i] ^ cipher[j]);

            // Add to encrypted message
            encryptedMessage.Append(encryptedCharacter);
        }

        // Return encrypted message
        return encryptedMessage.ToString();
    }

    static void Main()
    {
        // User input
        Console.Write("Enter a cipher: ");
        string cipher = Console.ReadLine();
        Console.Write("Enter a message: ");
        string message = Console.ReadLine();

        // Encode message
        string encrypted = EncodeDecodeMessage(message, cipher);

        // Decode message
        string decrypted = EncodeDecodeMessage(encrypted, cipher);

        // Printe encoded message
        Console.WriteLine("Encoded message: {0}", encrypted);

        // Print decoded message
        Console.WriteLine("Decoded message: {0}", decrypted);

    }
}
