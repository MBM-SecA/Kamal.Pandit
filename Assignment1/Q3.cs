 /* Creates a function that takes a two word string separated by space and returns the concatenated first characters of both the words.
 Example: 
 GetInitials("Bishnu Rawal") => "BR"
 GetInitials("Alex Wales") => "AW"\
 */
 using System;

public class Question3
{
    internal string GetInitials(string name)
    {
        string initials = "";
        int len = name.Length;
        int i = 0;
        initials += name[0];
        for(i = 0; i < len; i++)
        {
            if (name[i] == ' ')
            {
                initials += name[++i];
                break;
            }
        }
        return initials;
    }
}