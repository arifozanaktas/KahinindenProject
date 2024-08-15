using Kahininden.DataAccess.Abstract;
using Kahininden.DataAccess.Concrete.Contexts;
using Kahininden.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kahininden.DataAccess.Concrete.EntityFramework;
public class EfBrandDal : EfEntityRepositoryDal<Brand>, IBrandDal
{
    public EfBrandDal(KahinindenContext context) : base(context)
    {
    }
}
