using BLL.Movements;
using DTO;
using System.Linq;

namespace BLL.Store
{
    public class StoreSelective : IStore
    {
        private MovementFactory Factory { get; set; }
        private IMovementCommandService Service { get; set; }
        private Kardex Kardex { get; set; }

        public StoreSelective(Kardex kardex)
        {
            Kardex = kardex;
            Factory = new MovementFactory();
            Service = Factory.GetInstance(kardex.Movements.FirstOrDefault().MovementType);
        }

        public Kardex ExecuteMovementOnKardex()
        {
            return Service.ExcecuteMovementOnKardex(Kardex);
        }

        public Kardex UndoMovementOnKardex()
        {
            return Service.UndoMovementOnKardex(Kardex);
        }

        public Kardex UpdateMovementOnKardex()
        {
            return Service.UpdateMovementOnKardex(Kardex);
        }
    }
}
