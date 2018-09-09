using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace Inventory
{
    /// <summary>
    /// Sale is a class that holds products to be sold. It has methods to tally the total of all the products
    /// in its list. Products are added individually with each product in the list representing a single quantity
    /// of that product. 
    /// </summary>
    public class Sale
    {
        //Create a list to hold products to be sold. Each product in the list represents (1) quantity of that 
        //Product to be sold
        public static BindingList<Product> SaleProd = new BindingList<Product>();

        //Create variables to hold the total price and the number of products in the list;

        public decimal Total { get; private set; }
        public int NumbOfProd { get; private set; }

        /// <summary>
        /// Sale is a no argument constructor that sets the total and number of product variables to 0
        /// </summary>
        public Sale()
        {
            Total = 0;
            NumbOfProd = 0;
        }

        /// <summary>
        /// Add() receives and adds a product to the list an removes the 1  from the product's quantity. 
        /// It returns a boolean showing true if the product was added and false if it failed. Product 
        /// will fail to add if thereare not enough on hand for the amount that the user requested to add.
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public bool Add(Product product)
        {
            int numOfProdToAdd = 1;        //holds the amount of products to be added

            Product addProd = product;         // holds a reference to the product to be added.
            if (addProd.Qty < numOfProdToAdd)  //Check to see if the product has enough in sotck.
            {

                return false;                   //Not enough in stock to add.
            }
            //remove the amount added to the sale from the products quantity in stock.
            product.RemoveQty(numOfProdToAdd);    
            //add the product into the sale for each qty of the product.
            for (int i = 0; i < numOfProdToAdd; i++)
            {
                SaleProd.Add(addProd);
            }
            //set the total number of products from the amount of products in the list
            NumbOfProd = SaleProd.Count;

            //call the getTotal() method to update the total price of all items.
            getTotal();

            //Return true since the item was successfully added to the sale.
            return true;
        }

        /// <summary>
        /// getTotal() method adds the price of each item in the list and sets the total variable to the result.
        /// </summary>
        private void getTotal()
        {
            decimal newTotal = 0;
            foreach (Product temp in SaleProd)
            {
                newTotal += temp.Price;
            }
            Total = newTotal;

        }

        /// <summary>
        /// Delete() method receives and removes a product from the sale list and adds the amount
        /// deleted back into the products quantity variable. 
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public bool Delete(Product product)
        {
            if (SaleProd.Contains<Product>(product)) //Check that the product is in the list
            {
                try   //try catch problably not needed here.
                {
                    product.Add(1);           // add 1 back to the quantity in stock
                    SaleProd.Remove(product); // remove 1 of the product from the list
                    getTotal();                // Get the new total
                    NumbOfProd = SaleProd.Count;  // Set the new number of products in the sale.
                    return true;                  // Delete succeeded return true.
                }
                catch
                {
                    return false;          //Something failed return false.
                }
            }
            else
                return false;       //Product was not in the list return false.
        }

        /// <summary>
        /// Add() is an overloeaded method that receives a product and an integer representing the amount 
        /// of the product to be added to the sale list. 
        /// </summary>
        /// <param name="product"></param>
        /// <param name="numOfProdToAdd"></param>
        /// <returns></returns>
        public bool Add(Product product, int numOfProdToAdd)
        {
            
            Product addProd = product;
            if (addProd.Qty < numOfProdToAdd)    //chec to see if the amount in stock is less than what the user wants to add.
            {
               
                return false;   //Not enough in stock return false;
            }
           
            product.RemoveQty(numOfProdToAdd);   //Remove the amount from the product in stock quantity variable.
            for (int i =0; i< numOfProdToAdd; i++) //Add a product for each int in numOfProdToAdd.
            { 
                SaleProd.Add(addProd);         
            }
            
            NumbOfProd = SaleProd.Count;    //Update the Number of products in the sale
            getTotal();                     // Update the total price of all the products in the sale.
            return true;             
        }

        /// <summary>
        /// Search() method returns the quantity of each product ID in the sale.
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public int Search(Product product)
        {
            Product test = product;
            int count = 0;
            foreach (Product temp in SaleProd)
            {
                if (temp.ID == test.ID)
                    count++;
            }
            return count;
        }


        /// <summary>
        /// Delete() is an overloaded method that receives a product and the amount to be deleted. It returns
        /// true if the amount was deleted from the sale, and false if the amount was not deleted. CURRENTLY NOT
        /// IMPLEMETED IN POS.
        /// </summary>
        /// <param name="product"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        public bool Delete(Product product, int amount)
        {
            if (Search(product) >= amount)     //Check to see if the amount of products to be deleted is less than
            {                                  //or equal to the amount in the sale.
                try
                {
                    for (int i = 0; i < amount; i++)   //Delete the products form the list 
                    {
                        //Add the 1 for each product deleted back into the products in stock quantity
                        product.Add(1);               
                        SaleProd.Remove(product);
                    }
                    
                    getTotal();                      //Update the total price of the products
                    NumbOfProd = SaleProd.Count;     //Update the new number of products in the sale
                    return true;                   //Delete succeeded
                }
                catch
                {
                    return false;        //Something whent wrong and delete failed
                }
            }
            else
                return false;             //Amount requested to delete was more than what is in the sale
        }

        /// <summary>
        /// Price receives an integer that represents the index of a product in the sale list. It then returns 
        /// the price of that product. It is used to generate the text for the Sale list box.
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public decimal Price(int i)
        {
            return SaleProd.ElementAt(i).Price;
        }

        /// <summary>
        /// ID() receives an integer that represents the index of a product in the sale list. It then returns 
        /// the ID of that product. It is used to generate the text for the Sale list box.
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public string ID(int i)
        {
            return SaleProd.ElementAt(i).ID;
        }
        /// <summary>
        /// Delete() is used by the remove button in the Point of sale form. It receives an integer that corresponds
        /// to the index of a product in the sale list. It then removes that product and adds 1 to the quantity available
        /// in stock.
        /// </summary>
        /// <param name="removeIndex"></param>
        public void Delete(int removeIndex)
        {
            if (removeIndex < 0)  // The user did not select a product from the Sale List box;
                return;           // Do nothing and exit
            else
            {
                Product removedProd = SaleProd.ElementAt(removeIndex);  //Get a reference to the product
                removedProd.Add(1);                                     //Add 1 to the quantity
                SaleProd.RemoveAt(removeIndex);                         //Remove the product from the list
                getTotal();                                             //Get the new total
                NumbOfProd = SaleProd.Count;                            //Get the new number of products in sale
                return;                                                
            }
           
        }
    }
}