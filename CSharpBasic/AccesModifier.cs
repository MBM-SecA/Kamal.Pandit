class AccessModifier
{
    internal void DoSomething()
    {

    }
    public void DoAnotherThing()
    {
        DoSomething();

    }
}
class ModifierDemo
{
    void DoSomething()
    {
        AccessModifier accessModifier = new AccessModifier();
        accessModifier.DoSomething();
    }
    void DoAnotherThing()
    {
        Person person = new Person();
        person.name = "kamal";
        person.Age = 19;
        person.Age = 24;

    }
}