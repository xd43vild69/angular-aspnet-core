using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL.Movements;
using DTO;

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
            Kardex kardex = new Kardex() { ID = 1, ValueSize = 100};
            Movement movement = new Movement() { ID = 1, ValueSize = 50 };
            
            service = Factory.GetInstance(MovementTypeEnum.Bill);
            kardex = service.ExcecuteMovementOnKardex(movement, kardex);

            Assert.IsTrue(150 == kardex.ValueSize);
        }

        [TestMethod]
        public void ExecuteOutputOnKardex()
        {
            Kardex kardex = new Kardex() { ID = 1, ValueSize = 100 };
            Movement movement = new Movement() { ID = 1, ValueSize = 50 };
            service = Factory.GetInstance(MovementTypeEnum.Output);

            kardex = service.ExcecuteMovementOnKardex(movement,  kardex);

            Assert.IsTrue(50 == kardex.ValueSize);
        }
    }
}
