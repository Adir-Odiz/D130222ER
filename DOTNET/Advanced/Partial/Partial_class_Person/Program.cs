class Program
{
    static void Main(string[] args)
    {
        Person p = new Person()
        {
            Age = 44
            Name = "Moshe"
        };
        System.Console.WriteLine(p.GetDetails());
    }
}
public partial class Person {

}