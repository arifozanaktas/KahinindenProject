using Kahininden.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kahininden.Entity.Concrete;
public class CarProfile : BaseEntity
{
    public int Kilometer { get; set; }
    public string Description { get; set; }
    public Guid EngineCapacityId { get; set; }
    public virtual EngineCapacity EngineCapacity { get; set; }
    public Guid ModelId { get; set; }
    public virtual Model Model { get; set; }

    public Guid BrandId { get; set; }
    public virtual Brand Brand { get; set; }
    public Guid FuelTypeId { get; set; }
    public virtual FuelType FuelType { get; set; }
    public Guid CityId { get; set; }
    public virtual City City { get; set; }
}
