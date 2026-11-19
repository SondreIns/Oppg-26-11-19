while (true)
{
    Console.Write("Command: ");
    string? command = Console.ReadLine();
    if(string.IsNullOrEmpty(command)|| command.ToUpper().Equals("EXIT") || command.Equals("null")) break;

    else Console.WriteLine($"Received: {command}");
}

Console.WriteLine("Receiver stopped.");
