using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{

    //Generic Constraint Generic kısıtlama // T bir class bir referans tipi olacak şekilde kısıtlandı
    //Herhangi bir class da olamasın IEntitiy olsun
    //class : referans tipi
    //IEntity : IEntity olabilir veya IEntity implemente eden bir nesne olabilir.
    //new() : New lenebilir olmalı
    public interface IEntityRepository<T> where T:class,IEntitiy,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
