
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

string apppath = @"..\..\..\";
string folderpath = apppath + @"Files\";
string filepath = folderpath + @"names.txt";

#region         Creating
if (!Directory.Exists(folderpath))
{
    Directory.CreateDirectory(folderpath);
    Console.WriteLine("Folder Path Created");

    if (!File.Exists(filepath + @"names.txt"))
    {
        File.Create(filepath + @"names.txt").Close();
        Console.WriteLine("names.txt Created: " + filepath);
    }
}
bool folderExists = Directory.Exists(folderpath);
Console.WriteLine("Does Directory exist: = " + folderExists);

bool namestxtExists = File.Exists(filepath + @"names.txt");
Console.WriteLine("Does file exist: = " + namestxtExists);
#endregion

#region         Writing - Reading

string textFilenames = folderpath + @"names.txt";

//if (File.Exists(textFilenames))
//{
//    File.WriteAllText(textFilenames, "Names Database:\n");
//    Console.WriteLine("Written In names.txt\n");
//}

//if(File.Exists(textFilenames))
//{
//    string content = File.ReadAllText(textFilenames);
//    Console.WriteLine("\nText In File:" + textFilenames + "\n");
//    Console.WriteLine(content);
//}
#endregion

#region         Writing Names In File
Console.WriteLine("Which Program: Add Names = A\n" +
                                " Filter Names = F");
string AF = Console.ReadLine().ToUpper();

if (AF == "A")
{
    Console.WriteLine("Adding Names");
    WriteNames();
}
if(AF == "F")
{
    Console.WriteLine("Filter names.txt");
    FilterNames();
}
static void WriteNames()
{
    string apppath = @"..\..\..\";
    string folderpath = apppath + @"Files\";
    string textFilenames = folderpath + @"names.txt";

    Console.WriteLine("Enter Name to Include in Database");
    string nameInput = Console.ReadLine();

    using (StreamWriter sw = new StreamWriter(textFilenames, true))
    {
        sw.WriteLine("\n" + nameInput);
    }
    if (File.Exists(textFilenames))
    {
        string content = File.ReadAllText(textFilenames);
        Console.WriteLine("\nText In File:" + textFilenames + "\n");
        Console.WriteLine(content);
    }

    //..........................                CONTINUE?
    Console.WriteLine("Add More Names?");
    string YN = Console.ReadLine().ToUpper();

    if (YN == "Y")
    {
        Console.WriteLine("Write new name");
        WriteNames();
    }
    else
    {
        Console.WriteLine("         Quitting............");
    }
}
static void FilterNames()
{
    string apppath = @"..\..\..\";
    string folderpath = apppath + @"Files\";
    string textFilenames = folderpath + @"names.txt";
    ////////////////////////////////////////////////////////
    //          Read Text and Filter


    string alphabet = "abcdefghijklmnopqrstuvwxyz";

    if (File.Exists(textFilenames))
    {
        List<string> content = File.ReadAllLines(textFilenames).ToList();

        foreach (char c in alphabet)
        {
        
        List<string> filter = content.Where(x => x.ToLower().StartsWith(c)).ToList();
        if (filter.Any()) { 
            foreach (string filterx in filter)
            {
                Console.WriteLine(filterx);
            }
                
            string filename = $"nameStartingWith_{char.ToUpper(c)}.txt";

            if (!File.Exists(folderpath + filename))
            {
                File.Create(folderpath + filename).Close();
                Console.WriteLine($"{filename} Created: " + textFilenames);
            }
            File.WriteAllLines(folderpath + filename, filter);
            }
        }
    }
}


#endregion












