using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Store.Factory
{
    public class StoreFactory
    {
        private readonly Dictionary<StoresEnum, IStore> Factories;

        public StoreFactory(Movement movement, Kardex kardex)
        {
            Factories = new Dictionary<StoresEnum, IStore>()
            {
                { StoresEnum.Selective, new StoreSelective(movement, kardex)},
                { StoresEnum.Fifo, new StoreFifo()},
                { StoresEnum.Lifo, new StoreLifo()}
            };
        }
        public IStore GetInstance(StoresEnum type)
        {
            return Factories[type];
        }

    }
    public enum StoresEnum { Selective, Lifo, Fifo};
}
