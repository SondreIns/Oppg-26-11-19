List<string> beacons = new List<string>();

while (true)
{
    string? choice = PrintMenu();

    if (choice == "1") 
        AddBeacon();
    else if (choice == "2")
        RemoveBeacon();
    else if (choice == "3")
        ListBeacons();
    else if (choice == "4")
        break;
    else
        Console.WriteLine("Unknown choice.");
}

// TODO: Refaktorer den fungerende koden over til flere metoder.
string PrintMenu()
{
    Console.WriteLine();
    Console.WriteLine("1 - Add beacon");
    Console.WriteLine("2 - Remove beacon");
    Console.WriteLine("3 - List beacons");
    Console.WriteLine("4 - Quit");
    Console.Write("Choice: ");
    return Console.ReadLine();
}

string GetBeaconName()
{
    Console.Write("Beacon name: ");
    return Console.ReadLine();
}

void AddBeacon()
{
    string? name = GetBeaconName();
    if (!string.IsNullOrWhiteSpace(name))
    {
        beacons.Add(name);
        Console.WriteLine("Beacon added.");
    }
}

void RemoveBeacon()
{
    string? name = GetBeaconName();
    if (name is not null && beacons.Remove(name))
    {
        Console.WriteLine("Beacon removed.");
    }
    else
    {
        Console.WriteLine("Beacon not found.");
    }
}

void ListBeacons()
{
    if (beacons.Count == 0)
    {
        Console.WriteLine("No beacons registered.");
    }
    else
    {
        foreach (string beacon in beacons)
        {
            Console.WriteLine($"- {beacon}");
        }
    }
}
