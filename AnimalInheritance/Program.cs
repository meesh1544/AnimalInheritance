// base Class 
class Animal
{
    private string name; // only accessible within this class
    protected string type; //accessible from derived classes
    public string color;  // accessible from any class

    public void setName(string name)
    {
        this.name = name;
    }
    public virtual string getName()
    {
        return this.name;
    }
    public void setType(string type)
    {
        this.type = type;
    }
    public virtual string getType()
    {
        return this.type;
    }
}
class Elephant : Animal
{
    public string strength;
    public string gender;
    protected int age;
    
    public void setStrength(string strength)
    {        this.strength = strength;
    }
    public virtual string GetGender() 
    { 
        return gender; 
    }
    public void setGender(string gender)
    {
        this.gender = gender;
    }
    public virtual string getGender()
    {
        return gender;
    }
    public void setAge(int age)
    {
        this.age = age;
    }
    public virtual int getAge()
    {
        return age;
    }
    public override string getName()
    {
        return base.getName();
    }
    public override string getType()
    {
        return type;
    }
    public virtual string sound()
    {
        return "sounds of a trumpet";
    }
}
class Program
{
    static void Main(string[] args)
    {
        // object of the base class Animal
        Animal bunny = new Animal();
        bunny.setName("Bugs");
        bunny.setType("Lionhead Bunny");
        // color is a public field and can be accessed anywhere
        bunny.color = "spotted";

        Console.WriteLine("Animal Information...");
        Console.WriteLine($"My name is {bunny.getName()}");
        Console.WriteLine($"I am a {bunny.getType()}");
        Console.WriteLine($"I am a lovely {bunny.color} color");
        Console.WriteLine();

        // object of derived class 
        Elephant calf = new Elephant();
        calf.setName("Lana");
        calf.setType("African Elephant");
        calf.setStrength("Strong");
        // color is a public field and can be accessed anywhere
        calf.color = "Gray";
        //  public field
        calf.gender = "Female";
        // age is a protected field
        calf.setAge(3);
        
        Console.WriteLine("Elephant Information...");
        Console.WriteLine($"My name is {calf.getName()}");
        Console.WriteLine($"I am a {calf.gender} {calf.getType()}");
        Console.WriteLine($"I am {calf.strength}");
        Console.WriteLine($"I am a lovely {calf.color} color");
        Console.WriteLine($"I am {calf.getAge()} years old");
        Console.WriteLine($"I make noise like {calf.sound()}");

        Console.ReadLine(); // pauses end of program display
    }

}

