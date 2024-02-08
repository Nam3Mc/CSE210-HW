// the parent class showing the "virtual" keyword included
public class Employee
{
  private float salary = 100f;

  public virtual float CalculatePay()
  {
    return salary;
  }
}

// a child class
public class HourlyEmployee : Employee
{
  private float rate = 9f;
  private float hours = 100f;

  public override float CalculatePay()
  {
    return rate * hours; // pay is calculated differently
  }
}

// Create a list of Employees
List<Employee> employees = new List<Employee>();

// Create different kinds of employees and add them to the same list
employees.add(new Employee());
employees.add(new HourlyEmployee());

// Get a custom calculation for each one
foreach(Employee employee in employees)
{
  float pay = employee.CalculatePay();
  Console.WriteLine(pay);
}


public class Program
{
    // ...

    static void DisplayPayCheck(Employee e)
    {
        float pay = e.CalculatePay();
        // ...
    }
}


public class Program
{
    // ...

    static Employee GetManager()
    {
        // ... code here to find the manager ...
        return theManager;
    }

    static void DisplayManagerPay()
    {
        Employee manager = GetManager();
        float pay = manager.CalculatePay();
        // ...
    }
}



// the parent class showing the "virtual" keyword included
public abstract class Employee
{
  private string _employeeName;

  // Notice the abstract method doesn't have a body at all (not even an empty one)
  // and it is followed by a semicolon.
  public abstract float CalculatePay();
}

// a child class
public class SalaryEmployee : Employee
{
  private float salary = 100f;

  public override float CalculatePay()
  {
    return salary;
  }
}

// a child class
public class HourlyEmployee : Employee
{
  private float rate = 9f;
  private float hours = 100f;

  public override float CalculatePay()
  {
    return rate * hours; // pay is calculated differently
  }
}



// the Employee interface
// The C# convention is that interface names begin with an I
public interface IEmployee
{
  float CalculatePay(); // interface method does not have a body
}

// a specific implementation of the Employee interface
public class SalariedEmployee : IEmployee
{
  private float salary = 100f;

  public float CalculatePay()
  {
    return salary;
  }
}

// another implementation of tbe Employee interface
public class HourlyEmployee : IEmployee
{
  private float rate = 9f;
  private float hours = 100f;

  public float CalculatePay()
  {
    return rate * hours;
  }
}
