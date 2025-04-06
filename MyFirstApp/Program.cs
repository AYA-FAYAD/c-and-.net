// See https://aka.ms/new-console-template for more information

//Classes
//All logic must come before class definitions
//  ❗ You must not define any class or namespace before that top-level code.
// All logic must come before class definitions.
// var person = new Person();
// person.Name = "aya fayyd";
// Console.WriteLine("Hello " + person.Name);
// public class Person
// {
//    public string Name;
// }

// The Structure of a C# Console App (Before .NET 6) 
// public class Program{
//   public static void Main(){
//     var person = new Person();
//     string name = person.Name;

//     name = "Aya fayad";
//     Console.WriteLine("HELLOOO " + name);
//   }
// }


// public class Person
// {
//   public string Name;
// }



public class Program(){

  public static void Main(){
    Person person = new Person();
    //we're setting the value of the private field _name 
    // through the public property Name, which has a set accessor.
    person.Name="Aya fayad";

    Console.WriteLine("hello " + person.Name);
  }
}

public class Person{
  private string _name;

  public string Name 
  {
    get {return _name;}
    set{_name=value;}

  }
}
















































// internal class Program{
//     private static  void Main(string[] args)
//    {
    // int a=1;
    // int b =2;
    // int c = AddNumbers(a,b);
 
    // Console.WriteLine(c);
    // Console.WriteLine("Hello, World!1");
    // Console.WriteLine(DateTime.UtcNow.ToLocalTime());
    // DayOfWeek today = DayOfWeek.Wednesday;
    // Console.WriteLine(today);
    // Console.WriteLine((int)today);
    // EmployeeType role = EmployeeType.Manager;
    // Console.WriteLine(role);
    // Console.WriteLine((int)role);
    // var myTuple = (42, "Hello", true);
    // Console.WriteLine(myTuple.Item1); // Output: 42
    // Console.WriteLine(myTuple.Item2); // Output: Hello
    // Console.WriteLine(myTuple.Item3); // Output: true

  //   int age = 18;
  //   if(age >=18){
  //     Console.WriteLine("you are adult ");
  //   }

    
  //  } 

  //  public static int  AddNumbers(int a, int b)
  //  {
  //    return a + b;
  //  }
  
// method overloading
  // public  static int  AddNumbers(int a, int b, int c)
  //  {
  //    return a + b;
  //  }
  //   public static void PrintMessage()
  //   {

  //   }

    // branching logic

    // public static bool IsEven(int number){
    //      if(number % 2 ==0){
    //         return true;
    //      }
    //      return false;
    // }

//    public  static int  AddNumbers(params int integers)
//    {
//      return a + b;
//    }
// }


/*
int numberOftime;
numberOftime =5;
Console.WriteLine(numberOftime);
*/
/*
int num =4;
Console.WriteLine(num);
*/
// enum EmployeeType
// {
//     Manager,
//     Supervisor,
//     Worker
// }
//  enum DayOfWeek
// {
//     Sunday,    // 0
//     Monday,    // 1
//     Tuesday,   // 2
//     Wednesday, // 3
//     Thursday,  // 4
//     Friday,    // 5
//     Saturday   // 6
// }
