string transmission = "AX?19??Q";
int markerCount = 0;

for(int i = 0; i < transmission.Length; i++)
{
    if(transmission[i].Equals('?'))
    {
        markerCount++;
        Console.WriteLine("Marker found at index " + i);
    }
}

Console.WriteLine($"Marker count: {markerCount}");
