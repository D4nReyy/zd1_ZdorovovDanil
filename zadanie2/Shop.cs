using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie2
{
    class Shop
    {
        private Dictionary<Product,int> products;
        private decimal pribil = 0;

        public Shop ()
        {
            products = new Dictionary<Product, int>();
        }

        public decimal Pribil
        {
            get
            {
                return pribil;
            }
            set
            {
                pribil = value;
            }
        }
        public List<Product> AllProduct ()
        {
            return new List<Product>(products.Keys);
        }
        public void CreateProduct (string name, decimal price,int count)
        {
            products.Add(new Product(name, price,count),count);
        }
        public void Sell (string NameProduct, int count)
        {
            foreach (var product in products.Keys)
            {
                if (product.Name == NameProduct)
                {
                    if (products[product] > 0 && product.Count >= count)
                    {
                        product.Count = product.Count - count;
                        pribil += product.Price * count;
                    }
                    else
                    {
                        MessageBox.Show("Товара нет в наличии");   
                    }
                    return;
                }
            } MessageBox.Show("Товар не найден");
        }
    }
}
