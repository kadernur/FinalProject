using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            //using bloğu performans artışı sağlar
            //benim işim bitti hemen ortalığı toplar der.
            using (NorthwindContext context =new NorthwindContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Product entity)
        {
            using (NorthwindContext context=new NorthwindContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            //Tek bir data getircek.
            using (NorthwindContext context=new NorthwindContext())
            {
                return context.Set<Product>().SingleOrDefault(filter);
            }

        }




        //expression ifadesi filtrelememize olanak sağlayan yapıdır.
        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {

            //filtre yazdık ama istersel filtre vermeyebilir.
            using (NorthwindContext context =new NorthwindContext())
            {
                //eğer filtre vermemişsek veri tabanındaki tüm data getirir.
                //DbSet'teki bütün tabloyu listeye çeviri
                return filter == null 
                    ? context.Set<Product>().ToList()
                    : context.Set<Product>().Where(filter).ToList();


            }
        }

        public void Update(Product entity)
        {

            using (NorthwindContext context=new NorthwindContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();

            }
        }

    }
}
