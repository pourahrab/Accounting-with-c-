using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Expressions;

namespace Accounting.DataLayer.Services
{
    public class GenericRepository<EntityType> where EntityType:class
    {
        private Accounting_DBEntities _db;
        private DbSet<EntityType> _dbset;

        public GenericRepository(Accounting_DBEntities db)
        {
            _db = db;
            _dbset = _db.Set<EntityType>();
        }

        public virtual IEnumerable<EntityType> GetAll(Expression<Func<EntityType, bool>> where = null)
        {
            IQueryable<EntityType> query = _dbset;
            if (where != null)
            {
                query = query.Where(where);
            }
            return query.ToList();
        }

        public virtual EntityType GetById(object Id)
        {
            return _dbset.Find(Id);
        }
        public virtual void Insert(EntityType entity)
        {
            _dbset.Add(entity);
        }

       
        public virtual void Update(EntityType entity)
        {

            _db.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delete(EntityType entity)
        {
            if( _db.Entry(entity).State == EntityState.Detached )
            {
                _dbset.Attach(entity);
            }
            _dbset.Remove(entity);
        }

        public virtual void Delete(object Id)
        {
            var entity = GetById(Id);
            Delete(entity);
        }
    }
}
