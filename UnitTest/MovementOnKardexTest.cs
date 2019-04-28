using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL.Movements;
using DTO;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class MovementOnKardexTest
    {
        private IMovementCommandService service { get; set; }
        private MovementFactory Factory { get; set; }

        public MovementOnKardexTest()
        {
            Factory = new MovementFactory();
        }

        [TestMethod]
        public void ExecuteBillOnKardex()
        {
            Movement movement = new Movement() { ID = 1, ValueSize = 50 };
            Kardex kardex = new Kardex() { ID = 1, ValueSize = 100, Movements = new List<Movement>() { movement} };
            
            
            service = Factory.GetInstance(MovementTypeEnum.Bill);
            kardex = service.ExcecuteMovementOnKardex(kardex);

            Assert.IsTrue(150 == kardex.ValueSize);
        }

        [TestMethod]
        public void ExecuteOutputOnKardex()
        {
            Movement movement = new Movement() { ID = 1, ValueSize = 50 };
            Kardex kardex = new Kardex() { ID = 1, ValueSize = 100, Movements = new List<Movement>() { movement } };
            
            service = Factory.GetInstance(MovementTypeEnum.Output);

            kardex = service.ExcecuteMovementOnKardex(kardex);

            Assert.IsTrue(50 == kardex.ValueSize);
        }
    }
}
