
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.DataAccess
{
//class : referans tip
// IEntity : IEntity veya implemente eden nesne
// new(): new'lebilir nesneler

    public interface IEntityRepository<T> where T : class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
