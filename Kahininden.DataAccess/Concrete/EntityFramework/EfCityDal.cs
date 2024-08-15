﻿using Kahininden.DataAccess.Abstract;
using Kahininden.DataAccess.Concrete.Contexts;
using Kahininden.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kahininden.DataAccess.Concrete.EntityFramework;
public class EfCityDal : EfEntityRepositoryDal<City>, ICityDal
{
    public EfCityDal(KahinindenContext context) : base(context)
    {
    }
}