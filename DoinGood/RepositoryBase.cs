﻿using DoinGood.Contracts;
using DoinGood.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DoinGood
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected ApplicationDbContext ApplicationDbContext { get; set; }
        public RepositoryBase(ApplicationDbContext applicationDbContext)
        {
            ApplicationDbContext = applicationDbContext;
        }
        public IQueryable<T> FindAll()
        {
            return ApplicationDbContext.Set<T>().AsNoTracking();
        }
        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return ApplicationDbContext.Set<T>().Where(expression).AsNoTracking();
        }
        public IQueryable<T> FindByConditionInclude(Expression<Func<T, bool>> expression, Expression<Func<T, bool>> includeExpression)
        {
            return ApplicationDbContext.Set<T>().Where(expression).Include(includeExpression).AsNoTracking();
        }
        public void Create(T entity)
        {
            ApplicationDbContext.Set<T>().Add(entity);
        }
        public void Update(T entity)
        {
            ApplicationDbContext.Set<T>().Update(entity);
        }
        public void Delete(T entity)
        {
            ApplicationDbContext.Set<T>().Remove(entity);
        }
    }
}
