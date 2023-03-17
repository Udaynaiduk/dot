using NUnit.Framework;
using exercise_inheritance_furniture;
using System;
using System.Drawing;



namespace commander
{
    public class FurnitureTest
    {
        Program p;
        [SetUp]
        public void Setup()
        {
            p = new Program();
        }

        [Test]       
        public void TestTotalStockValueSuccess()
        {
            Furniture[] f = new Furniture[2];
            f[0] = new BookShelf() { Color = "", Height = 0, NoOfShelves = 0, Width = 0, Price = 100, Qty = 2 };
            f[1] = new BookShelf() { Color = "", Height = 0, NoOfShelves = 0, Width = 0, Price = 100, Qty = 2 };
            Assert.AreEqual(400, p.TotalStockValue(f));
        }
        [Test]
        public void TestTotalStockValueFail()
        {
            Furniture[] f = new Furniture[2];
            //f[0] = new BookShelf() { Color = "", Height = 0, NoOfShelves = 0, Width = 0, Price = 100, Qty = 2 };
            //f[1] = new BookShelf() { Color = "", Height = 0, NoOfShelves = 0, Width = 0, Price = 100, Qty = 2 };
            Assert.That(() => p.TotalStockValue(f), Throws.InstanceOf<NullReferenceException>());
            
        }
    }
}