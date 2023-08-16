﻿using AgLeather.Shop.Application.Repositories;
using AgLeather.Shop.Domain.Common;
using AgLeather.Shop.Domain.UWork;
using AgLeather.Shop.Persistance.Context;
using Microsoft.Extensions.DependencyInjection;

namespace AgLeather.Shop.Persistance.UWork
{
    public class UnitWork : IUnitWork
    {
        private Dictionary<Type, object> _repositories;
        private readonly IServiceProvider _serviceProvider;
        private readonly AgLeatherContext _context;

        public UnitWork(IServiceProvider serviceProvider, AgLeatherContext context)
        {
            _repositories = new Dictionary<Type, object>();
            _serviceProvider = serviceProvider;
            _context = context;
            _context = context;
        }


        public async Task<bool> CommitAsync()
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    await _context.SaveChangesAsync();
                    transaction.Commit();
                }
                catch
                {
                    await transaction.RollbackAsync();
                    throw;
                }
            }
        

            return true;
        }

        public IRepository<T> GetRepository<T>() where T : BaseEntity
        {
            if(_repositories.ContainsKey(typeof(IRepository<T>)))
            {
                return (IRepository<T>)_repositories[typeof(IRepository<T>)];
            }

            using (var scope = _serviceProvider.CreateScope())
            {
                var repository = scope.ServiceProvider.GetRequiredService<IRepository<T>>();
                _repositories.Add(typeof(IRepository<T>), repository);
                return repository;
            }

        }

       
    }
}
