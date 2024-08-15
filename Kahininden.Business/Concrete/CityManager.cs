using Kahininden.Business.Abstract;
using Kahininden.DataAccess.Abstract;
using Kahininden.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kahininden.Business.Concrete;
public class CityManager : ICityService
{
    private readonly ICityDal _cityDal;
    public CityManager(ICityDal cityDal)
    {
        _cityDal = cityDal;
    }
    public List<City> GetAll()
    {
        return _cityDal.GetAll(x => x.IsDelete == false);
    }

    public IQueryable<City> GetAllQueryable()
    {
        return _cityDal.GetAllQueryable();
    }

    public City GetById(string id)
    {
        return _cityDal.Get(x => x.Id.ToString() == id);
    }

    public void Insert(City entity)
    {
        _cityDal.Add(entity);
    }

    public void Remove(City entity)
    {
        entity.IsDelete = true;
        _cityDal.Update(entity);
    }

    public void Update(City entity)
    {
        _cityDal.Update(entity);
    }

}
