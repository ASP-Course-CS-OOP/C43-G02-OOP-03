using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Association.Composition
{
    internal class Product
    {

        #region Properties
        
        public int Id { get; set; }
        public required string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsOfStock { get; set; }

        #endregion

        #region Methods
        
        public override string ToString()
        {
            return $"Id = {Id}, Name = {Name}, UnitPrice = {UnitPrice}, UnitsOfStock = {UnitsOfStock}";
        } 

        #endregion

    }
}
