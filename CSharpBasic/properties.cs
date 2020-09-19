using System;
internal class Person
{
    private byte age;
    private int grade;

    private DateTime dob;
     public string name;

    public byte Age
    {
        get{ return age;}
        set
        {
            if(value >20 && value <30)
            {
                age = value;
            }

        }
        
    }
    //Auto implemented properties

    public string Address{get; set;}
    
    // read only
    public string Name { get; }

    
}