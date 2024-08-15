using Kahininden.Business.Abstract;
using Kahininden.DataAccess.Abstract;
using Kahininden.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kahininden.Business.Concrete;
public class FuelTypeManager : IFuelTypeService
{
    private readonly IFuelTypeDal _fuelTypeDal;

    public FuelTypeManager(IFuelTypeDal fuelTypeDal)
    {
        _fuelTypeDal = fuelTypeDal;
    }
    public List<FuelType> GetAll()
    {
        return _fuelTypeDal.GetAll();
    }

    public IQueryable<FuelType> GetAllQueryable()
    {
        return _fuelTypeDal.GetAllQueryable();
    }

    public FuelType GetById(string id)
    {
        return _fuelTypeDal.Get(x => x.Id.ToString() == id);
    }

    public void Insert(FuelType entity)
    {
        _fuelTypeDal.Add(entity);
    }

    public void Remove(FuelType entity)
    {
        entity.IsDelete = true;
        _fuelTypeDal.Update(entity);
    }

    public void Update(FuelType entity)
    {
        _fuelTypeDal.Update(entity);
    }
}
