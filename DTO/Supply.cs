using System.Collections.Generic;

namespace DTO
{
    public class Supply : Entity
    {
        public virtual ICollection<BudgetSupply> BudgetSupplies { get; set; }
    }
}
