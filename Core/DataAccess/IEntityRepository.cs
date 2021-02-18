using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{

    //generic constraint
    //class: referans tipi
    //IEntity: IEntity olabilir veya IEntity implemente eden bir nesne olabilir.
    //new():newlenebilir olabilir.Ientity newlenemez.
   public  interface IEntityRepository<T> where T:class,IEntity,new()
        //generic yapısı
    {
        //Aşağıdaki yapı LINQ ile verdiğimiz yapıyı sağlar.
        //Örneğin p=>p.CategoryId==2 bu şekilde filtrelemeyi sağlar.
        List<T> GetAll(Expression<Func<T,bool>> filter=null); 
        //refactoring
        //Tek bir data getirmek için ;
        T Get(Expression<Func<T, bool>> filter);

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        //Ürünleri category'e göre filtreleme
        //Yukarıdaki expression sayesinde aşağıdaki koda ihtiyacımız kalmaz.
       // List<T> GetAllByCategory(int categoryId);
    }
}
