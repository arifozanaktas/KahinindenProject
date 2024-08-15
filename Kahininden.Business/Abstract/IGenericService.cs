using Kahininden.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kahininden.Business.Abstract;
public interface IGenericService<T> where T : class,IEntity,new()
{
    void Insert(T entity);
    void Update(T entity);
    void Remove(T entity);
    List<T> GetAll();
    T GetById(string id);
    IQueryable<T> GetAllQueryable();
}
