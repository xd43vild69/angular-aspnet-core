using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL.Movements;
using DTO;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class MovementOnKardexTest
    {
        private IMovementCommandService Service { get; set; }
        private MovementFactory Factory { get; set; }
        public Movement Movement { get; set; }
        public Kardex Kardex { get; set; }

        public MovementOnKardexTest()
        {
            Factory = new MovementFactory();
            Movement = new Movement() { ID = 1, ValueSize = 50 };
            Kardex = new Kardex() { ID = 1, ValueSize = 100, Movements = new List<Movement>() { Movement } };
        }

        [TestMethod]
        public void ExecuteBillOnKardex()
        {
            Service = Factory.GetInstance(MovementTypeEnum.Bill);

            Kardex = Service.ExcecuteMovementOnKardex(Kardex);

            Assert.IsTrue(150 == Kardex.ValueSize);
        }

        [TestMethod]
        public void ExecuteOutputOnKardex()
        {
            
            Service = Factory.GetInstance(MovementTypeEnum.Output);

            Kardex = Service.ExcecuteMovementOnKardex(Kardex);

            Assert.IsTrue(50 == Kardex.ValueSize);
        }
    }
}
