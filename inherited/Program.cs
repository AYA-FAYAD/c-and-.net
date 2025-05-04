// See https://aka.ms/new-console-template for more information
public class BaseEmployee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public virtual string GetEmployeeDetail()
    {
        return $"{FirstName} {LastName}";
    }
}

public class Houremployee : BaseEmployee
{
    public decimal HourlRate { get; set; }

    public decimal calculateWeeklyPay(int hourWorked)
    {
        return HourlRate * hourWorked;
    }
}

public class Program
{
    public static void Main()
    {
        BaseEmployee employee = new BaseEmployee();
        employee.FirstName = "aya";
        employee.LastName = "fayad";
        employee.GetEmployeeDetail();
        Console.WriteLine(employee.FirstName);
    }
}