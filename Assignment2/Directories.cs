using System;
using System.IO;

public class CreateDirExecute
{

    internal bool CreateDir () 
    {
        Directory.CreateDirectory ("ABC");
        return true;
    }

    internal bool CreateSubDirectory()
    {
        bool res = CreateDir ();
        if (res)
        {
            for (int i = 1; i <= 10; i++)
            {
                Directory.CreateDirectory ($"ABC/abc{i}");
                string programSource = "using System;namespace Assignment2 { class PrintHelloWorld {void Display(){ Console.WriteLine(\"Hello world\");}}}";
                File.WriteAllText ($"ABC/abc{i}/program.cs", programSource);
            }
        }
        return true;
    }
}