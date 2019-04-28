using DTO;

namespace BLL.Movements
{
    public interface IMovementCommandService
    {
        Kardex ExcecuteMovementOnKardex(Movement movement, Kardex kardex);
        Kardex UndoMovementOnKardex(Movement movement, Kardex kardex);
        Kardex UpdateMovementOnKardex(Movement movement, Kardex kardex);
    }
}
