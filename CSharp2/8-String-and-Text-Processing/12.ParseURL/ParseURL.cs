using System;

class ParseURL
{
    static void Main()
    {
        // User input
        Console.Write("Enter URL address: ");
        string address = Console.ReadLine();

        // Parse protocol
        string protocol = address.Substring(0, address.IndexOf(':'));

        // Parse server
        int serverStartIndex = protocol.Length + 3;
        int resourceStartIndex = address.IndexOf('/', serverStartIndex);
        string server = address.Substring(serverStartIndex, resourceStartIndex - serverStartIndex);

        // Parse resource
        string resource = address.Substring(resourceStartIndex);

        // Print result
        Console.WriteLine("[protocol] = \"{0}\"", protocol);
        Console.WriteLine("[server] = \"{0}\"", server);
        Console.WriteLine("[resource] = \"{0}\"", resource);
    }
}
