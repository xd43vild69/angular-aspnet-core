using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Store.Strategy
{
    public class StoreContext
    {
        public IStore Store { get; set; }

        public StoreContext(IStore store)
        {
            Store = store;
        }

        public Kardex ExecuteMovement()
        {
            return Store.ExecuteMovementOnKardex();
        }

    }
}
