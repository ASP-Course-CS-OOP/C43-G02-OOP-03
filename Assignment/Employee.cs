using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Employee
    {
        #region Properties
        
        public int Id { get; set; }
        public string Name { get; set; }
        public SecurityLevel SecurityLevel { get; set; }
        public decimal Salary { get; set; }
        public HiringDate HireDate { get; set; }
        public Gender Gender { get; set; }

        #endregion

        #region Constructors

        public Employee(int id,string name,SecurityLevel secLevel,decimal salary,HiringDate hireDate,Gender gender)
        {
            Id = id;
            Name = name;
            SecurityLevel = secLevel;
            Salary = salary;
            HireDate = hireDate;
            Gender = gender;
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            return $"\nData of Employee {Name} =>\nId: {Id}\nName: {Name}\nSecurityLevel: {SecurityLevel}\nSalary: {String.Format(CultureInfo.CurrentCulture, "{0:C}", Salary)}\nHireDate: {HireDate}\nGender: {Gender}";
        }

        #endregion
    }
}
