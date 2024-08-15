using Kahininden.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kahininden.Entity.Concrete;
public class Model : BaseEntity
{
    public Guid BrandId { get; set; }
    public virtual Brand Brand { get; set; }
}
