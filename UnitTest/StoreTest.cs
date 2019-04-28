using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL.Movements;
using DTO;
using System.Collections.Generic;
using BLL.Store.Strategy;
using BLL.Store;

namespace UnitTest
{
    [TestClass]
    public class StoreTest
    {
        [TestMethod]
        public void StoreSelectiveStrategyPattern()
        {
            Movement movement = new Movement() { ID = 1, ValueSize = 50, MovementType = MovementTypeEnum.Bill };
            Kardex kardex = new Kardex() { ID = 1, ValueSize = 100, Movements = new List<Movement>() { movement } };
            IStore store = new StoreSelective(kardex);

            StoreContext storeContext = new StoreContext(store);
            kardex = storeContext.ExecuteMovement();

            Assert.IsTrue(150 == kardex.ValueSize);
        }

    }
}
