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
                { MovementTypeEnum.Bill, new Bill()},
                { MovementTypeEnum.Referrals, new Bill()},
                { MovementTypeEnum.Output, new Output()},
                { MovementTypeEnum.CreditNote, new Bill()},
                { MovementTypeEnum.DebitNote, new Bill()}
            };
        }

        public IMovementCommandService GetInstance(MovementTypeEnum type)
        {
            return Factories[type];
        }
    }
}
