using BLL.Store;
using BLL.Store.Strategy;
using DTO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class StoreTest
    {

        public Kardex Kardex { get; set; }
        public IStore Store { get; set; }
        public StoreTest()
        {
            Movement movement = new Movement() { ID = 1, ValueSize = 50, MovementType = MovementTypeEnum.Bill };
            Kardex = new Kardex() { ID = 1, ValueSize = 100, Movements = new List<Movement>() { movement } };
        }

        [TestMethod]
        public void StoreSelectiveStrategyPattern()
        {
            Store = new StoreSelective(Kardex);
            StoreContext storeContext = new StoreContext(Store);

            Kardex = storeContext.ExecuteMovement();

            Assert.IsTrue(150 == Kardex.ValueSize);
        }

    }
}
