using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie2
{
    public partial class Form1 :Form
    {
        Shop pyaterochka = new Shop();
        Product tovar = new Product();

        public Form1 ()
        {
            InitializeComponent();
        }

        private void Form1_Load (object sender, EventArgs e)
        {

        }

        private void button1_Click (object sender, EventArgs e)
        {
            tovar.Name = textBox1.Text;
            tovar.Price = decimal.Parse(textBox2.Text);
            tovar.Count =int.Parse(textBox3.Text);
            if (tovar.Cena)
            {
                pyaterochka.CreateProduct(textBox1.Text, decimal.Parse(textBox2.Text), tovar.Count);
                foreach (var k in pyaterochka.AllProduct())
                {
                    listBox1.Items.Add(k.GetInfo());
                    MessageBox.Show("Товар добавлен");
                }
            }
        }

        private void button2_Click (object sender, EventArgs e)
        {
            pyaterochka.Sell(textBox2.Text, int.Parse(textBox3.Text));
            foreach (var k in pyaterochka.AllProduct())
                listBox1.Items.Add(k.GetInfo());
        }

        private void button3_Click (object sender, EventArgs e)
        {
            MessageBox.Show($"Магазин заработал {pyaterochka.Pribil}");
        }
    }
}
