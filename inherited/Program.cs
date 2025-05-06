// See https://aka.ms/new-console-template for more information

// public enum EmployeePymentType
// {
//     Hourly,
//     Salary
// }

public interface IPayable
{
    decimal CalculatePay();
}


public static class StringExtention
{
    public static bool IsPalindrome(this string str)
    {
        if (string.IsNullOrEmpty(str))
            return false;
        string revesed = new string(str.Reverse().ToArray());
        return str.Equals(revesed, StringComparison.OrdinalIgnoreCase);
    }
}
public class BaseEmployee
{
    // public EmployeePymentType PymentType { get; set; }
    protected Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    // public decimal HourlRate { get; set; }
    // public int HoursWorked { get; set; }
    // public decimal Salary { get; set; }




    public BaseEmployee()
    {
        Id = Guid.NewGuid();
    }

    // public abstract decimal CalculatePay(); //Ab

    public virtual string GetEmployeeDetail()
    {
        return $"{FirstName} {LastName}";
    }
    public Guid GetId() => Id;
}

public class Houremployee : BaseEmployee, IPayable
{
    public decimal HourlyRate { get; set; }
    public int HoursWorked { get; set; }

    public decimal CalculatePay()
    {
        return HourlyRate * HoursWorked;
    }

    public override string GetEmployeeDetail()
    {
        return $"Hourly Employee : {FirstName} {LastName} Rate: {CalculatePay()}";
    }

}

public class SalariedEmployee : BaseEmployee, IPayable
{
    public decimal AnnualSalary { get; set; }

    public decimal CalculatePay()
    {
        return AnnualSalary / 52;
    }

    public override string GetEmployeeDetail()
    {
        return $"Salaried Employee : {FirstName} {LastName} , per week {CalculatePay()}";
    }
}

// public class Houremployee : BaseEmployee
// {
//     public decimal HourlRate { get; set; }
//     public int HoursWorked { get; set; }


//     public override decimal CalculatePay()
//     {
//         return HourlRate * HoursWorked;
//     }
//     public string GetIdFromChild()
//     {
//         return $"Employee ID (from child): {Id}"; 
//     }
// public sealed override string GetEmployeeDetail()
// {
//     return $"Name :{FirstName} {LastName}, Hourly Rate :{HourlRate}";
// }

// public decimal calculateWeeklyPay(int hourWorked)
// {
//     return HourlRate * hourWorked;
// }
// }


// public class SalariedEmployee : BaseEmployee
// {
//     public decimal Salary { get; set; }
//     public override decimal CalculatePay()
//     {
//         return Salary / 52;
//     }
// }

// public class EmployeePayCalculator
// {
//     public decimal CalculatePay(BaseEmployee employee)
//     {
//         if (employee.PymentType == EmployeePymentType.Hourly)
//         {
//             return employee.HourlRate * employee.HoursWorked;
//         }
//         else if (employee.PymentType == EmployeePymentType.Salary)
//         {
//             return employee.Salary / 52;
//         }
//         else
//         {
//             throw new Exception("Unkown paymet type");
//         }




//     }
// }

public class Program
{
    public static void Main()

    {
        string word = "aya";
        Console.WriteLine(word.IsPalindrome());
        BaseEmployee employee = new BaseEmployee();
        employee.FirstName = "aya";
        employee.LastName = "fayyad";

        Houremployee hourly = new Houremployee
        {
            FirstName = "hope",
            LastName = "fayad",
            HourlyRate = 10m,
            HoursWorked = 40
        };

        SalariedEmployee salaried = new SalariedEmployee
        {
            FirstName = "Aya",
            LastName = "Fayad",
            AnnualSalary = 5400,

        };

        Console.WriteLine(hourly.GetEmployeeDetail());
        Console.WriteLine(salaried.GetEmployeeDetail());






        // BaseEmployee employee = new BaseEmployee(); YOU CANT CREATE NEW OBJ 
        // employee.FirstName = "aya";
        // employee.LastName = "fayad";
        // EmployeePayCalculator calculator = new EmployeePayCalculator();
        // BaseEmployee hourly = new BaseEmployee
        // {
        //     FirstName = "aya",
        //     LastName = "fayyad",
        //     PymentType = EmployeePymentType.Hourly,
        //     HourlRate = 10m,
        //     HoursWorked = 40
        // };


        // BaseEmployee salaried = new BaseEmployee
        // {
        //     FirstName = "hope",
        //     LastName = "fayad",
        //     PymentType = EmployeePymentType.Salary,
        //     Salary = 54000
        // };
        // Console.WriteLine(hourly.GetEmployeeDetail());
        // Console.WriteLine("Salaried weekly Pay:" + calculator.CalculatePay(hourly));
        // Console.WriteLine("Hourly Employye ID : " + hourly.GetId());


        // Console.WriteLine(salaried.GetEmployeeDetail());
        // Console.WriteLine("Salaried Weekly Pay: " + calculator.CalculatePay(salaried));
        // Console.WriteLine("Salaried Employee ID: " + salaried.GetId());

        // Console.WriteLine(employee.GetEmployeeDetail());
        // Houremployee hourly = new Houremployee();
        // hourly.FirstName = "hope";
        // hourly.LastName = "fayyad";
        // hourly.HourlRate = 10m;
        // hourly.HoursWorked = 40;
        // Console.WriteLine(hourly.GetEmployeeDetail());
        // Console.WriteLine("weekly " + hourly.CalculatePay());
        // SalariedEmployee weekly = new SalariedEmployee();
        // weekly.Salary = 52000;
        // Console.WriteLine(weekly.CalculatePay());
        // Console.WriteLine(hourly.GetIdFromChild());

    }
}