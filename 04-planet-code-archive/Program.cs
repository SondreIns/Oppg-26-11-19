string[] planetCodes = { "ORION-4", "KAPPA-9", "LYRA-2", "NOVA-7", "VEGA-3" };
bool found = false;

Console.WriteLine($"Number of planets: {planetCodes.Length}");
Console.WriteLine($"First planet: {planetCodes[0]}");
Console.WriteLine($"Last planet: {planetCodes[planetCodes.Length - 1]}");
foreach(string planet in planetCodes)
{
    if(planet.Equals("KAPPA-9")) found = true;
}

// TODO: Skriv Length, første og siste element.
// TODO: Finn KAPPA-9 med en løkke.

Console.WriteLine($"Found KAPPA-9: {found}");
