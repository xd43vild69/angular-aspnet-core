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
            Kardex Kardex = new Kardex() { ID = 1, ValueSize = 100};
            Movement movement = new Movement() { ID = 1, ValueSize = 50 };
            
            service = Factory.InstanceMovement(MovementTypeEnum.Bill);
            service.ExcecuteMovementOnKardex(movement, ref Kardex);

            Assert.IsTrue(150 == Kardex.ValueSize);
        }

        [TestMethod]
        public void ExecuteOutputOnKardex()
        {
            Kardex Kardex = new Kardex() { ID = 1, ValueSize = 100 };
            Movement movement = new Movement() { ID = 1, ValueSize = 50 };
            service = Factory.InstanceMovement(MovementTypeEnum.Output);

            service.ExcecuteMovementOnKardex(movement, ref Kardex);

            Assert.IsTrue(50 == Kardex.ValueSize);
        }
    }
}
