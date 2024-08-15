using Kahininden.Business.Abstract;
using Kahininden.DataAccess.Abstract;
using Kahininden.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kahininden.Business.Concrete;
public class EngineCapacityManager : IEngineCapacityService
{
    private readonly IEngineCapacityDal _engineCapacityDal;
    public EngineCapacityManager(IEngineCapacityDal engineCapacityDal)
    {
        _engineCapacityDal = engineCapacityDal;
    }

    public List<EngineCapacity> GetAll()
    {
        return _engineCapacityDal.GetAll();
    }

    public IQueryable<EngineCapacity> GetAllQueryable()
    {
        return _engineCapacityDal.GetAllQueryable();
    }

    public EngineCapacity GetById(string id)
    {
        return _engineCapacityDal.Get(x=>x.Id.ToString() == id);
    }

    public void Insert(EngineCapacity entity)
    {
        _engineCapacityDal.Add(entity);
    }

    public void Remove(EngineCapacity entity)
    {
        entity.IsDelete = true;
        _engineCapacityDal.Update(entity);
    }

    public void Update(EngineCapacity entity)
    {
        _engineCapacityDal.Update(entity);
    }
}
