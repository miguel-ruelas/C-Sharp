using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    /// <summary>
    /// Product class holds the ID, Name, Description, Price and Quantity of a product in inventory. It has
    /// methods to add, remove the quantity in stock.
    /// </summary>
    public class Product
    {
        //Create variables to hold product information
        public string ID { get; private set; }
        public string Name { get; private set; }
        public string Desc { get; private set; }
        public decimal Price { get; private set; }
        public int Qty { get; private set; }

        /// <summary>
        /// Product() constructor sets the Product information upond creation.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="desc"></param>
        /// <param name="price"></param>
        /// <param name="qty"></param>
        public Product(string id, string name, string desc, decimal price, int qty)
        {
            this.ID = id;
            this.Name = name;
            this.Desc = desc;
            this.Price = price;
            this.Qty = qty;
        }

        /// <summary>
        /// RemoveQty() receives an integer that corresponds with the amount of items that are to removed f
        /// from the Quantity. Programs that call this method must send valid requests as invalid input will
        /// throw and ArgumentException.
        /// </summary>
        /// <param name="amount"></param>
        public void RemoveQty(int amount)
        {
            if (amount < 1)
            {
                throw new ArgumentException("Invalid QTY received amount is less than 1");
            }
            else if (amount > Qty)
            {
                throw new ArgumentException("Insuffient amount in inventory to complete transaction.");
            }
                
            Qty -= amount;
        }

        /// <summary>
        /// Add() receives an integer that corresponds with the amount of items that are to be added to
        /// the Quantity. Programs that call this method must send valid requests as invalid input will
        /// throw and ArgumentException.
        /// </summary>
        /// <param name="amount"></param>
        public void Add(int amount)
        {
            if (amount < 1) throw new ArgumentException("Invalid QTY received amount is less than 1");
            Qty += amount;
        }
    }
}
