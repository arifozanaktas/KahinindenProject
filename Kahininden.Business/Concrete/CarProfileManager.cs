using Kahininden.Business.Abstract;
using Kahininden.DataAccess.Abstract;
using Kahininden.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kahininden.Business.Concrete;
public class CarProfileManager : ICarProfileService
{
    private readonly ICarProfileDal _carProfileDal;
    public CarProfileManager(ICarProfileDal carProfileDal)
    {
        _carProfileDal = carProfileDal;
    }

    public List<CarProfile> GetAll()
    {
        return _carProfileDal.GetAll();
    }

    public IQueryable<CarProfile> GetAllQueryable()
    {
        return _carProfileDal.GetAllQueryable();
    }

    public CarProfile GetById(string id)
    {
        return _carProfileDal.Get(a=>a.Id.ToString()== id);
    }

    public void Insert(CarProfile entity)
    {
        _carProfileDal.Add(entity);
    }

    public void Remove(CarProfile entity)
    {
        entity.IsDelete = true;
        _carProfileDal.Update(entity);
    }

    public void Update(CarProfile entity)
    {
        _carProfileDal.Update(entity);
    }
}
