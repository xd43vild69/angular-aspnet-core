using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL.Movements;
using DTO;

namespace UnitTest
{
    [TestClass]
    public class MovementBillTest
    {
        [TestMethod]
        public void ExecuteBillOnKardex()
        {
            IMovementCommandService service;
            MovementTypeEnum movementType = MovementTypeEnum.Bill;
            Kardex Kardex = new Kardex() { ID = 1, ValueSize = 100};
            Movement movement = new Movement() { ID = 1, ValueSize = 50 };

            MovementFactory factory = new MovementFactory();
            service = factory.InstanceMovement(movementType);
            service.ExcecuteMovementOnKardex(movement, ref Kardex);

            Assert.IsTrue(150 == Kardex.ValueSize);
        }
    }
}
