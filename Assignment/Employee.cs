using System;
using System.Collections.Generic;
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
        public string HireDate { get; set; }
        public Gender Gender { get; set; }

        #endregion

        #region Constructors

        public Employee(int id,string name,SecurityLevel secLevel,decimal salary,string hireDate,Gender gender)
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
            return $"Id: {Id}\nName: {Name}\nSecurityLevel: {SecurityLevel}\nSalary: {Salary}\nHireDate: {HireDate}\nGender: {Gender}";
        }

        #endregion
    }
}
