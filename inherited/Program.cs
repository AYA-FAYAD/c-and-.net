// See https://aka.ms/new-console-template for more information


public abstract class BaseEmployee
{

    protected Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public BaseEmployee()
    {
        Id = Guid.NewGuid();
    }

    public abstract decimal CalculatePay(); //Ab

    public virtual string GetEmployeeDetail()
    {
        return $"{FirstName} {LastName}";
    }
}



public class Houremployee : BaseEmployee
{
    public decimal HourlRate { get; set; }
    public int HoursWorked { get; set; }

    public override decimal CalculatePay()
    {
        return HourlRate * HoursWorked;
    }
    public string GetIdFromChild()
    {
        return $"Employee ID (from child): {Id}"; // ✅ This works!
    }
    // public sealed override string GetEmployeeDetail()
    // {
    //     return $"Name :{FirstName} {LastName}, Hourly Rate :{HourlRate}";
    // }

    // public decimal calculateWeeklyPay(int hourWorked)
    // {
    //     return HourlRate * hourWorked;
    // }
}


public class SalariedEmployee : BaseEmployee
{
    public decimal Salary { get; set; }
    public override decimal CalculatePay()
    {
        return Salary / 52;
    }
}
public class Program
{
    public static void Main()
    {
        // BaseEmployee employee = new BaseEmployee(); YOU CANT CREATE NEW OBJ 
        // employee.FirstName = "aya";
        // employee.LastName = "fayad";

        // Console.WriteLine(employee.GetEmployeeDetail());
        Houremployee hourly = new Houremployee();
        hourly.FirstName = "hope";
        hourly.LastName = "fayyad";
        hourly.HourlRate = 10m;
        hourly.HoursWorked = 40;
        Console.WriteLine(hourly.GetEmployeeDetail());
        Console.WriteLine("weekly " + hourly.CalculatePay());
        SalariedEmployee weekly = new SalariedEmployee();
        weekly.Salary = 52000;
        Console.WriteLine(weekly.CalculatePay());
        Console.WriteLine(hourly.GetIdFromChild());

    }
}