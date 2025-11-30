using BeautySalon.Entities;
using Microsoft.EntityFrameworkCore;
using System.Security.Principal;

namespace BeautySalon.Data
{
    public class Repository<T> where T : class, IIdEntity
    {
        DbContext ctx;

        public Repository(DbContext ctx)
        {
            this.ctx = ctx;
        }

        public void Create(T entity)
        {
            ctx.Set<T>().Add(entity);
            ctx.SaveChanges();
        }

        public void CreateMany(IEnumerable<T> entities)
        {
            ctx.Set<T>().AddRange(entities);
            ctx.SaveChanges();
        }

        public async Task CreateManyAsync(IEnumerable<T> entities)
        {
            ctx.Set<T>().AddRange(entities);
            await ctx.SaveChangesAsync();
        }

        public async Task CreateAsync(T entity)
        {
            ctx.Set<T>().Add(entity);
            await ctx.SaveChangesAsync();
        }

        public T FindById(string id)
        {
            return ctx.Set<T>().FirstOrDefault(t => t.Id == id)!;
        }


        public void DeleteById(string id)
        {
            var entity = FindById(id);
            ctx.Set<T>().Remove(entity);
            ctx.SaveChanges();
        }

        public async Task DeleteByIdAsync(string id)
        {
            var entity = FindById(id);
            ctx.Set<T>().Remove(entity);
            await ctx.SaveChangesAsync();
        }

        public void Delete(T entity)
        {
            ctx.Set<T>().Remove(entity);
            ctx.SaveChanges();
        }

        public IQueryable<T> GetAll()
        {
            return ctx.Set<T>();
        }

        public void Update(T entity)
        {
            var old = FindById(entity.Id);
            foreach (var prop in typeof(T).GetProperties())
            {
                prop.SetValue(old, prop.GetValue(entity));
            }
            ctx.Set<T>().Update(old);
            ctx.SaveChanges();
        }

        public async Task UpdateAsync(T entity)
        {
            var old = FindById(entity.Id);
            foreach (var prop in typeof(T).GetProperties())
            {
                prop.SetValue(old, prop.GetValue(entity));
            }
            ctx.Set<T>().Update(old);
            await ctx.SaveChangesAsync();
        }
    }
}
