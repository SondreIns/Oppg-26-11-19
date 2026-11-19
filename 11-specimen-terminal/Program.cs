List<string> specimens = new List<string>();
bool running = true;

while (running)
{
    Console.Write("Command (ADD/REMOVE/LIST/COUNT/QUIT): ");
    string? command = Console.ReadLine();
    switch (command.ToUpper())
    {
        case "ADD":
            Console.Write("Specimen to add: ");
            string? specimenToAdd = Console.ReadLine();
            if (string.IsNullOrEmpty(specimenToAdd))
            {
                Console.WriteLine("Specimen cannot be null or empty");
                break;
            }
            else if (specimens.Contains(specimenToAdd))
            {
                Console.WriteLine("Specimen already exists");
                break;
            }
            else
            {
                specimens.Add(specimenToAdd);
                break;
            }

        case "REMOVE":
            Console.Write("Specimen to remove: ");
            string? specimenToRemove = Console.ReadLine();
            if(string.IsNullOrEmpty(specimenToRemove) || !specimens.Contains(specimenToRemove))
            {
                Console.WriteLine("Specimen not found");
                break;
            }
            else
            {
                specimens.Remove(specimenToRemove);
                break;
            }

        case "LIST":
            foreach(string s in specimens) Console.WriteLine(s);
            break;

        case "COUNT":
            Console.WriteLine("Specimen count: " + specimens.Count);
            break;

        case "QUIT":
            running = false;
            break;
        default:
            Console.WriteLine("Invalid command.");
            break;
    }
}

