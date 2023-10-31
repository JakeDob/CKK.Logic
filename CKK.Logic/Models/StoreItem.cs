using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    internal class StoreItem
    {
        private Product _product;
        private int Quantity;

        public StoreItem(Product _Product, int quantity)
        {
            _product = _Product;
            Quantity = quantity;
        }

        public int GetQuantity()
        {
            return Quantity;
        }

        public void SetQuantity(int quantity)
        {
            Quantity = quantity;
        }

        public Product GetProduct()
        {
            return _product;
        }

        public void SetProduct(Product product)
        {
            _product = product;
        }
    }
}
