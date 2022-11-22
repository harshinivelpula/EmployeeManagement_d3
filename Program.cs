using EmployeeManagement1;

namespace EmployeeManagement1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to Employee Wage Computation Program");
            //EmployeeSalary EmployeeSalary = new EmployeeSalary();
            //EmployeeSalary.EmployeeAttendance();
            //Console.ReadKey();
            //DailyEmployeeWage dailyEmployeeWage = new DailyEmployeeWage();
            //DailyEmployeeWage.DailyWage();
            //Console.ReadKey();
            //PartTime parttime = new PartTime();
            //PartTime.PartTimeWage();
            //Console.ReadKey();
            //Case Case = new Case();
            //Case.CaseStatement();
            //Console.ReadKey();
            WageForMonth wageForMonth = new WageForMonth();
            WageForMonth.MonthlyWage();
            Console.ReadKey();
        }
    }
}
