string path = @"C:\Users\JV\data";
string fileName = "chuck.txt";
string[] lines = File.ReadAllLines(.Combine(, ));

ShowFileContent();

static ShowFileContent(string[] fileContentArray)
{
    int i = ;
    foreach (line in fileContentArray)
    {
        Console.WriteLine($"{i}. {}");
        i++;
    }
}

