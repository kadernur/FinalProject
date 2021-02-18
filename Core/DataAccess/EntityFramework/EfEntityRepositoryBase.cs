using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;


namespace Core.DataAccess.EntityFramework
{
    //Burda veri tabanı işlemlerimizi evrensel hale getiriyoruz.
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
          where TEntity : class, IEntity, new()
          where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            //using bloğu performans artışı sağlar
            //benim işim bitti hemen ortalığı toplar der.
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            //Tek bir data getircek.
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }

        }




        //expression ifadesi filtrelememize olanak sağlayan yapıdır.
        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {

            //filtre yazdık ama istersel filtre vermeyebilir.
            using (TContext context = new TContext())
            {
                //eğer filtre vermemişsek veri tabanındaki tüm data getirir.
                //DbSet'teki bütün tabloyu listeye çeviri
                return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();


            }
        }

        public void Update(TEntity entity)
        {

            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();

            }
        }
    }
}
