using DTO;

namespace BLL.Movements
{
    public interface IMovementCommandService
    {
        Kardex ExcecuteMovementOnKardex(Kardex kardex);
        Kardex UndoMovementOnKardex(Kardex kardex);
        Kardex UpdateMovementOnKardex(Kardex kardex);
    }
}
