using DTO;
using System.Collections.Generic;

namespace BLL.Movements
{
    public class MovementFactory
    {
        private readonly Dictionary<MovementTypeEnum, IMovementCommandService> Factories;

        public MovementFactory()
        {
            Factories = new Dictionary<MovementTypeEnum, IMovementCommandService>()
            {
                { MovementTypeEnum.Bill, new MovementBill()},
                { MovementTypeEnum.Referrals, new MovementBill()},
                { MovementTypeEnum.Output, new MovementOutput()},
                { MovementTypeEnum.CreditNote, new MovementBill()},
                { MovementTypeEnum.DebitNote, new MovementBill()}
            };
        }

        public IMovementCommandService InstanceMovement(MovementTypeEnum type)
        {
            return Factories[type];
        }
    }
}
