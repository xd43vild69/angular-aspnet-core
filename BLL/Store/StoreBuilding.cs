using BLL.Movements;
using DTO;

namespace BLL.Store
{
    public class StoreBuilding
    {
        private MovementFactory Factory { get; set; }
        private IMovementCommandService service { get; set; }
        private Kardex Kardex { get; set; }
        private Movement Movement { get; set; }

        public StoreBuilding(Movement movement, Kardex kardex)
        {
            Movement = movement;
            Kardex = kardex;
        }

        public void ExecuteMovementOnKardex()
        {
            service = Factory.InstanceMovement(Movement.MovementType);
            service.ExcecuteMovementOnKardex(Movement,  Kardex);
        }

    }
}
