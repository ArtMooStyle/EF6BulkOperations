using System.Collections.Generic;
#if EF6 
using System.Data.Entity;
#endif
using EntityFramework.BulkExtensions.Commons.BulkOperations;
using EntityFramework.BulkExtensions.Commons.Extensions;
using EntityFramework.BulkExtensions.Commons.Flags;
using EntityFramework.BulkExtensions.Extensions;
#if !EF6
using Microsoft.EntityFrameworkCore;
#endif

namespace EntityFramework.BulkExtensions
{
    public static class BulkExtensions
    {
        public static int BulkInsert<TEntity>(this DbContext context, IEnumerable<TEntity> entities, InsertOptions options = InsertOptions.Default) where TEntity : class
        {
            var entityType = typeof(TEntity);
            return context.GetContextWrapper<TEntity>().CommitTransaction(entities, Operation.Insert, options.ToSharedOptions());
        }

        public static int BulkUpdate<TEntity>(this DbContext context, IEnumerable<TEntity> entities, UpdateOptions options = UpdateOptions.Default) where TEntity : class
        {
            var entityType = typeof(TEntity);
            return context.GetContextWrapper<TEntity>().CommitTransaction(entities, Operation.Update, options.ToSharedOptions());
        }

        public static int BulkInsertOrUpdate<TEntity>(this DbContext context, IEnumerable<TEntity> entities, InsertOptions options = InsertOptions.Default) where TEntity : class
        {
            return context.GetContextWrapper<TEntity>().CommitTransaction(entities, Operation.InsertOrUpdate, options.ToSharedOptions());
        }

        public static int BulkDelete<TEntity>(this DbContext context, IEnumerable<TEntity> entities) where TEntity : class
        {
            return context.GetContextWrapper<TEntity>().CommitTransaction(entities, Operation.Delete);
        }
    }
}