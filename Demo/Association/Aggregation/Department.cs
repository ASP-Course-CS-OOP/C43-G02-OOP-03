using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Association.Aggregation
{
    internal class Department
    {
        #region Properties
        
        public int Code { get; set; }
        public required string Name { get; set; }
        public List<Employee>? Employees { get; set; }
        //Association Relationship [Aggregation] => Department May has a List of Employees or not List<Employee>?
        //Mean that when make object from "Department", the [new] with help of [CLR] will initialize the reference Employees with default value NULL
        //Mean Department not has employees. 

        #endregion
    }
}
