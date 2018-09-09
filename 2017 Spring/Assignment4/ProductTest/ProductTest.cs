using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Inventory;




[TestClass]
public class ProductTest
{
    [TestMethod]
    public void NewProductTestValidData()
    {
        string id = "1000";
        string name = "Level 1 Server";
        string desc = "2 Processors, 256GB DDR4, 15 3.25 Drive Bays";
        decimal price = 10000;
        int qty = 10;
        Product product = new Product(id, name, desc, price, qty);
        Assert.AreEqual(id, product.ID);
        Assert.AreEqual(name, product.Name);
        Assert.AreEqual(desc, product.Desc);
        Assert.AreEqual(price, product.Price);
        Assert.AreEqual(qty, product.Qty);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void TestQTYChangeToNegative()
    {
        string id = "1000";
        string name = "Level 1 Server";
        string desc = "2 Processors, 256GB DDR4, 15 3.25 Drive Bays";
        decimal price = 10000;
        int qty = 10;
        Product product = new Product(id, name, desc, price, qty);
        product.RemoveQty(12);
    }

    [TestMethod]
    public void TestQTYRemove()
    {
        string id = "1000";
        string name = "Level 1 Server";
        string desc = "2 Processors, 256GB DDR4, 15 3.25 Drive Bays";
        decimal price = 10000;
        int qty = 10;
        Product product = new Product(id, name, desc, price, qty);
        product.RemoveQty(2);
        Assert.AreEqual(8, product.Qty);
    }

    [TestMethod]
    public void TestQTYAdd()
    {
        string id = "1000";
        string name = "Level 1 Server";
        string desc = "2 Processors, 256GB DDR4, 15 3.25 Drive Bays";
        decimal price = 10000;
        int qty = 10;
        Product product = new Product(id, name, desc, price, qty);
        product.Add(2);
        Assert.AreEqual(12, product.Qty);
    }
}


