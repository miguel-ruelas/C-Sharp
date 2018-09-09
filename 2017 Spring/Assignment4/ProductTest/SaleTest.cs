using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Inventory;
using System.Windows.Forms;

[TestClass]
public class SaleTest
{
    [TestMethod]
    public void NewSale()
    {
        decimal total = 0;
        int numbOfProd = 0;
        
        Sale newSale = new Sale();
        Assert.AreEqual(total, newSale.Total);
        Assert.AreEqual(numbOfProd, newSale.NumbOfProd);

    }

    [TestMethod]
    public void testTotal()
    {
        string id = "1000";
        string name = "Level 1 Server";
        string desc = "2 Processors, 256GB DDR4, 15 3.25 Drive Bays";
        decimal price = 10000;
        int qty = 10;
        Product product = new Product(id, name, desc, price, qty);


        Sale newSale1 = new Sale();
        Assert.IsTrue(newSale1.Add(product));
        Assert.AreEqual(product.Price, newSale1.Total);
        Assert.AreEqual(1, newSale1.NumbOfProd);
        Assert.AreEqual(9, product.Qty);


    }


   
    [TestMethod]
    public void addProductWQty()
    {
        string id = "1000";
        string name = "Level 1 Server";
        string desc = "2 Processors, 256GB DDR4, 15 3.25 Drive Bays";
        decimal price = 10000;
        int qty = 10;
        Product product = new Product(id, name, desc, price, qty);

        int numOfProdToAdd = 3;


        Sale newSale = new Sale();
        Assert.IsTrue(newSale.Add(product, numOfProdToAdd));
        Assert.AreEqual(product.Price*3, newSale.Total);
        Assert.AreEqual(3, newSale.NumbOfProd);
        Assert.AreEqual(7, product.Qty);

    }

    [TestMethod]
    public void addInvalProdWQty()
    {
        string id = "1000";
        string name = "Level 1 Server";
        string desc = "2 Processors, 256GB DDR4, 15 3.25 Drive Bays";
        decimal price = 10000;
        int qty = 2;
        Product product = new Product(id, name, desc, price, qty);

        int numOfProdToAdd = 3;


        Sale newSale = new Sale();
        Assert.IsFalse(newSale.Add(product, numOfProdToAdd));
        Assert.AreEqual(0, newSale.Total);
        Assert.AreEqual(0, newSale.NumbOfProd);
        Assert.AreEqual(2, product.Qty);

    }


    [TestMethod]
    public void addInvalidProd()
    {
        string id = "1000";
        string name = "Level 1 Server";
        string desc = "2 Processors, 256GB DDR4, 15 3.25 Drive Bays";
        decimal price = 10000;
        int qty = 0;
        Product product = new Product(id, name, desc, price, qty);


        Sale newSale = new Sale();
        Assert.IsFalse(newSale.Add(product));
        Assert.AreEqual(0, newSale.Total);
        Assert.AreEqual(0, newSale.NumbOfProd);


    }
    [TestMethod]
    public void removeProduct()
    {
        string id = "1000";
        string name = "Level 1 Server";
        string desc = "2 Processors, 256GB DDR4, 15 3.25 Drive Bays";
        decimal price = 10000;
        int qty = 10;
        Product product = new Product(id, name, desc, price, qty);

         id = "1001";
         name = "Level 1 Server";
         desc = "2 Processors, 256GB DDR4, 15 3.25 Drive Bays";
         price = 15250;
         qty = 10;
        Product product2 = new Product(id, name, desc, price, qty);


        Sale newSale = new Sale();
        newSale.Add(product);
        newSale.Add(product2);
        Assert.AreEqual(product.Price+product2.Price, newSale.Total);
        Assert.AreEqual(2, newSale.NumbOfProd);
        Assert.IsTrue(newSale.Delete(product));
        Assert.AreEqual(product2.Price, newSale.Total);
        Assert.AreEqual(1, newSale.NumbOfProd);
        Assert.AreEqual(10, product.Qty);
        
    }

    [TestMethod]
    public void removeInvalidProd()
    {
        string id = "1000";
        string name = "Level 1 Server";
        string desc = "2 Processors, 256GB DDR4, 15 3.25 Drive Bays";
        decimal price = 10000;
        int qty = 10;
        Product product = new Product(id, name, desc, price, qty);

        id = "1001";
        name = "Level 12Server";
        desc = "2 Processors, 256GB DDR4, 15 3.25 Drive Bays";
        price = 15250;
        qty = 10;
        Product product2 = new Product(id, name, desc, price, qty);

        id = "1002";
        name = "Level 3 Server";
        desc = "2 Processors, 256GB DDR4, 15 3.25 Drive Bays";
        price = 15250;
        qty = 10;
        Product product3 = new Product(id, name, desc, price, qty);


        Sale newSale = new Sale();
        newSale.Add(product);
        newSale.Add(product2);
        Assert.IsFalse(newSale.Delete(product3));
        Assert.AreEqual(product.Price + product2.Price, newSale.Total);
        Assert.AreEqual(2, newSale.NumbOfProd);

    }


    [TestMethod]
    public void SearchEmptyList()
    {
        string id = "1000";
        string name = "Level 1 Server";
        string desc = "2 Processors, 256GB DDR4, 15 3.25 Drive Bays";
        decimal price = 10000;
        int qty = 10;
        Product product = new Product(id, name, desc, price, qty);

        Sale newSale = new Sale();
        //newSale.Add(product);
        int count = newSale.Search(product);
        Assert.AreEqual(0, count);

    }

    [TestMethod]
    public void SearchPopulatedList()
    {
        string id = "1000";
        string name = "Level 1 Server";
        string desc = "2 Processors, 256GB DDR4, 15 3.25 Drive Bays";
        decimal price = 10000;
        int qty = 10;
        int AmountAdd1 = 5;
        Product product = new Product(id, name, desc, price, qty);

        id = "1001";
        name = "Level 12Server";
        desc = "2 Processors, 256GB DDR4, 15 3.25 Drive Bays";
        price = 15250;
        qty = 10;
        int AmountAdd2 = 5;
        Product product2 = new Product(id, name, desc, price, qty);

        id = "1002";
        name = "Level 3 Server";
        desc = "2 Processors, 256GB DDR4, 15 3.25 Drive Bays";
        price = 15250;
        qty = 10;
        int AmountAdd3 = 5;
        Product product3 = new Product(id, name, desc, price, qty);

        Sale newSale = new Sale();
        newSale.Add(product, AmountAdd1);
        newSale.Add(product2, AmountAdd2);
        newSale.Add(product3, AmountAdd3);
        int count = newSale.Search(product2);
        Assert.AreEqual(AmountAdd2, count);

    }

    [TestMethod]
    public void removeInvalProdWQty()
    {
        string id = "1000";
        string name = "Level 1 Server";
        string desc = "2 Processors, 256GB DDR4, 15 3.25 Drive Bays";
        decimal price = 10000;
        int qty = 10;
        int AmountAdd1 = 5;
        Product product = new Product(id, name, desc, price, qty);

        id = "1001";
        name = "Level 12Server";
        desc = "2 Processors, 256GB DDR4, 15 3.25 Drive Bays";
        price = 15250;
        qty = 10;
        int AmountAdd2 = 5;
        Product product2 = new Product(id, name, desc, price, qty);

        id = "1002";
        name = "Level 3 Server";
        desc = "2 Processors, 256GB DDR4, 15 3.25 Drive Bays";
        price = 15250;
        qty = 10;
        int AmountAdd3 = 5;
        Product product3 = new Product(id, name, desc, price, qty);


        Sale newSale = new Sale();
        newSale.Add(product, AmountAdd1);
        newSale.Add(product2, AmountAdd2);
        Assert.IsFalse(newSale.Delete(product3, AmountAdd3));
        Assert.AreEqual(product.Price*AmountAdd1 + product2.Price*AmountAdd2, newSale.Total);
        Assert.AreEqual(AmountAdd1+AmountAdd2, newSale.NumbOfProd);

    }

    [TestMethod]
    public void removeProdWQty()
    {
        string id = "1000";
        string name = "Level 1 Server";
        string desc = "2 Processors, 256GB DDR4, 15 3.25 Drive Bays";
        decimal price = 10000;
        int qty = 10;
        int AmountAdd1 = 5;
        Product product = new Product(id, name, desc, price, qty);

        id = "1001";
        name = "Level 12Server";
        desc = "2 Processors, 256GB DDR4, 15 3.25 Drive Bays";
        price = 15250;
        qty = 10;
        int AmountAdd2 = 5;
        Product product2 = new Product(id, name, desc, price, qty);

        id = "1002";
        name = "Level 3 Server";
        desc = "2 Processors, 256GB DDR4, 15 3.25 Drive Bays";
        price = 15250;
        qty = 10;
        int AmountAdd3 = 5;
        Product product3 = new Product(id, name, desc, price, qty);


        Sale newSale = new Sale();
        newSale.Add(product, AmountAdd1);
        Assert.AreEqual(AmountAdd1, product.Qty);
        newSale.Add(product2, AmountAdd2);
        Assert.AreEqual(AmountAdd2, product2.Qty);
        newSale.Add(product3, AmountAdd3);
        Assert.AreEqual(AmountAdd3, product3.Qty);
        Assert.IsTrue(newSale.Delete(product3, 1));
        Assert.AreEqual(6, product3.Qty);
        Assert.AreEqual((AmountAdd3 - 1), newSale.Search(product3));
        Assert.AreEqual(product.Price * AmountAdd1 + product2.Price * AmountAdd2 + product3.Price * (AmountAdd3 - 1), newSale.Total);
        Assert.IsTrue(newSale.Delete(product3, 4));
        Assert.AreEqual(10, product3.Qty);
        Assert.AreEqual(product.Price * AmountAdd1 + product2.Price * AmountAdd2, newSale.Total);
        Assert.AreEqual(AmountAdd1 + AmountAdd2, newSale.NumbOfProd);

    }

    [TestMethod]
    public void removeALLProdWQty()
    {
        string id = "1000";
        string name = "Level 1 Server";
        string desc = "2 Processors, 256GB DDR4, 15 3.25 Drive Bays";
        decimal price = 10000;
        int qty = 10;
        int AmountAdd1 = 5;
        Product product = new Product(id, name, desc, price, qty);

        id = "1001";
        name = "Level 12Server";
        desc = "2 Processors, 256GB DDR4, 15 3.25 Drive Bays";
        price = 15250;
        qty = 10;
        int AmountAdd2 = 5;
        Product product2 = new Product(id, name, desc, price, qty);

        id = "1002";
        name = "Level 3 Server";
        desc = "2 Processors, 256GB DDR4, 15 3.25 Drive Bays";
        price = 15250;
        qty = 10;
        int AmountAdd3 = 10;
        Product product3 = new Product(id, name, desc, price, qty);


        Sale newSale = new Sale();
        newSale.Add(product, AmountAdd1);
        Assert.AreEqual(AmountAdd1, product.Qty);
        newSale.Add(product2, AmountAdd2);
        Assert.AreEqual(AmountAdd2, product2.Qty);
        newSale.Add(product3, AmountAdd3);
        Assert.AreEqual(0, product3.Qty);
        Assert.IsTrue(newSale.Delete(product3, 1));
        Assert.AreEqual(1, product3.Qty);
        Assert.AreEqual((AmountAdd3 - 1), newSale.Search(product3));
        Assert.AreEqual(product.Price * AmountAdd1 + product2.Price * AmountAdd2 + product3.Price * (AmountAdd3 - 1), newSale.Total);
        Assert.IsTrue(newSale.Delete(product3, 9));
        Assert.AreEqual(AmountAdd3, product3.Qty);
        Assert.AreEqual(product.Price * AmountAdd1 + product2.Price * AmountAdd2, newSale.Total);
        Assert.AreEqual(AmountAdd1 + AmountAdd2, newSale.NumbOfProd);

    }

    [TestMethod]
    public void addProduct()
    {

        string id = "1000";
        string name = "Level 1 Server";
        string desc = "2 Processors, 256GB DDR4, 15 3.25 Drive Bays";
        decimal price = 10000;
        int qty = 10;
        Product product = new Product(id, name, desc, price, qty);


        Sale newSale = new Sale();
        Assert.IsTrue(newSale.Add(product));
        Assert.AreEqual(product.Price, newSale.Total);
        Assert.AreEqual(1, newSale.NumbOfProd);
        Assert.AreEqual(9, product.Qty);


    }

}


