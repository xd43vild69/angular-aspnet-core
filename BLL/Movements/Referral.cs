using System;
using System.Collections.Generic;
using System.Text;
using DTO;

namespace BLL.Movements
{
    public class Referral : IMovementCommandService
    {
        public void ExcecuteMovementOnKardex(Movement movement, ref Kardex kardex)
        {
            throw new NotImplementedException();
        }

        public void UndoMovementOnKardex(Movement movement, ref Kardex kardex)
        {
            throw new NotImplementedException();
        }

        public void UpdateMovementOnKardex(Movement movement, ref Kardex kardex)
        {
            throw new NotImplementedException();
        }
    }
}
