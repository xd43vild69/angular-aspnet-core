using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class Budget: Entity
    {
        public virtual ICollection<BudgetSupply> BudgetSupplies { get; set; }
    }
}
