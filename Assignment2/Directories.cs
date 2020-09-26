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
        string fileContent = File.ReadAllText("HelloWorld.cs");
        if (res)
        {
            for (int i = 1; i <= 10; i++)
            {
                Directory.CreateDirectory ($"ABC/abc{i}");
                File.WriteAllText ($"ABC/abc{i}/program.cs", fileContent);
            }
        }
        return true;
    }
}