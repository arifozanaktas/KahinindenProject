using Kahininden.DataAccess.Abstract;
using Kahininden.DataAccess.Concrete.Contexts;
using Kahininden.Entity.Concrete;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kahininden.DataAccess.Concrete.EntityFramework;
public class EfModelDal : EfEntityRepositoryDal<Model>, IModelDal
{
    public EfModelDal(KahinindenContext context) : base(context)
    {
    }
}
