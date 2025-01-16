using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Association.Composition
{
    internal class OrderItem
    {

        #region Properties

        public int Id { get; set; }
        public Product Product { get; set; }// Association Relationship [Composition] => OrderItem has a Product
        public decimal Price { get; set; }//Different from product price => this price if There Is Discount on Product Price
        public int Quantity { get; set; }

        #endregion

        #region Constructors
        
        public OrderItem(Product product) //Required [OrderItem must has a Product] When Make object from OrderItem Class.
        {
            Product = product;
        } 

        #endregion

    }
}
