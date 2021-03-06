﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Test.DAL;
using Test.Repository.Common;


namespace Test.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected VehicleContext context;
        internal DbSet<T> dbSet;

        public GenericRepository(VehicleContext context)
        {
            this.context = context;
            this.dbSet = context.Set<T>();
        }

        public DbSet<T> DbSet
        {
            get { return this.dbSet; }
        }

        public virtual async Task<T> Get(int id)
        {
            return await dbSet.FindAsync(id);
        }

        public virtual async Task<IEnumerable<T>> GetAll(
              Expression<Func<T, bool>> filter = null,
              Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
              string includeProperties = "")
        {
            IQueryable<T> query = dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return await orderBy(query).ToListAsync();
            }
            else
            {
                return await query.ToListAsync();
            }
        }
        public virtual async Task<T> Insert(T t)
        {
            context.Set<T>().Add(t);
            await context.SaveChangesAsync();
            return t;

        }
        public virtual async Task<T> Update(T t, int id)
        {
            if (t == null || id == null)
                return null;
            T exist = await this.Get(id);
            if (exist != null)
            {
                context.Entry(exist).CurrentValues.SetValues(t);
                await context.SaveChangesAsync();
            }
            return exist;
        }
        public virtual async Task<int> Delete(int id)
        {

            T exist = await this.Get(id);
            if (exist != null)
            {
                context.Set<T>().Remove(exist);
            }
            return await context.SaveChangesAsync();
        }
    }
}


