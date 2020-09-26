
using System;
class Assignment1 
{
    static void Main ()
    {

        CreateDirExecute obj = new CreateDirExecute ();
        bool res = obj.CreateSubDirectory ();
        if (res) 
        {
            Console.WriteLine ("Directory and sub-directory created");
        }
    }
}