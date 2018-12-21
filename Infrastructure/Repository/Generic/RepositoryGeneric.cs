using System;
using System.Collections.Generic;
using System.Text;
using Domain.Interface.Generic;
using Infrastructure.Config;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository.Generic
{
    public class RepositoryGeneric<T> : IGeneric<T>, IDisposable where T : class
    {
        private DbContextOptionsBuilder<ContextBase> _optionsBuilder;

        public RepositoryGeneric()
        {
            _optionsBuilder = new DbContextOptionsBuilder<ContextBase>();
        }

        ~RepositoryGeneric()
        {
            Dispose(false);
        }
        public void Add(T entities)
        {
            using (var dbcontext = new DbContext(_optionsBuilder.Options))
            {
                dbcontext.Add(entities);
                dbcontext.SaveChanges();
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool status)
        {
            if (!status)
            {
                return;
            }
        }
    }
}
