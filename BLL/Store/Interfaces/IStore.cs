using DTO;

namespace BLL.Store
{
    public interface IStore
    {
        Kardex ExecuteMovementOnKardex();
        Kardex UndoMovementOnKardex();
        Kardex UpdateMovementOnKardex();
    }
}