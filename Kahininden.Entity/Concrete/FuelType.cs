using Kahininden.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kahininden.Entity.Concrete;
public class FuelType : BaseEntity
{
    public Guid EngineCapacityId { get; set; }
    public virtual EngineCapacity EngineCapacity { get; set; }
}
