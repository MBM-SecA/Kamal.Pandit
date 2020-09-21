namespace AllAboutClasses
{
    public class Country
    {
        public string Name{get; set;}
        public int Population{get; set;}
        public double Area{get;set;}
        public readonly double AREA = 422564.12;
        public static readonly bool IsOnEarth;
        // Default constructor
        public Country()
        {

        }
        //Parameterized constructor
        public Country(string name)
        {
            Name = name;

        }
        public Country(string name, int population, double area)
        {
            Name = name;
            Population = population;
            Area = area;
        }
        //Static constructor
        static Country()
        {
            IsOnEarth= true;
        }
        //Finalizer or destructor
        ~Country()
        {
            
        }
    }
    public class Demo
    {
        void DoSomething()
        {
            Country country1 = new Country();
            Country country2 = new Country("Nepal");

        }
    }
}