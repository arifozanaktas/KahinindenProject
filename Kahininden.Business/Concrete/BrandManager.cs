using Kahininden.Business.Abstract;
using Kahininden.DataAccess.Abstract;
using Kahininden.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kahininden.Business.Concrete;
public class BrandManager : IBrandService
{
    private readonly IBrandDal _brandDal;
    public BrandManager(IBrandDal brandDal)
    {
        _brandDal = brandDal;
    }
    public List<Brand> GetAll()
    {
        return _brandDal.GetAll(x => x.IsDelete == false);
    }

    public IQueryable<Brand> GetAllQueryable()
    {
        return _brandDal.GetAllQueryable();
    }

    public Brand GetById(string id)
    {
        return _brandDal.Get(x => x.Id.ToString() == id);
    }

    public void Insert(Brand entity)
    {
        _brandDal.Add(entity);
    }

    public void Remove(Brand entity)
    {
        entity.IsDelete = true;
        _brandDal.Update(entity);
    }

    public void Update(Brand entity)
    {
        _brandDal.Update(entity);
    }
}
