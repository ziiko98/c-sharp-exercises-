using System.Runtime.CompilerServices;

namespace c_sharp.exercise;

public class Employee
{
    
    private decimal salary;

    public Employee(decimal salary)
    {
        this.salary = salary;
    }
    private int VacationDays()
    {
        return 25;
    }
    public decimal IncomeTax()
    {
        int vacationDays = VacationDays();
        decimal tax = salary * 0.3m * (20 - vacationDays);
        return tax;
    
    }
}
