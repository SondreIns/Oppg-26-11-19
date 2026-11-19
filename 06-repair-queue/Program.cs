List<string> repairs = new List<string>
{
    "Replace antenna",
    "CANCELLED: Paint corridor",
    "Seal cargo hatch",
    "Recalibrate sensor",
    "CANCELLED: Move storage crate"
};

int jobNumber = 1;
List<string> repairJobs = [];
foreach (string repair in repairs)
{
    string[] check = repair.Split(' ');
    if (check[0].Equals("CANCELLED:")) continue;

    repairJobs.Add($"Job {jobNumber}: {repair}");
    jobNumber++;
}

foreach(string job in repairJobs) Console.WriteLine(job);
