using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AhmedNasrAssignment
{
    internal class Employee
    {

        #region Methods
        
        public virtual void Work()
        {
            Console.WriteLine("Employee is working");
        } 

        #endregion

    }

    class Manager : Employee
    {

        #region Methods
        
        public override void Work()
        {
            base.Work();
            Console.WriteLine("Manager is managing");
        } 

        #endregion

    }
}
