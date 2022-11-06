class Program
{
    static void Main()
    {
        Animal[] animals = new Animal[]
        {
            new Dog(),
            new Snake(),
            new Dog()
        };

        foreach (var animal in animals)
        {
            animal.AnimalSound();
        }
    }
}



abstract class Animal {
    public abstract void AnimalSound();
}

class Snake : Animal 
{
    public override void AnimalSound()
    {
        System.Console.WriteLine("hissss");
    }
}
class Dog : Animal 
{
    public override void AnimalSound()
    {
        System.Console.WriteLine("meow");
    }
}