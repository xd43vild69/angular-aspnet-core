using System;
using System.Collections.Generic;
using System.Text;
using DTO;

namespace BLL.Movements
{
    public class Referral : IMovementCommandService
    {
        public Kardex ExcecuteMovementOnKardex(Movement movement, Kardex kardex)
        {
            throw new NotImplementedException();
        }

        public Kardex UndoMovementOnKardex(Movement movement, Kardex kardex)
        {
            throw new NotImplementedException();
        }

        public Kardex UpdateMovementOnKardex(Movement movement, Kardex kardex)
        {
            throw new NotImplementedException();
        }
    }
}
