namespace BLL.Movements
{
    public class MovementFactory
    {
        public IMovementCommandService MovementService { get; set; }

        public IMovementCommandService InstanceMovement(DTO.MovementTypeEnum type)
        {
            switch (type)
            {
                case DTO.MovementTypeEnum.Bill:
                    MovementService = new MovementBill();
                    break;
                case DTO.MovementTypeEnum.Referrals:
                    break;
                case DTO.MovementTypeEnum.Output:
                    break;
                case DTO.MovementTypeEnum.CreditNote:
                    break;
                case DTO.MovementTypeEnum.DebitNote:
                    break;
                default:
                    break;
            }
            return MovementService;
        }
    }
}
