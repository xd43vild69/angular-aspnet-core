using BLL.Movements;
using DTO;

namespace BLL.Store
{
    public class StoreSelective : IStore
    {
        private MovementFactory Factory { get; set; }
        private IMovementCommandService Service { get; set; }
        private Kardex Kardex { get; set; }
        private Movement Movement { get; set; }

        public StoreSelective(Movement movement, Kardex kardex)
        {
            Movement = movement;
            Kardex = kardex;
            Service = Factory.GetInstance(Movement.MovementType);
        }

        public Kardex ExecuteMovementOnKardex()
        {
            return Service.ExcecuteMovementOnKardex(Movement, Kardex);
        }

        public Kardex UndoMovementOnKardex()
        {
            return Service.UndoMovementOnKardex(Movement, Kardex);
        }

        public Kardex UpdateMovementOnKardex()
        {
            return Service.UpdateMovementOnKardex(Movement, Kardex);
        }
    }
}
