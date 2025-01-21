using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AhmedNasrAssignment
{
    internal class BaseClass
    {

        #region Methods
        
        public virtual void DisplayMessage()
        {
            Console.WriteLine("Message from BaseClass");
        } 

        #endregion

    }

    internal class DerivedClass1:BaseClass
    {

        #region Methods
        
        public override void DisplayMessage()// Dynamic Binded Method
        {
            Console.WriteLine("Message from DerivedClass1");
        } 

        #endregion

    }
    
    internal class DerivedClass2 : BaseClass
    {

        #region Methods
        
        public new void DisplayMessage() // Static Binded Method.
        {
            Console.WriteLine("Message from DerivedClass2");
        } 

        #endregion

    }
}
