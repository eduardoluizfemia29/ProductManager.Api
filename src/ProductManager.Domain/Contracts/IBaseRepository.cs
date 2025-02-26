﻿using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ProductManager.Domain.Contracts
{
    public interface IBaseRepository<T>
    {
        Task<IEnumerable<T>> FindAsync(CancellationToken cancellationToken = default);
        Task<T> GetByIdAsync(string id, CancellationToken cancellationToken = default);
        Task InsertOneAsync(T entity, CancellationToken cancellationToken = default);
        Task ReplaceOneAsync(T entity, CancellationToken cancellationToken = default);
        Task DeleteOneAsync(T entity, CancellationToken cancellationToken = default);
    }
}