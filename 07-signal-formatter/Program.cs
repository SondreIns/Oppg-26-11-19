Console.WriteLine(FormatSignal("moon-base"));
Console.WriteLine(FormatSignal("relay-7"));
Console.WriteLine(FormatSignal("cargo-deck"));

static string FormatSignal(string source) => $"[SIGNAL FROM: {source.ToUpper()}]";
