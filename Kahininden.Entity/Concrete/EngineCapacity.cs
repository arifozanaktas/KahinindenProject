using Kahininden.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kahininden.Entity.Concrete;
public class EngineCapacity : BaseEntity
{
    public Guid ModelId { get; set; }
    public virtual Model Model { get; set; }
}
