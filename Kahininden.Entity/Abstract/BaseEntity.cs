using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kahininden.Entity.Abstract;
public abstract class BaseEntity : IEntity
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public DateTime CreateAt { get; set; } = DateTime.Now;
    public DateTime? UpdateAt { get; set; }
    public bool IsActive { get; set; } = true;
    public bool IsDelete { get; set; } = false;
}
