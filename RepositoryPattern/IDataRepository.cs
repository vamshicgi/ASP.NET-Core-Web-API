﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETCoreWebAPI.RepositoryPattern
{
    public interface IDataRepository<TEntity, TDto>
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(long id);
        TDto GetDto(long id);
        void Add(TEntity entity);
        void Update(TEntity entityToUpdate, TEntity entity);
        void Delete(TEntity entity);
    }
}
