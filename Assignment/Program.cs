using System.Globalization;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Part01

            //Check Demo Branch

            #endregion

            #region Part02

            #region Q1. Design and implement a Class for the employees in a company:

            //bool IdParsed;
            //int id;
            //do
            //{
            //    Console.Write("Enter The Id: ");
            //    IdParsed = int.TryParse(Console.ReadLine(), out id);
            //} while (!IdParsed);

            //Console.Write("Enter The Name: ");
            //string name = Console.ReadLine()!;

            //Console.Write("Enter Security Level: ");
            //SecurityLevel secLev = (SecurityLevel)int.Parse(Console.ReadLine()!);

            //bool SalaryParsed;
            //decimal salary;
            //do
            //{
            //    Console.Write("Enter Salary: ");
            //    SalaryParsed = decimal.TryParse(Console.ReadLine(), out salary);
            //} while (!SalaryParsed);

            //Console.WriteLine("Enter Hiring Date => ");
            //int day, month, year;
            //bool dayParsed, monthParsed, yearParsed;

            //    do
            //    {
            //        Console.Write("Day: ");
            //        dayParsed = int.TryParse(Console.ReadLine(), out day);
            //    } while (!dayParsed);
            //    do
            //    {
            //        Console.Write("Month: ");
            //        monthParsed = int.TryParse(Console.ReadLine(), out month);
            //    } while (!dayParsed);
            //    do
            //    {
            //        Console.Write("Year: ");
            //        yearParsed = int.TryParse(Console.ReadLine(), out year);
            //    } while (!dayParsed);
            //HiringDate hiringDate = new HiringDate(day, month, year);

            //bool GenderParsed;
            //Gender gender;
            //do
            //{
            //    Console.Write("Enter Gender: ");
            //    GenderParsed = Enum.TryParse<Gender>(Console.ReadLine(), true, out gender);
            //} while (!GenderParsed);

            //Employee employee = new Employee(id, name, secLev, salary, hiringDate, gender);

            //Console.WriteLine($"\n{employee}");

            #endregion

            #region Q2.Develop a Class to represent the Hiring Date Data:

            //HiringDate hDate = new HiringDate("1", "1", "2025");

            //Console.WriteLine(hDate);

            #endregion

            #region Q3.Create an array of Employees with size three a DBA, Guest and the third one is security officer who have full permissions. (Employee [] EmpArr;)

            //Employee[] empArr = new Employee[3];
            //HiringDate[] hiringDate = new HiringDate[3];
            //if (empArr?.Length >= 0)
            //{
            //    for (int i = 0; i < empArr.Length; i++)
            //    {
            //        Console.WriteLine($"\nEnter Data Of Employee {i + 1}=>\n");

            //        int id;
            //        bool idParsed;
            //        do
            //        {
            //            Console.Write("Id: ");
            //            idParsed = int.TryParse(Console.ReadLine(), out id);
            //        } while (!idParsed);

            //        string name;
            //        do
            //        {
            //            Console.Write("Name: ");
            //            name = Console.ReadLine()!; 
            //        } while (string.IsNullOrWhiteSpace(name));

            //        Console.Write("Security Level: ");
            //        SecurityLevel secLev = (SecurityLevel)int.Parse(Console.ReadLine()!);

            //        bool SalaryParsed;
            //        decimal salary;
            //        do
            //        {
            //            Console.Write("Salary: ");
            //            SalaryParsed = decimal.TryParse(Console.ReadLine(), out salary);
            //        } while (!SalaryParsed || salary<5000 || salary>100_000);

            //        int day, month, year;
            //        bool dayParsed, monthParsed, yearParsed;

            //        Console.WriteLine($"Hiring Date of Employee {i + 1}: ");
            //        do
            //        {
            //            Console.Write("Day: ");
            //            dayParsed = int.TryParse(Console.ReadLine(), out day);
            //        } while (!dayParsed || day>31 || day<1);
            //        do
            //        {
            //            Console.Write("Month: ");
            //            monthParsed = int.TryParse(Console.ReadLine(), out month);
            //        } while (!monthParsed || month>12 || month<1);
            //        do
            //        {
            //            Console.Write("Year: ");
            //            yearParsed = int.TryParse(Console.ReadLine(), out year);
            //        } while (!yearParsed || year>2025);
            //        hiringDate[i] = new HiringDate(day, month, year);

            //        bool GenderParsed;
            //        Gender gender;
            //        do
            //        {
            //            Console.Write("Gender: ");
            //            GenderParsed = Enum.TryParse<Gender>(Console.ReadLine(), true, out gender);
            //        } while (!GenderParsed);

            //        empArr[i] = new Employee(id, name, secLev, salary, hiringDate[i], gender);
            //    }
            //}

            //Console.WriteLine("\nEmployees Before sorting By Hiring Date:");
            //foreach (Employee employee in empArr!)
            //{
            //    Console.WriteLine(employee);
            //}

            #endregion

            #region Q4.Sort the employees based on their hire date then Print the sorted array

            //int boxingUnboxingCount = 0;

            //Array.Sort(empArr, (e1, e2) =>
            //{
            //    boxingUnboxingCount++;
            //    DateTime hireDate1 = new DateTime(e1.HireDate.Year, e1.HireDate.Month, e1.HireDate.Day);
            //    DateTime hireDate2 = new DateTime(e2.HireDate.Year, e2.HireDate.Month, e2.HireDate.Day);
            //    return hireDate1.CompareTo(hireDate2);
            //});

            //Console.WriteLine("\nEmployees After Sorting By Hire Date:");
            //foreach (Employee employee in empArr)
            //{
            //    Console.WriteLine(employee);
            //}

            //Console.WriteLine($"\nNumber of boxing & unboxing: {boxingUnboxingCount}");

            #endregion

            #endregion

        }
    }
}
