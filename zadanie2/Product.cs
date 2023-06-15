using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie2
{
    class Product
    {
        private bool pr = true;
        private decimal price;
        private string name;
        private int count;

        public Product (string Name, decimal Price, int Count)
        {
            name = Name;
            price = Price;
            count = Count;
        }

        public Product ()
        {
        }

        public string GetInfo ()
        {
            return $"Наименование: {name}; Цена: {price}; Количество: {Count}";
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value != "")
                {
                    name = value;
                }
                else
                {
                    MessageBox.Show("Неверный ввод имени");
                }
            }
        }
        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {

                if (value != 0 && value > 0)
                {
                    price = value;
                }
                else
                {
                    MessageBox.Show("Неверный ввод цены");
                }
            }
        }
        public bool Cena
        {
            get
            {
                return pr;
            }
            set
            {
                pr = value;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
            set
            {
                if (value >= 0)
                {
                    count = value;
                }
                else
                {
                    MessageBox.Show("Неверный ввод количества");
                }
            }
        }
    }
}
