using Kahininden.DataAccess.Abstract;
using Kahininden.DataAccess.Concrete.Contexts;
using Kahininden.Entity.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Kahininden.DataAccess.Concrete.EntityFramework;
public class EfEntityRepositoryDal<TEntity> : IEntityDal<TEntity> where TEntity : BaseEntity, new()
{
    private KahinindenContext _context;
    private DbSet<TEntity> _dbSet;

    public EfEntityRepositoryDal(KahinindenContext context)
    {
        _context = context;
        _dbSet = _context.Set<TEntity>();
    }

    public void Add(TEntity entity)
    {
        entity.IsActive = true;
        entity.IsDelete = false;
        entity.CreateAt = DateTime.Now;
        _dbSet.Add(entity);
        _context.SaveChanges();
    }

    public void Delete(TEntity entity)
    {
        entity.IsDelete=true;
        entity.IsActive=false;
        entity.UpdateAt = DateTime.Now;
        _dbSet.Update(entity);
        _context.SaveChanges();
    }

    public TEntity Get(Expression<Func<TEntity, bool>> filter)
    {
        return _dbSet.FirstOrDefault(filter);
    }

    public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
    {
        var result = _dbSet.Where(x=>x.IsDelete ==false);
        return filter == null ? result.ToList() : result.Where(filter).ToList();
    }

    public IQueryable<TEntity> GetAllQueryable(Expression<Func<TEntity, bool>> filter = null)
    {
        return filter == null ? _dbSet  : _dbSet.Where(filter);
    }

    public void Update(TEntity entity)
    {
        entity.UpdateAt= DateTime.Now;
        _dbSet.Update(entity);
        _context.SaveChanges();
    }
}
