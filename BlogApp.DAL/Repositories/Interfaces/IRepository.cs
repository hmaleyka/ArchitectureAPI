﻿using BlogApp.Core.Entities.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.DAL.Repositories.Interfaces
{
    public interface IRepository<TEntity> where TEntity : BaseEntity, new()
    {
         DbSet<TEntity> Table { get; }
         Task<IQueryable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>>? expression = null,
            Expression<Func<TEntity, object>>? OrderByExpression = null,
            bool isDescending = false
            , params string[] includes);
         Task Create(TEntity entity);
         void Update(TEntity entity);

         void Delete(TEntity entity);
         Task SaveChangesAsync();
    }
}