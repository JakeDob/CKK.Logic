using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    internal class StoreItem
    {
        private Product siproduct;
        private int _quantity;

        public StoreItem(Product Siproduct, int quantity)
        {
            siproduct = Siproduct;
            _quantity = quantity;
        }

        public int GetQuantity()
        {
            return _quantity;
        }

        public void SetQuantity(int quantity)
        {
            _quantity = quantity;
        }

        public Product GetProduct()
        {
            return siproduct;
        }

        public void SetProduct(Product product)
        {
            siproduct = product;
        }
    }
}
