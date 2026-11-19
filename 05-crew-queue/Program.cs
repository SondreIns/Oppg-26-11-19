List<string> crew = new List<string> { "Bex", "Ivo", "Nia" };

crew.Add("Mira");
crew.Add("Sol");
crew.Remove("Bex");

Console.WriteLine($"Crew count: {crew.Count}");

foreach(string name in crew) Console.WriteLine(name);
