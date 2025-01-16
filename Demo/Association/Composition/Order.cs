using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Association.Composition
{
    internal class Order
    {

        #region Properties
        
        public int Id { get; set; }
        public required string UserEmail { get; set; }
        public decimal SubTotal { get; set; }
        public required List<OrderItem> Items { get; set; }//Association Relationship [Composition] => Order must has a OrderItems when make object from Order class [Initialize The Items With value by object initializer]. 

        #endregion

    }
}
