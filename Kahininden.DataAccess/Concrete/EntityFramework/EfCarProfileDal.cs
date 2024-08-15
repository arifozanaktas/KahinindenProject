using Kahininden.DataAccess.Abstract;
using Kahininden.DataAccess.Concrete.Contexts;
using Kahininden.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kahininden.DataAccess.Concrete.EntityFramework;
public class EfCarProfileDal : EfEntityRepositoryDal<CarProfile>, ICarProfileDal
{
    public EfCarProfileDal(KahinindenContext context) : base(context)
    {
    }
}
