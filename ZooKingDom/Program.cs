
public class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("An animal makes a sound.");

    }

    public virtual void Move()
    {
        Console.WriteLine("The animal moves.");
    }
}

public class Lion : Animal
{
    public override void Speak()
    {
        Console.WriteLine("The lion roars ");
    }

    public override void Move()
    {
        Console.WriteLine("The lion struts proudly through the savanna.");
    }
}

public class Elephant : Animal
{
    public override void Speak()
    {
        Console.WriteLine(" The elephant trumpets");
    }

    public override void Move()
    {
        base.Move();
    }
}

public class Parrot : Animal
{
    public override void Speak()
    {
        Console.WriteLine("The parrot squawks");
    }

    public override void Move()
    {
        Console.WriteLine("The parrot flaps its wings and flies.");
    }
}

class Program
{
    static void Main()
    {
        Animal simba = new Lion();
        Animal babar = new Elephant();
        Animal hope = new Parrot();


        simba.Move();
        simba.Speak();

        Console.WriteLine();

        babar.Move();
        babar.Speak();

        Console.WriteLine();

        hope.Move();
        hope.Speak();

    }
}
