using Kahininden.Business.Abstract;
using Kahininden.DataAccess.Abstract;
using Kahininden.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kahininden.Business.Concrete;
public class ModelManager : IModelService
{
    private readonly IModelDal _modelDal;

    public ModelManager(IModelDal modelDal)
    {
        _modelDal = modelDal;
    }

    public List<Model> GetAll()
    {
        return _modelDal.GetAll();
    }

    public IQueryable<Model> GetAllQueryable()
    {
        return _modelDal.GetAllQueryable();
    }

    public Model GetById(string id)
    {
        return _modelDal.Get(x => x.Id.ToString() == id);
    }

    public void Insert(Model entity)
    {
        _modelDal.Add(entity);
    }

    public void Remove(Model entity)
    {
        entity.IsDelete = true;
        _modelDal.Update(entity);
    }

    public void Update(Model entity)
    {
        _modelDal.Update(entity);
    }
}
