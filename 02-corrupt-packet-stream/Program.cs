string[] packets = { "P-100", "CORRUPT", "P-101", "P-102", "CORRUPT", "P-103" };
int processedCount = 0;

foreach (string packet in packets)
{
    if(packet.Equals("CORRUPT")) continue;
    Console.WriteLine($"Processed {packet}");
    processedCount++;
}

Console.WriteLine($"Processed packets: {processedCount}");
