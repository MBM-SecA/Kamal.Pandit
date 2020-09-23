using System;
using System.IO;

public class FileIO
{
    public void LearnFilehandling()
    {
        string fileName = "file.txt";
        if(File.Exists(fileName))
        {
            string fileContents = File.ReadAllText(fileName);
            Console.WriteLine(fileContents);
        }
        File.WriteAllText(fileName,"This is just a text file.");
        /*
        // Absolute path
        string fileContent = File.ReadAllText(@"C:\Users\kamal\Desktop\CSharp\Kamal.Pandit\CSharpBasic\File.txt");
        Console.WriteLine(fileContent);

        // Relative path
        string fileRead = File.ReadAllText("Collection.cs");
        Console.WriteLine(fileRead);
        */
    }
    public void learnFileInfo()
    {
        string fileName = "file.txt";
        FileInfo fileInfo = new FileInfo(fileName);

        var size = fileInfo.Length;
        var createdDate = fileInfo.CreationTime;

        Console.WriteLine($"File Size: {size} bytes");
        Console.WriteLine($"Created date: {createdDate}");

    }
    public void LearnDirectories()
    {
        string directoryName = "K";
        Directory.CreateDirectory(directoryName);
    }
}